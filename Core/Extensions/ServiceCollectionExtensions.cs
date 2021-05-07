using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, List<ICoreModule> modules)
        {
            foreach (var items in modules)
            {
                items.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);
        }

       
    }
}
