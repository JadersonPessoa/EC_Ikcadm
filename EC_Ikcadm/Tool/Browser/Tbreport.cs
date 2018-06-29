using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace EC_Ikcadm.Tool.Browser
{
    public class Tbreport
    {
        //Captura de imagens 
        public static void GetScreenShot(IWebDriver driver, string nameFunc)
        {
            var path = Directory.GetCurrentDirectory();
            var pathData = path.Substring(0, path.LastIndexOf("TestResults")) + @"TestResults\Screenshot\" + DateTime.Now.ToString("dd_MM_yyyy") + "\\" + nameFunc;

            if (!Directory.Exists(pathData))
            {
                Directory.CreateDirectory(pathData);
            }

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(pathData + "\\" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".jpg", ScreenshotImageFormat.Png);
            Thread.Sleep(1000);
        }
    }
}