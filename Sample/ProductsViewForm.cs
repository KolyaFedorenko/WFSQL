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
    public partial class ProductsViewForm : Form, Forms.Callback
    {
        Database database = new Database(@"Data Source=ADMI11\SQLEXPRESSNEW;Initial Catalog=Trade;User ID=sa;Password=Fosodo11*");
        AddProductForm addProductForm;
        private bool isFormOpenNotFirstTime = false;
        public ProductsViewForm()
        {
            InitializeComponent();
            RefreshTable();
            database.FillComboBox("SELECT SupplierId, SupplierName FROM Supplier", cbFilter, "SupplierId", "SupplierName");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            addProductForm = new AddProductForm(this);
            addProductForm.ShowDialog();
        }

        private void RefreshTable()
        {
            database.FillDataGridView("SELECT Product.ProductId, Product.ProductArticleNumber, ProductName.ProductName," +
                " Measure.MeasureName, Product.ProductCost, Product.ProductMaximumDiscount, Supplier.SupplierName," +
                " Supplier.SupplierName AS 'Manufacter', ProductCategory.ProductCategory, Product.ProductDiscountAmount," +
                " Product.ProductQuantityInStock, Product.ProductDescription, Product.ProductPhoto FROM Product JOIN ProductName" +
                " ON Product.ProductName = ProductName.ProductNameId JOIN Measure ON Product.ProductMeasure = Measure.MeasureID" +
                " JOIN Supplier ON Product.ProductSupplier = Supplier.SupplierID JOIN ProductCategory ON Product.ProductCategory" +
                " = ProductCategory.ProductCategoryId", dgvProducts);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormOpenNotFirstTime)
            {
                database.FillDataGridView("SELECT Product.ProductId, Product.ProductArticleNumber, ProductName.ProductName," +
                    " Measure.MeasureName, Product.ProductCost, Product.ProductMaximumDiscount, Supplier.SupplierName," +
                    " Supplier.SupplierName AS 'Manufacter', ProductCategory.ProductCategory, Product.ProductDiscountAmount," +
                    " Product.ProductQuantityInStock, Product.ProductDescription, Product.ProductPhoto FROM Product JOIN ProductName" +
                    " ON Product.ProductName = ProductName.ProductNameId JOIN Measure ON Product.ProductMeasure = Measure.MeasureID" +
                    " JOIN Supplier ON Product.ProductSupplier = Supplier.SupplierID JOIN ProductCategory ON Product.ProductCategory" +
                    $" = ProductCategory.ProductCategoryId WHERE Product.ProductSupplier = {cbFilter.SelectedValue}", dgvProducts);
            }
            isFormOpenNotFirstTime = true;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dgvProducts.CurrentCell.RowIndex;
            btnDeleteProduct.Text = $"Delete product with ID = {dgvProducts.Rows[currentRowIndex].Cells[0].Value.ToString()}";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvProducts.CurrentCell.RowIndex;
            string productToDeleteId = dgvProducts.Rows[currentRowIndex].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show($"Delete product with ID {productToDeleteId}?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                database.ExecuteSqlQuery($"DELETE FROM Product WHERE ProductId = {productToDeleteId}");
                RefreshTable();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            database.FillDataGridView("SELECT Product.ProductId, Product.ProductArticleNumber, ProductName.ProductName," +
                " Measure.MeasureName, Product.ProductCost, Product.ProductMaximumDiscount, Supplier.SupplierName," +
                " Supplier.SupplierName AS 'Manufacter', ProductCategory.ProductCategory, Product.ProductDiscountAmount," +
                " Product.ProductQuantityInStock, Product.ProductDescription, Product.ProductPhoto FROM Product JOIN ProductName" +
                " ON Product.ProductName = ProductName.ProductNameId JOIN Measure ON Product.ProductMeasure = Measure.MeasureID" +
                " JOIN Supplier ON Product.ProductSupplier = Supplier.SupplierID JOIN ProductCategory ON Product.ProductCategory" +
                $" = ProductCategory.ProductCategoryId WHERE Product.ProductArticleNumber LIKE '{tbSearch.Text}%'", dgvProducts);
        }
        
        public void NotifyParentForm()
        {
            addProductForm.Close();
            addProductForm.Dispose();
            RefreshTable();
        }
    }
}
