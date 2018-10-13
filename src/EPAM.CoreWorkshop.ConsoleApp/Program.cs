using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace EPAM.CoreWorkshop.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new WebHostBuilder();
			builder.UseStartup<Startup>();
			builder.UseKestrel();
			builder.UseUrls("http://*:801");

			var host = builder.Build();

			host.Run();
		}
	}

	internal class Startup
	{
		public void Configure(IApplicationBuilder appBuilder)
		{
			appBuilder.Run((c) => {
				return c.Response.WriteAsync("Hello");
				
			});
		}
	}
}
