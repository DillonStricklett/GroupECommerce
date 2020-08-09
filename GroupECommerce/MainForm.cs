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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

		private void addProductBtn_Click(object sender, EventArgs e)
		{
            AddProduct secondForm = new AddProduct();
            secondForm.Show();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Product> allProducts = ProductDb.GetAllProducts();

            allProductsCbo.DataSource = allProducts;
            allProductsCbo.DisplayMember = nameof(Product.Title);
        }

		private void updateProductBtn_Click(object sender, EventArgs e)
		{
            UpdateProduct updateForm = new UpdateProduct((Product)allProductsCbo.SelectedItem);
            updateForm.ShowDialog();
		}
	}
}
