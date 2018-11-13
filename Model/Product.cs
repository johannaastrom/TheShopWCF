using System.Runtime.Serialization;

namespace TheShop.Model
{
	[DataContract]
	public class Product
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
	}
}
