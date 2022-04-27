using System;

using Microsoft.Extensions.Configuration;

using R5T.T0064;


namespace R5T.Viborg.Chrome
{
    /// <summary>
    /// Gets the Chrome-driver executable file's directory path directly from the configuration.
    /// </summary>
    [ServiceImplementationMarker]
    public class DirectConfigurationBasedChromeDriverExeDirectoryPathProvider : IChromeDriverExeDirectoryPathProvider, IServiceImplementation
    {
        public const string ConfigurationPath = "ChromeDriver:DirectoryPath";


        private IConfiguration Configuration { get; }


        public DirectConfigurationBasedChromeDriverExeDirectoryPathProvider(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public string GetChromeDriverExeDirectoryPath()
        {
            var output = this.Configuration[DirectConfigurationBasedChromeDriverExeDirectoryPathProvider.ConfigurationPath];
            return output;
        }
    }
}
