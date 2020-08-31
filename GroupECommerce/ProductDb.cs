using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
        public static async Task<List<Product>> GetAllProducts(IProductContext context)
        {
                return await context.Products.ToListAsync();
        }

        /// <summary>
        /// Adds a product to the database
        /// </summary>
        /// <param name="p">The product being added</param>
        public static async Task<Product> Add(IProductContext context, Product p)
        {
                context.Products.Add(p);
                await context.SaveChangesAsync();
                return p;
        }

        /// <summary>
        /// Updates the submitted product in the database
        /// </summary>
        /// <param name="p">The product to update</param>
        public static async Task<Product> Update(IProductContext context, Product p)
        {
                context.Entry(p).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return p;
        }

        /// <summary>
        /// Deletes product from databse
        /// </summary>
        /// <param name="p">The product to be deleted</param>
        public static async Task Delete(IProductContext context, Product p)
        {
                context.Entry(p).State = EntityState.Deleted;
                await context.SaveChangesAsync();
        }
        
        /// <summary>
        /// Deletes a product from the database
        /// </summary>
        /// <param name="id">The id of the product to delete</param>
        public static async Task Delete(IProductContext context, int id)
        {
                // Collects and marks product for deletion in one statement
                context.Entry(
                    context.Products
                           .Where(p => p.ProductId == id)
                           .Single())
                        .State = EntityState.Deleted;
                await context.SaveChangesAsync();
        }
    }
}
