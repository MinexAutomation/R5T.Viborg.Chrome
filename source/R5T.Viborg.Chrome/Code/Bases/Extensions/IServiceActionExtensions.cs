using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Viborg.Chrome
{
    public static class IServiceActionExtensions
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
        public static IServiceAction<IWebDriverProvider> AddChromeWebDriverProviderAction(this IServiceAction _,
            IServiceAction<IChromeDriverExeDirectoryPathProvider> chromeDriverExeDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IWebDriverProvider>(services => services.AddChromeWebDriverProvider(
                chromeDriverExeDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
