using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace EC_Ikcadm.Tool.Browser
{
    public class Tbwait
    {
        //Aguardar elemento visivel na tela
        public static Boolean Displayed(IWebDriver driver, IWebElement element, int timeoutInSeconds)
        {
            bool elementDisplayed = false;

            for (int i = 0; i < timeoutInSeconds; i++)
            {
                try
                {
                    if (timeoutInSeconds > 0)
                    {
                        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                        wait.Until(drv => element);
                    }
                    elementDisplayed = element.Displayed;
                }
                catch
                { }
            }
            return elementDisplayed;

        }

        //Aguardar titulo da url 
        public static Boolean Title(IWebDriver driver, string title, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) =>
            {
                Console.WriteLine(Web.FindElement(by).GetAttribute("innerHTML"));
                return true;
            });

            var obj = wait.Until(waitForElement);

            if (driver.Title == title)
            {
                obj = true;
            }

            return obj;
        }

        //Aguardar url existir
        public static Boolean Url(IWebDriver driver, string title)
        {
            var obj = false;

            if (driver.Url.Contains(title))
            {
                obj = true;
            }
            Thread.Sleep(500);

            return obj;
        }

        //Timeout Iwebdriver
        public static TimeSpan Playback(IWebDriver driver, int timeoutSeconds)
        {
            var searchTimeout = driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeoutSeconds);
            return searchTimeout;
        }
    }
}