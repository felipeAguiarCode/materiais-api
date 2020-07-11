﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using webAppMaterialControl.Api.Data;
using webAppMaterialControl.Api.Models;
using webAppMaterialControl.Api.Repositories;

namespace webAppMaterialControl
{
  public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();   
            //dependency injections
            services.AddScoped<MaterialContext, MaterialContext>();
            //services.AddTransient<MaterialRepository, MaterialRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseMvc();

        }
    }
}
