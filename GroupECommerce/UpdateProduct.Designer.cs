namespace GroupECommerce
{
	partial class UpdateProduct
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
			this.catBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.updateBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titleBox
			// 
			this.titleBox.Location = new System.Drawing.Point(79, 12);
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(100, 20);
			this.titleBox.TabIndex = 0;
			// 
			// priceBox
			// 
			this.priceBox.Location = new System.Drawing.Point(79, 39);
			this.priceBox.Name = "priceBox";
			this.priceBox.Size = new System.Drawing.Size(100, 20);
			this.priceBox.TabIndex = 1;
			// 
			// catBox
			// 
			this.catBox.Location = new System.Drawing.Point(79, 66);
			this.catBox.Name = "catBox";
			this.catBox.Size = new System.Drawing.Size(100, 20);
			this.catBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Category";
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(89, 92);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(75, 23);
			this.updateBtn.TabIndex = 6;
			this.updateBtn.Text = "Update";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// UpdateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(215, 128);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.catBox);
			this.Controls.Add(this.priceBox);
			this.Controls.Add(this.titleBox);
			this.Name = "UpdateProduct";
			this.Text = "UpdateProduct";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox titleBox;
		private System.Windows.Forms.TextBox priceBox;
		private System.Windows.Forms.TextBox catBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button updateBtn;
	}
}