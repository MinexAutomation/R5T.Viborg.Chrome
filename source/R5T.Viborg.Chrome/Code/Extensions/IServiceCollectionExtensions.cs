using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.Viborg.Chrome
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DirectConfigurationBasedChromeDriverExeDirectoryPathProvider"/> implementation of <see cref="IChromeDriverExeDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDirectConfigurationBasedChromeDriverExeDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction)
        {
            services
                .Run(configurationAction)
                .AddSingleton<IChromeDriverExeDirectoryPathProvider, DirectConfigurationBasedChromeDriverExeDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ChromeWebDriverProvider"/> implementation of <see cref="IWebDriverProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddChromeWebDriverProvider(this IServiceCollection services,
            IServiceAction<IChromeDriverExeDirectoryPathProvider> chromeDriverExeDirectoryPathProviderAction)
        {
            services
                .Run(chromeDriverExeDirectoryPathProviderAction)
                .AddSingleton<IWebDriverProvider, ChromeWebDriverProvider>();

            return services;
        }
    }
}
