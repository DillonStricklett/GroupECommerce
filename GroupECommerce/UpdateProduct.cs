using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupECommerce
{
	public partial class UpdateProduct : Form
	{
		private readonly IProductContext context;

		public UpdateProduct(Product product, IProductContext _context)
		{
			context = _context;
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
			if (UpdateProductEntry())
				Close();
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
			ProductDb.Update(context, product);
			return true;
		}
	}
}
