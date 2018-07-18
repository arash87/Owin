namespace Web.Models
{
	public class Product
	{
		public Product(string name, int price)
		{
			this.Name = name;
			this.Price = price;
		}
		public string Name { get; set; }
		public int Price { get; set; }
	}
}