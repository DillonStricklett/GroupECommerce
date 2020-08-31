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
		private readonly IProductContext context;

		public AddProduct(IProductContext _context)
		{
			context = _context;
			InitializeComponent();
		}

		private void addProdBtn_Click(object sender, EventArgs e)
		{

			// Checks if title and category are null or whitespace
			string title = titleBox.Text;
			if (String.IsNullOrWhiteSpace(title))
			{
				MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string category = categoryBox.Text;
			if (String.IsNullOrWhiteSpace(category))
			{
				MessageBox.Show("Category cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Attempts to parse double from priceBox, if it fails it shows a mbox and returns, if it succeeds the
			// variable price will contain the price
			if (!double.TryParse(priceBox.Text, out double price))
			{
				MessageBox.Show("Price must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}			

			// Instantiates a product with the data collected from the form
			Product product = new Product
			{
				Title = title,
				Price = price,
				Category = category
			};

			// Adds product object to database
			ProductDb.Add(context, product);

			// Displays success message and clears textboxs
			MessageBox.Show("Product was added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			titleBox.Text = "";
			priceBox.Text = "";
			categoryBox.Text = "";
		}
	}
}
