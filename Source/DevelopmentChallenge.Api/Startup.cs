using DevelopmentChallenge.Service.Interface;
using DevelopmentChallenge.Service.Services;

namespace DevelopmentChallenge.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IFormasGeometricasService, FormasGeometricasService>();
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            // Other app configurations...
        }
    }
}