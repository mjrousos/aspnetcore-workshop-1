using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:8081")
                .Build();
    }
}
