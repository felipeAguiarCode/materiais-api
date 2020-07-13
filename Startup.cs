using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using webAppMaterialControl.Api.Data;
using webAppMaterialControl.Api.Repositories;

namespace webAppMaterialControl
{
  public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();   
            services.AddCors();

            services.AddScoped<MaterialContext, MaterialContext>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors(option => 
                        option.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader()      
                       );
            app.UseMvc();

        }
    }
}
