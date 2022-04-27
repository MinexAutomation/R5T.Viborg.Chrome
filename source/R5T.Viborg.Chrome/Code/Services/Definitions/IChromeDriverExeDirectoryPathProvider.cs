using System;

using R5T.T0064;


namespace R5T.Viborg.Chrome
{
    /// <summary>
    /// Provides the directory path containing the "chromedriver.exe" file.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IChromeDriverExeDirectoryPathProvider : IServiceDefinition
    {
        string GetChromeDriverExeDirectoryPath();
    }
}
