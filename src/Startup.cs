using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;

namespace WebApplication
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
