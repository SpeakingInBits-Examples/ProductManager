namespace ProductManager
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstProducts = new ListBox();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(24, 44);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(261, 139);
            lstProducts.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(330, 44);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(144, 70);
            btnDeleteProduct.TabIndex = 1;
            btnDeleteProduct.Text = "Delete Selected Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(330, 129);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(144, 70);
            btnUpdateProduct.TabIndex = 2;
            btnUpdateProduct.Text = "Update Selected Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(330, 218);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(144, 70);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add New Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 315);
            Controls.Add(btnAddProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(lstProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
    }
}
