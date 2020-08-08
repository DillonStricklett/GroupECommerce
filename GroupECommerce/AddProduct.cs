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
	public partial class AddProduct : Form
	{
		public AddProduct()
		{
			InitializeComponent();
		}

		private void addProdBtn_Click(object sender, EventArgs e)
		{
			string title = titleBox.Text;
			if (String.IsNullOrWhiteSpace(title))
			{
				MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!double.TryParse(priceBox.Text, out double price))
			{
				MessageBox.Show("Price must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}			

			string category = categoryBox.Text;
			if (String.IsNullOrWhiteSpace(category))
			{
				MessageBox.Show("Category cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Product product = new Product
			{
				Title = title,
				Price = price,
				Category = category
			};

			ProductDb.Add(product);
			MessageBox.Show("Product was added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
