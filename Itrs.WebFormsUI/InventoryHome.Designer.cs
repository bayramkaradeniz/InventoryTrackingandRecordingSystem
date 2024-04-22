namespace Itrs.WebFormsUI
{
    partial class InventoryHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxProductNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangeStock = new DevExpress.XtraEditors.SimpleButton();
            this.tbxChangeStockStockAmount = new System.Windows.Forms.TextBox();
            this.tbxChangeStockProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChangeUnitPrice = new DevExpress.XtraEditors.SimpleButton();
            this.tbxChangeUnitPriceUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxChangeUnitPriceProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tbxStockAmountAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxProductDescriptionAdd = new System.Windows.Forms.TextBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvMails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.tbxProductNameSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Product";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(107, 38);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(378, 24);
            this.cbxCategory.TabIndex = 4;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxProductNameSearch
            // 
            this.tbxProductNameSearch.Location = new System.Drawing.Point(617, 35);
            this.tbxProductNameSearch.Name = "tbxProductNameSearch";
            this.tbxProductNameSearch.Size = new System.Drawing.Size(308, 22);
            this.tbxProductNameSearch.TabIndex = 3;
            this.tbxProductNameSearch.TextChanged += new System.EventHandler(this.tbxProductNameSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category :";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(4, 111);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(988, 172);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangeStock);
            this.groupBox2.Controls.Add(this.tbxChangeStockStockAmount);
            this.groupBox2.Controls.Add(this.tbxChangeStockProductName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 567);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnChangeStock
            // 
            this.btnChangeStock.Location = new System.Drawing.Point(364, 22);
            this.btnChangeStock.Name = "btnChangeStock";
            this.btnChangeStock.Size = new System.Drawing.Size(115, 62);
            this.btnChangeStock.TabIndex = 4;
            this.btnChangeStock.Text = "Change Stock";
            this.btnChangeStock.Click += new System.EventHandler(this.btnChangeStock_Click);
            // 
            // tbxChangeStockStockAmount
            // 
            this.tbxChangeStockStockAmount.Location = new System.Drawing.Point(131, 59);
            this.tbxChangeStockStockAmount.Name = "tbxChangeStockStockAmount";
            this.tbxChangeStockStockAmount.Size = new System.Drawing.Size(227, 22);
            this.tbxChangeStockStockAmount.TabIndex = 3;
            // 
            // tbxChangeStockProductName
            // 
            this.tbxChangeStockProductName.Location = new System.Drawing.Point(131, 21);
            this.tbxChangeStockProductName.Name = "tbxChangeStockProductName";
            this.tbxChangeStockProductName.Size = new System.Drawing.Size(227, 22);
            this.tbxChangeStockProductName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stock Amount : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChangeUnitPrice);
            this.groupBox3.Controls.Add(this.tbxChangeUnitPriceUnitPrice);
            this.groupBox3.Controls.Add(this.tbxChangeUnitPriceProductName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(509, 567);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnChangeUnitPrice
            // 
            this.btnChangeUnitPrice.Location = new System.Drawing.Point(340, 22);
            this.btnChangeUnitPrice.Name = "btnChangeUnitPrice";
            this.btnChangeUnitPrice.Size = new System.Drawing.Size(139, 62);
            this.btnChangeUnitPrice.TabIndex = 4;
            this.btnChangeUnitPrice.Text = "Change Unit Price";
            this.btnChangeUnitPrice.Click += new System.EventHandler(this.btnChangeUnitPrice_Click);
            // 
            // tbxChangeUnitPriceUnitPrice
            // 
            this.tbxChangeUnitPriceUnitPrice.Location = new System.Drawing.Point(131, 59);
            this.tbxChangeUnitPriceUnitPrice.Name = "tbxChangeUnitPriceUnitPrice";
            this.tbxChangeUnitPriceUnitPrice.Size = new System.Drawing.Size(203, 22);
            this.tbxChangeUnitPriceUnitPrice.TabIndex = 3;
            // 
            // tbxChangeUnitPriceProductName
            // 
            this.tbxChangeUnitPriceProductName.Location = new System.Drawing.Point(131, 21);
            this.tbxChangeUnitPriceProductName.Name = "tbxChangeUnitPriceProductName";
            this.tbxChangeUnitPriceProductName.Size = new System.Drawing.Size(203, 22);
            this.tbxChangeUnitPriceProductName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Unit Price : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product Name :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProductAdd);
            this.groupBox4.Controls.Add(this.tbxStockAmountAdd);
            this.groupBox4.Controls.Add(this.cbxCategoryAdd);
            this.groupBox4.Controls.Add(this.tbxUnitPriceAdd);
            this.groupBox4.Controls.Add(this.tbxProductDescriptionAdd);
            this.groupBox4.Controls.Add(this.tbxProductNameAdd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 686);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(988, 228);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Product";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(845, 120);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(139, 62);
            this.btnProductAdd.TabIndex = 5;
            this.btnProductAdd.Text = "Add Product ";
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // tbxStockAmountAdd
            // 
            this.tbxStockAmountAdd.Location = new System.Drawing.Point(131, 160);
            this.tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            this.tbxStockAmountAdd.Size = new System.Drawing.Size(237, 22);
            this.tbxStockAmountAdd.TabIndex = 9;
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(590, 95);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(237, 24);
            this.cbxCategoryAdd.TabIndex = 8;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(131, 100);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(237, 22);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // tbxProductDescriptionAdd
            // 
            this.tbxProductDescriptionAdd.Location = new System.Drawing.Point(590, 38);
            this.tbxProductDescriptionAdd.Name = "tbxProductDescriptionAdd";
            this.tbxProductDescriptionAdd.Size = new System.Drawing.Size(237, 22);
            this.tbxProductDescriptionAdd.TabIndex = 6;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(131, 35);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(237, 22);
            this.tbxProductNameAdd.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Stock Amount :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Category :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Unit Price :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Product Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(4, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(984, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvMails);
            this.groupBox5.Location = new System.Drawing.Point(6, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(986, 210);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mails";
            // 
            // dgvMails
            // 
            this.dgvMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMails.Location = new System.Drawing.Point(0, 21);
            this.dgvMails.Name = "dgvMails";
            this.dgvMails.RowHeadersWidth = 51;
            this.dgvMails.RowTemplate.Height = 24;
            this.dgvMails.Size = new System.Drawing.Size(986, 172);
            this.dgvMails.TabIndex = 2;
            // 
            // InventoryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 953);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryHome";
            this.Text = "InventoryHome";
            this.Load += new System.EventHandler(this.InventoryHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxProductNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnChangeStock;
        private System.Windows.Forms.TextBox tbxChangeStockStockAmount;
        private System.Windows.Forms.TextBox tbxChangeStockProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnChangeUnitPrice;
        private System.Windows.Forms.TextBox tbxChangeUnitPriceUnitPrice;
        private System.Windows.Forms.TextBox tbxChangeUnitPriceProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton btnProductAdd;
        private System.Windows.Forms.TextBox tbxStockAmountAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxProductDescriptionAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvMails;
    }
}