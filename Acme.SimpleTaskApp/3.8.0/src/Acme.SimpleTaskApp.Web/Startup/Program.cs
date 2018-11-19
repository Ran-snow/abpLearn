using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Acme.SimpleTaskApp.Web.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://+:80")
                .Build();

            host.Run();
        }
    }
}
