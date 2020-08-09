using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupECommerce
{
	public partial class UpdateProduct : Form
	{
		public UpdateProduct(Product product)
		{
			InitializeComponent();
			this.product = product;
			InitializeUpdate();
		}

		private Product product;

		private void InitializeUpdate()
		{
			titleBox.Text = product.Title;
			priceBox.Text = product.Price.ToString();
			catBox.Text = product.Category;
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			
		}

		private bool UpdateProductEntry()
		{
			string title = titleBox.Text;
			if (String.IsNullOrWhiteSpace(title))
			{
				MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			string category = catBox.Text;
			if (String.IsNullOrWhiteSpace(category))
			{
				MessageBox.Show("Category cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (!double.TryParse(priceBox.Text, out double price))
			{
				MessageBox.Show("Price must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			product.Title = titleBox.Text;
			product.Price = price;
			product.Category = category;
			ProductDb.Update(product);
			return true;
		}
	}
}
