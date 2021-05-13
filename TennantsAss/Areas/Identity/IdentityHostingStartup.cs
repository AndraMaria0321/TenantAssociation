using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BookingSite.Areas.Identity.IdentityHostingStartup))]
namespace BookingSite.Areas.Identity
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