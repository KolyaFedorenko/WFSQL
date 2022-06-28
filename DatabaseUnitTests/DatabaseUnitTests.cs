using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFSQL;

namespace DatabaseUnitTests
{
    [TestClass]
    public class DatabaseUnitTests
    {
        Database database = new Database(@"Data Source=ADMI11\SQLEXPRESSNEW;Initial Catalog=Trade;User ID=sa;Password=Fosodo11*");

        [TestMethod]
        public void TestCheckDataGridViewFilling()
        {
            DataGridView testDataGridView = new DataGridView();
            bool dataGridViewFilled = false;

            dataGridViewFilled = database.FillDataGridView("SELECT * FROM Product", testDataGridView);
            Assert.IsTrue(dataGridViewFilled);
            dataGridViewFilled = database.FillDataGridView("SELECT * FROM NotCreatedTable", testDataGridView);
            Assert.IsFalse(dataGridViewFilled);

            testDataGridView = null;
        }

        [TestMethod]
        public void TestCheckComboBoxFilling()
        {
            ComboBox testComboBox = new ComboBox();
            bool comboBoxFilled = false;

            comboBoxFilled = database.FillComboBox("SELECT Product.ProductId, Product.ProductArticleNumber FROM Product", testComboBox, "ProductId", "ProductName");
            Assert.IsTrue(comboBoxFilled);
            comboBoxFilled = database.FillComboBox("SELECT NonCreatedTable.NonCreatedId, NonCreatedTable.NonCreatedNumber FROM NonCreatedTable", testComboBox, "NonCreatedId", "NonCreatedNumber");
            Assert.IsFalse(comboBoxFilled);

            testComboBox = null;
        }

        [TestMethod]
        public void TestCheckQueryExecution()
        {
            bool queryExecuted = false;

            queryExecuted = database.ExecuteSqlQuery("DELETE FROM Product WHERE ProductId = 31");
            Assert.IsTrue(queryExecuted);
            queryExecuted = database.ExecuteSqlQuery("DELETE FROM NonCreatedTable WHERE NonCreatedId = 0");
            Assert.IsFalse(queryExecuted);
        }
    }
}
