namespace ProductManager
{
    partial class AddUpdateProductForm
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
            label1 = new Label();
            label2 = new Label();
            this.txtProductName = new TextBox();
            this.txtSalesPrice = new TextBox();
            btnAddProduct = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 68);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 127);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Sales Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new Point(159, 65);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new Size(100, 23);
            this.txtProductName.TabIndex = 2;
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new Point(159, 124);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new Size(100, 23);
            this.txtSalesPrice.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(99, 181);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(140, 69);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // AddUpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 312);
            Controls.Add(btnAddProduct);
            Controls.Add(this.txtSalesPrice);
            Controls.Add(this.txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUpdateProductForm";
            Text = "AddUpdateProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProductName;
        private TextBox txtSalesPrice;
        private Button btnAddProduct;
    }
}