namespace GroupECommerce
{
    partial class MainForm
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
            this.addProductBtn = new System.Windows.Forms.Button();
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.allProductsCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(235, 69);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(91, 57);
            this.addProductBtn.TabIndex = 0;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Location = new System.Drawing.Point(235, 156);
            this.updateProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(91, 50);
            this.updateProductBtn.TabIndex = 1;
            this.updateProductBtn.Text = "Update Product";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Location = new System.Drawing.Point(235, 233);
            this.deleteProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(91, 52);
            this.deleteProductBtn.TabIndex = 2;
            this.deleteProductBtn.Text = "Delete Product";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // allProductsCbo
            // 
            this.allProductsCbo.FormattingEnabled = true;
            this.allProductsCbo.Location = new System.Drawing.Point(28, 69);
            this.allProductsCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allProductsCbo.Name = "allProductsCbo";
            this.allProductsCbo.Size = new System.Drawing.Size(147, 24);
            this.allProductsCbo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allProductsCbo);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.addProductBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Product Catalog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.ComboBox allProductsCbo;
        private System.Windows.Forms.Label label1;
    }
}

