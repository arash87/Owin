using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using Nancy;
using Web.Models;
using HttpStatusCode = System.Net.HttpStatusCode;

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

		[HttpGet]
		[Route("loginUser")]
		public HttpResponseMessage Login()
		{
			var identity = new ClaimsIdentity("ApplicationCookie");
			identity.AddClaim(new Claim(ClaimTypes.Name, "arash"));
			Request.GetOwinContext().Authentication.SignIn(identity);
			return Request.CreateResponse(HttpStatusCode.OK);
		}

		[Authorize]
		[HttpGet]
		[Route("secret")]
		public Product Seceret()
		{
			return _product;
		}
	}
}