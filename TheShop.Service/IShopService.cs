using System.Collections.Generic;
using System.ServiceModel;
using TheShop.Model;

namespace TheShop.Service
{
	[ServiceContract]
	public interface IShopService
	{
		[OperationContract]
		List<Product> GetProducts();

		[OperationContract]
		void AddProduct(Product product);

		[OperationContract]
		void RemoveProduct(int id);

		[OperationContract]
		void UpdateProduct(Product product);
	}
}
