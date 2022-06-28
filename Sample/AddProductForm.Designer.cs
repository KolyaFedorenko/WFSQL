namespace Sample
{
    partial class AddProductForm
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
            this.tbArticleNumber = new System.Windows.Forms.TextBox();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.tbProductCost = new System.Windows.Forms.TextBox();
            this.cbSupplierManufacter = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.labelArticleNumber = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductCost = new System.Windows.Forms.Label();
            this.labelSupplierManufacter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbArticleNumber
            // 
            this.tbArticleNumber.Location = new System.Drawing.Point(99, 9);
            this.tbArticleNumber.Name = "tbArticleNumber";
            this.tbArticleNumber.Size = new System.Drawing.Size(204, 20);
            this.tbArticleNumber.TabIndex = 0;
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(99, 36);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(204, 21);
            this.cbProductName.TabIndex = 1;
            // 
            // tbProductCost
            // 
            this.tbProductCost.Location = new System.Drawing.Point(99, 63);
            this.tbProductCost.Name = "tbProductCost";
            this.tbProductCost.Size = new System.Drawing.Size(203, 20);
            this.tbProductCost.TabIndex = 2;
            // 
            // cbSupplierManufacter
            // 
            this.cbSupplierManufacter.FormattingEnabled = true;
            this.cbSupplierManufacter.Location = new System.Drawing.Point(126, 89);
            this.cbSupplierManufacter.Name = "cbSupplierManufacter";
            this.cbSupplierManufacter.Size = new System.Drawing.Size(176, 21);
            this.cbSupplierManufacter.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(20, 117);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(282, 31);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // labelArticleNumber
            // 
            this.labelArticleNumber.AutoSize = true;
            this.labelArticleNumber.Location = new System.Drawing.Point(17, 12);
            this.labelArticleNumber.Name = "labelArticleNumber";
            this.labelArticleNumber.Size = new System.Drawing.Size(76, 13);
            this.labelArticleNumber.TabIndex = 5;
            this.labelArticleNumber.Text = "Article Number";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(17, 39);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(75, 13);
            this.labelProductName.TabIndex = 6;
            this.labelProductName.Text = "Product Name";
            // 
            // labelProductCost
            // 
            this.labelProductCost.AutoSize = true;
            this.labelProductCost.Location = new System.Drawing.Point(18, 66);
            this.labelProductCost.Name = "labelProductCost";
            this.labelProductCost.Size = new System.Drawing.Size(68, 13);
            this.labelProductCost.TabIndex = 7;
            this.labelProductCost.Text = "Product Cost";
            // 
            // labelSupplierManufacter
            // 
            this.labelSupplierManufacter.AutoSize = true;
            this.labelSupplierManufacter.Location = new System.Drawing.Point(17, 92);
            this.labelSupplierManufacter.Name = "labelSupplierManufacter";
            this.labelSupplierManufacter.Size = new System.Drawing.Size(104, 13);
            this.labelSupplierManufacter.TabIndex = 8;
            this.labelSupplierManufacter.Text = "Supplier/Manufacter";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 154);
            this.Controls.Add(this.labelSupplierManufacter);
            this.Controls.Add(this.labelProductCost);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelArticleNumber);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cbSupplierManufacter);
            this.Controls.Add(this.tbProductCost);
            this.Controls.Add(this.cbProductName);
            this.Controls.Add(this.tbArticleNumber);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArticleNumber;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.TextBox tbProductCost;
        private System.Windows.Forms.ComboBox cbSupplierManufacter;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label labelArticleNumber;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductCost;
        private System.Windows.Forms.Label labelSupplierManufacter;
    }
}