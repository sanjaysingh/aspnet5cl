using Microsoft.AspNet.Builder;

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
