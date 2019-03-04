using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SWRPGCombatTracker
{
    public class Program
    {
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //  .UseElectron(args)
                .UseStartup<Startup>();

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
    }
}