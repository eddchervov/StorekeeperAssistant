﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace StorekeeperAssistant.BL
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomBLServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IProductService, ProductService>();

        }
    }
}