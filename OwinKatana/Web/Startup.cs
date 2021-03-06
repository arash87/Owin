﻿using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.StaticFiles;
using Newtonsoft.Json.Serialization;
using Owin;

[assembly: OwinStartup(typeof(Web.Startup))]

namespace Web
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

			//Add CookieAuthentication
			app.UseCookieAuthentication(new CookieAuthenticationOptions()
			{
				AuthenticationType = "ApplicationCookie",
				ExpireTimeSpan = System.TimeSpan.FromSeconds(10)				
			});

			app.MapSignalR();

			//Add WebApi
			var config = new HttpConfiguration();
			config.MapHttpAttributeRoutes();
			var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
			config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
			config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
			app.UseWebApi(config);

			//Add Nancy
			app.UseNancy();

			//var physicalFileSystem = new PhysicalFileSystem(@"./Views");
			//var options = new FileServerOptions
			//{
			//	EnableDefaultFiles = true,
			//	FileSystem = physicalFileSystem
			//};

			//options.StaticFileOptions.FileSystem = physicalFileSystem;
			//options.StaticFileOptions.ServeUnknownFileTypes = true;
			//options.DefaultFilesOptions.DefaultFileNames = new[]
			//{
			//	"index.html"
			//};

			//app.UseFileServer(options);
		}
	}
}
