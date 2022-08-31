using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Product.Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Product.Core.DependencyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<Stopwatch>();
        }
    }
}
