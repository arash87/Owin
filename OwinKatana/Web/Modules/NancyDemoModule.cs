using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using Nancy;

namespace Web.Modules
{
	public class NancyDemoModule : NancyModule
	{
		dynamic IndexPage() { return View["index"]; }
		public NancyDemoModule()
		{
			Get["/"] = _ => { return IndexPage(); };
			Get["/(.*)"] = _ => { return IndexPage(); };
			Get["/(.*)/(.*)"] = _ => { return IndexPage(); };
			Get["/(.*)/(.*)/(.*)"] = _ => { return IndexPage(); };

			//Get["/Auth/Login"] = _ =>
			//{
			//	return View["login"];
			//};
		}
	}
}