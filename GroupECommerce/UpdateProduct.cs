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
	}
}
