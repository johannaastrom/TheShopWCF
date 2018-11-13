﻿using System.Runtime.Serialization;

namespace TheShop.Client
{
	[DataContract]
	public class Product
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string Description { get; set; }
	}
}
