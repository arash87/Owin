using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using Nancy;

namespace Web.Modules
{
	public class NancyDemoModule : NancyModule
	{
		public NancyDemoModule()
		{
			Get["/"] = _ =>
			{
				return View["index"];
			};

			Get["/Auth/Login"] = _ =>
			{
				return View["login"];
			};
		}
	}
}