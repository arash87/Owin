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
		}
	}
}