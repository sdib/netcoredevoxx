using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace netcorelive
{
    public class Startup 
    {   
        public void Configure(IApplicationBuilder app) 
        {
            app.Run(context => context.Response.WriteAsync("Hello Devoxx !"));
        }
    }
}