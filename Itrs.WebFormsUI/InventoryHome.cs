using Itrs.Business.Abstract;
using Itrs.Business.DependencyRevolvers.Ninject;
using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itrs.WebFormsUI
{
    public partial class InventoryHome : Form
    {
        public InventoryHome()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
            _companyService = InstanceFactory.GetInstance<ICompanyService>();
            _mailService = InstanceFactory.GetInstance<IMailService>();

        }
        
        private IProductService _productService;
        private ICategoryService _categoryService;
        private ILogEntryService _logEntryService;
        private ICompanyService _companyService;
        private IMailService _mailService;

         private void InventoryHome_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            LoadMails();

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxProductNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductNameSearch.Text))
            {
                dgvProducts.DataSource = _productService.GetProductsByProductName(tbxProductNameSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productService.GetAll();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProducts.CurrentRow;
            tbxChangeStockProductName.Text = row.Cells[1].Value.ToString();
            tbxChangeStockStockAmount.Text = row.Cells[4].Value.ToString();
            tbxChangeUnitPriceProductName.Text = row.Cells[1].Value.ToString();
            tbxChangeUnitPriceUnitPrice.Text = row.Cells[3].Value.ToString();
        }

       

        private void LoadMails()
        {
            dgvMails.DataSource = _mailService.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete product {dgvProducts.CurrentRow.Cells[1].Value.ToString()} ?",
                "Do you wanna delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvProducts.CurrentRow != null)
                {

                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Product deleted!");
                    LoadProducts();


                }
                else
                {
                    MessageBox.Show("Product Id is Empty.");
                }
            }
            else
            {
                MessageBox.Show("Product not deleted!");
                LoadProducts();
            }
        }

        private void btnChangeStock_Click(object sender, EventArgs e)
        {
            var row = dgvProducts.CurrentRow;
            String OldStock = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            _productService.ChangeStock(new Product
            {
                ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value.ToString()),
                StockAmount = Convert.ToInt32(tbxChangeStockStockAmount.Text)
            });
            //Recording Logs
            _logEntryService.LogForStockUpdate(new Product
            {
                ProductName = tbxChangeStockProductName.Text,
                StockAmount = Convert.ToInt32(tbxChangeStockStockAmount.Text),
            }, OldStock);
            //Mail Sending
            var lastLog = _logEntryService.GetAll().OrderByDescending(s => s.Id)
                    .FirstOrDefault().Description.ToString();
            string AdminMail = _companyService.GetAdminMail().ToString();
            _mailService.SendMailAsync(AdminMail, lastLog);
            LoadProducts();
            //Recording Mail
            _mailService.LogMail(new Mail
            {
                ReceiverMail = AdminMail,
                MailBody = lastLog
            });
        }

        private void btnChangeUnitPrice_Click(object sender, EventArgs e)
        {
            var row = dgvProducts.CurrentRow;
            String OldPrice = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            _productService.ChangeUnitPrice(new Product
            {
                ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value.ToString()),
                UnitPrice = Convert.ToDecimal(tbxChangeUnitPriceUnitPrice.Text)
            });
            //Recording Logs
            _logEntryService.LogForUnitPriceUpdate(new Product
            {
                ProductName = tbxChangeUnitPriceProductName.Text,
                UnitPrice = Convert.ToDecimal(tbxChangeUnitPriceUnitPrice.Text),
            }, OldPrice);
            //Mail Sending
            var lastLog = _logEntryService.GetAll().OrderByDescending(s => s.Id)
                    .FirstOrDefault().Description.ToString();
            string AdminMail = _companyService.GetAdminMail().ToString();
            _mailService.SendMailAsync(AdminMail, lastLog);
            LoadProducts();
            //Recording Mail
            _mailService.LogMail(new Mail
            {
                ReceiverMail = AdminMail,
                MailBody = lastLog
            });
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            //Add Product
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                ProductName = tbxProductNameAdd.Text,
                ProductDescription = tbxProductDescriptionAdd.Text,
                StockAmount = Convert.ToInt32(tbxStockAmountAdd.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
            });

            //Logging
            _logEntryService.LogForAdd(new Product
            {
                ProductName = tbxProductNameAdd.Text
            });
            var lastLog = _logEntryService.GetAll().OrderByDescending(s => s.Id)
                    .FirstOrDefault().Description.ToString();
            string AdminMail = _companyService.GetAdminMail().ToString();
            //Sending Mail
            _mailService.SendMailAsync(AdminMail, lastLog);
            //Recording Mail
            _mailService.LogMailForAdd(new Mail
            {
                ReceiverMail = AdminMail,
                MailBody = lastLog
            });
            LoadProducts();
        }
        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";
        }
    }
}
