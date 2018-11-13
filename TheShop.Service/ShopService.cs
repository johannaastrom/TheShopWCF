using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using TheShop.Client;
using TheShop.Model;

namespace TheShop.Service
{
	public class ShopService : IShopService
	{
		readonly ProductDbContext _context = new ProductDbContext();

		public void AddProduct(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
		}

		public List<Product> GetProducts()
		{
			return _context.Products.ToList();
		}

		public void RemoveProduct(int id)
		{
			Product product = new Product() { Id = id };
			_context.Products.Attach(product);
			_context.Products.Remove(product);
			_context.SaveChanges();
		}

		[OperationBehavior(TransactionScopeRequired = true)]
		public void UpdateProduct(Product product)
		{
			_context.Entry(product).State = EntityState.Modified;
			_context.SaveChanges();
		}
	}
}
