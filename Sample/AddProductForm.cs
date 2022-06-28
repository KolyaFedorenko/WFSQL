using WFSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class AddProductForm : Form
    {
        Database database = new Database(@"Data Source=ADMI11\SQLEXPRESSNEW;Initial Catalog=Trade;User ID=sa;Password=Fosodo11*");
        private Forms.Callback onProductAddedListener;

        public AddProductForm(Forms.Callback onProductAddedListener)
        {
            InitializeComponent();
            database.FillComboBox("SELECT ProductNameId, ProductName FROM ProductName", cbProductName, "ProductNameId", "ProductName");
            database.FillComboBox("SELECT SupplierId, SupplierName FROM Supplier", cbSupplierManufacter, "SupplierId", "SupplierName");
            this.onProductAddedListener = onProductAddedListener;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            database.ExecuteSqlQuery($"INSERT INTO Product(ProductArticleNumber, ProductName, ProductCost, ProductManufacturer, ProductSupplier)" +
                $" VALUES ('{tbArticleNumber.Text}', {cbProductName.SelectedValue}, '{tbProductCost.Text}', {cbSupplierManufacter.SelectedValue}" +
                $", {cbSupplierManufacter.SelectedValue})");
            onProductAddedListener.NotifyParentForm();
        }
    }
}
