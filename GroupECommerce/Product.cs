using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupECommerce
{
    /// <summary>
    /// A single product EX: lamp, hat
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The ID number of the product
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// The display name of the product
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The retail price in USD of the product
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The category the product description falls under
        /// EX: Electronics, Furniture, Misc
        /// </summary>
        public string Category { get; set; }
    }
}
