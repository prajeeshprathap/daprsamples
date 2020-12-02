﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Dapr.Samples.Calculator.Subtract
{
    public static class ServiceCollectionExtensions
    {
        internal static void ConfigureApiDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Calculator Operation - Subtraction",
                    Description = "Subtraction API",
                    TermsOfService = new Uri("https://www.prajeeshprathap.com"),
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Prajeesh Prathap",
                        Url = new Uri("https://www.prajeeshprathap.com"),
                    }
                });
            });
        }
    }
}
