using System.Web.Http;
using Web.Models;

namespace Web.Controllers.API
{
	[RoutePrefix("api")]
	public class BugsController : ApiController
	{
		Product _product = new Product("Apple", 10);

		[HttpGet]
		[Route("bugs")]
		public Product Get()
		{
			return _product;
		}
	}
}