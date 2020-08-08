namespace GroupECommerce
{
	partial class AddProduct
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
			this.titleBox = new System.Windows.Forms.TextBox();
			this.priceBox = new System.Windows.Forms.TextBox();
			this.categoryBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.addProdBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titleBox
			// 
			this.titleBox.Location = new System.Drawing.Point(81, 18);
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(100, 20);
			this.titleBox.TabIndex = 0;
			// 
			// priceBox
			// 
			this.priceBox.Location = new System.Drawing.Point(81, 44);
			this.priceBox.Name = "priceBox";
			this.priceBox.Size = new System.Drawing.Size(100, 20);
			this.priceBox.TabIndex = 1;
			// 
			// categoryBox
			// 
			this.categoryBox.Location = new System.Drawing.Point(81, 70);
			this.categoryBox.Name = "categoryBox";
			this.categoryBox.Size = new System.Drawing.Size(100, 20);
			this.categoryBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Category";
			// 
			// addProdBtn
			// 
			this.addProdBtn.Location = new System.Drawing.Point(92, 96);
			this.addProdBtn.Name = "addProdBtn";
			this.addProdBtn.Size = new System.Drawing.Size(75, 23);
			this.addProdBtn.TabIndex = 6;
			this.addProdBtn.Text = "Add Product";
			this.addProdBtn.UseVisualStyleBackColor = true;
			this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
			// 
			// AddProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(242, 132);
			this.Controls.Add(this.addProdBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.categoryBox);
			this.Controls.Add(this.priceBox);
			this.Controls.Add(this.titleBox);
			this.Name = "AddProduct";
			this.Text = "Add Product";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox titleBox;
		private System.Windows.Forms.TextBox priceBox;
		private System.Windows.Forms.TextBox categoryBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button addProdBtn;
	}
}