using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupECommerce
{
    static class ProductDb
    {
        public static List<Product> GetAllProducts()
        {
            using (var context = new ProductContext())
			{
                return context.Products.ToList<Product>();
			}
        }

        public static Product Add(Product p)
        {
            throw new NotImplementedException();
        }

        public static Product Update(Product p)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Product p)
        {
            throw new NotImplementedException();
        }
        
        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
