using System;
using TheShop.Client.ShopServiceReference;
using TheShop.Model;

namespace TheShop.Client
{
	public class Program
	{
		static void Main(string[] args)
		{
			ShopServiceClient client = new ShopServiceClient();

			bool isOn = true;
			while (isOn)
			{
				Console.WriteLine("Welcome to The Shop. Here are our products:");
				foreach (var item in client.GetProducts())
				{
					Console.WriteLine(item.Id + ". " + item.Name);
				}

				Console.WriteLine("Press A to add, R to remove and U to update product.");

				switch (Console.ReadKey(true).Key)
				{
					case ConsoleKey.A:
						AddNewProduct(client);
						break;
					case ConsoleKey.R:
						RemoveProduct(client);
						break;
					case ConsoleKey.U:
						UpdateProduct(client);
						break;
					default:
						isOn = false;
						break;
				}
			}
		}

		private static void UpdateProduct(ShopServiceClient client)
		{
			Console.WriteLine("Write id number of id to remove product");
			int updatedId = int.Parse(Console.ReadLine());
			Console.WriteLine("Write new name of product");
			var updatedProduct = Console.ReadLine();
			client.UpdateProduct(new Product
			{
				Id = updatedId,
				Name = updatedProduct
			});
			Console.Clear();
		}

		private static void RemoveProduct(ShopServiceClient client)
		{
			Console.WriteLine("Write id number of id to remove product");
			int removeProduct = int.Parse(Console.ReadLine());
			client.RemoveProduct(removeProduct);
			Console.WriteLine("product removed.");
			Console.Clear();
		}

		private static void AddNewProduct(ShopServiceClient client)
		{
			Console.WriteLine("Write name of new product:");
			string newProduct = Console.ReadLine();
			client.AddProduct(new Product
			{
				Name = newProduct
			});
			Console.WriteLine("New product created.");
			Console.Clear();
		}
	}
}
