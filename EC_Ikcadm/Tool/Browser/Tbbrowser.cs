using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace EC_Ikcadm.Tool.Browser
{
    public class Tbbrowser
    {
        public static IWebDriver OpenBrowser(IWebDriver driver)
        {
            string pathWebdriver = ConfigurationManager.AppSettings.GetValues("SP_WebDrivers")[0];
            string nameBrowser = ConfigurationManager.AppSettings.GetValues("SA_Browser")[0];
            string url = ConfigurationManager.AppSettings.GetValues("SA_Url")[0];
            string pathLocalBrowser = string.Empty;

            if (driver == null)
            {
                switch (nameBrowser)
                {
                    case "internet Explorer":

                        InternetExplorerDriverService serviceIE = InternetExplorerDriverService.CreateDefaultService(pathWebdriver, "IEDriverServer.exe");

                        driver = new InternetExplorerDriver(serviceIE);
                        break;

                    case "internet Edge":

                        EdgeDriverService serviceEdge = EdgeDriverService.CreateDefaultService(pathWebdriver, "MicrosoftWebDriver.exe");
                        driver = new EdgeDriver(serviceEdge);
                        break;

                    case "firefox":

                        if (File.Exists(@"C:\Program Files\Mozilla Firefox\firefox.exe"))
                        {
                            pathLocalBrowser = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                        }
                        else
                        {
                            pathLocalBrowser = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
                        }

                        FirefoxDriverService serviceFireFox = FirefoxDriverService.CreateDefaultService(pathWebdriver);
                        serviceFireFox.FirefoxBinaryPath = pathLocalBrowser;
                        driver = new FirefoxDriver(serviceFireFox);
                        break;

                    case "chrome":

                        ChromeDriverService serviceChrome = ChromeDriverService.CreateDefaultService(pathWebdriver, "chromedriver.exe");
                        driver = new ChromeDriver(serviceChrome);
                        break;
                }
            }

            return driver;
        }
    }
}