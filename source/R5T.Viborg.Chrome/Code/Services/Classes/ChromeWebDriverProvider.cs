using System;
using System.IO;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace R5T.Viborg.Chrome
{
    public class ChromeWebDriverProvider : IWebDriverProvider
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
