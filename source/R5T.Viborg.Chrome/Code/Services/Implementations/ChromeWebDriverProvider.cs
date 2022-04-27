using System;
using System.IO;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using R5T.T0064;


namespace R5T.Viborg.Chrome
{
    [ServiceImplementationMarker]
    public class ChromeWebDriverProvider : IWebDriverProvider, IServiceImplementation
    {
        private IChromeDriverExeDirectoryPathProvider ChromeDriverExeDirectoryPathProvider { get; }


        public ChromeWebDriverProvider(IChromeDriverExeDirectoryPathProvider chromeDriverExeDirectoryPathProvider)
        {
            this.ChromeDriverExeDirectoryPathProvider = chromeDriverExeDirectoryPathProvider;
        }

        public IWebDriver GetWebDriver()
        {
            var chromeDriverDirectory = this.ChromeDriverExeDirectoryPathProvider.GetChromeDriverExeDirectoryPath();

            var driver = new ChromeDriver(chromeDriverDirectory);
            return driver;
        }
    }
}
