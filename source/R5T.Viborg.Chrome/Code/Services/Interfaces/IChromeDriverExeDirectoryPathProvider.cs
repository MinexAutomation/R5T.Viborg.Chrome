using System;


namespace R5T.Viborg.Chrome
{
    /// <summary>
    /// Provides the directory path containing the "chromedriver.exe" file.
    /// </summary>
    public interface IChromeDriverExeDirectoryPathProvider
    {
        string GetChromeDriverExeDirectoryPath();
    }
}
