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
            secondForm.FormClosed += SecondForm_FormClosed;
            secondForm.Show();

		}

        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            populateProductComboBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            populateProductComboBox();
        }

        private void populateProductComboBox()
        {
            List<Product> allProducts = ProductDb.GetAllProducts();

            allProductsCbo.DataSource = allProducts;
            allProductsCbo.DisplayMember = nameof(Product.Title);
        }

		private void updateProductBtn_Click(object sender, EventArgs e)
		{
            UpdateProduct updateForm = new UpdateProduct((Product)allProductsCbo.SelectedItem);
            updateForm.ShowDialog();

            populateProductComboBox();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            Product currProduct = allProductsCbo.SelectedItem as Product;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {currProduct.Title} for ${currProduct.Price} from the database?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                ProductDb.Delete(currProduct);
                populateProductComboBox();
            }
        }
    }
}
