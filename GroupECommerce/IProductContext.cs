using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupECommerce
{
	public interface IProductContext
	{
		DbSet<Product> Products{ get; set; }
		int SaveChanges();
		Task<int> SaveChangesAsync();
		DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
	}
}
