using System;
using System.Collections.Generic;
using System.Text;
using Stock.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Stock.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services,
            ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
               module.Load(services); 
            }

            return ServiceTool.Create(services);
        }
    }
}
