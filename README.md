Inventory Tracking and Recording System

This application is developed using the .NET Framework to manage products in stock and record transactions. The application allows users to view products in stock, add new products, update the stock and price of existing products and delete the product. Also, all transactions are recorded in a database and notified to the administrator by mail.
Features
- View products in stock
- Add new product
- Update stock count and Unit Price of available products
- Product deletion
- Recording transactions and reporting them to the manager via e-mail
- View sent mail

Technologies Used

- NET Framework
- Windows Forms
- Asset Framework
- SQL Server
- Ninject
- Smtp (Simple Mail Transfer Protocol)

  
Installation

1. Clone the project.
2. Open the project in Visual Studio.
3. Create the database with Migrations or Set Up Your Database Connection
4. You need to create a Category for the application to work without errors. Also, mails are sent according to CompanyUsers with Id 1. You should also enter the recipient mail in this class.
4. In the Project MailManager Class, you must write the Sender Mail Address and Password.
5. Start the application.
6. Select the desired action from the main menu:
- "View Stock": View the products in the current stock.
- "Add Product": Add a new product.
- "Update Product Stock Count": Update the Stock Count of an existing product.
- "Update Product Unit Price": Update the Unit Price of an existing product.
- "Delete Product": Delete a product from stock.
- Select the action you want to perform and follow the instructions.

Additon

-This project is open source and open for contributions. All contributions and suggestions are welcome. To contribute, submit a pull request.

