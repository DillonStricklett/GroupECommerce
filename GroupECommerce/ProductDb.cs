using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupECommerce
{
    static class ProductDb
    {

        /// <summary>
        /// Collects all products from database and returns them in a list
        /// </summary>
        public static List<Product> GetAllProducts()
        {
            using (var context = new ProductContext())
			{
                return context.Products.ToList<Product>();
			}
        }

        /// <summary>
        /// Adds a product to the database
        /// </summary>
        /// <param name="p">The product being added</param>
        public static Product Add(Product p)
        {
            using (var context = new ProductContext())
			{
                context.Products.Add(p);
                context.SaveChanges();
                return p;
			}
        }

        /// <summary>
        /// Updates the submitted product in the database
        /// </summary>
        /// <param name="p">The product to update</param>
        public static Product Update(Product p)
        {
            using (var context = new ProductContext())
			{
                context.Entry(p).State = EntityState.Modified;
                context.SaveChanges();
                return p;
			}
        }

        /// <summary>
        /// Deletes product from databse
        /// </summary>
        /// <param name="p">The product to be deleted</param>
        public static void Delete(Product p)
        {
            using (var context = new ProductContext())
			{
                context.Entry(p).State = EntityState.Deleted;
                context.SaveChanges();
			}
        }
        
        /// <summary>
        /// Deletes a product from the database
        /// </summary>
        /// <param name="id">The id of the product to delete</param>
        public static void Delete(int id)
        {
            using (var context = new ProductContext())
			{
                // Collects and marks product for deletion in one statement
                context.Entry(
                    context.Products
                           .Where(p => p.ProductId == id)
                           .Single())
                        .State = EntityState.Deleted;
                context.SaveChanges();
			}
        }
    }
}
