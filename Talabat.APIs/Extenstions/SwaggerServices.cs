﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Talabat.APIs.Extenstions
{
    public static class SwaggerServices
    {
        public static IServiceCollection AddSwaggerServices (this IServiceCollection services) 
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Talabat.APIs",
                    Version = "v1",
                    Description = "My first apis"
                }) ;
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerDocument(this IApplicationBuilder app) 
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Talabat.APIs v1"));
             
            return app;
        }
        
    }
}
