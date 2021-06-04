using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebApplication4.Areas.Identity.IdentityHostingStartup))]
namespace WebApplication4.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}