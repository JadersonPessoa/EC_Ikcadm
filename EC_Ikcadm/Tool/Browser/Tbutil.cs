using EC_Ikcadm.Test.Map;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace EC_Ikcadm.Tool.Browser
{
    public class Tbutil
    {
        //Mouse houver
        public static void MouseOver(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var elemento = wait.Until(ExpectedConditions.ElementIsVisible(by));

            Actions action = new Actions(driver);
            action.MoveToElement(elemento).Click().Build().Perform();

            Thread.Sleep(1000);
        }

        //Radio Button 
        public static bool RadioButonSelecionado(IWebDriver driver, IWebElement elemento)
        {
            IList<IWebElement> lstElementos = elemento as IList<IWebElement>;

            var valor = false;
            valor = lstElementos[0].Selected;

            if (valor == true)
            {
                valor = true;
            }
            else
            {
                valor = false;
            }

            return valor;
        }

        //Click no chekcBox
        public static void ClickCheckBox(IWebDriver driver, IWebElement elemento, bool click)
        {
            IWebElement element = elemento;

            if (element.Selected && click == true)
            {
                //
            }
            else if (!elemento.Selected && click == true)
            {
                element.Click();
            }
            else if (elemento.Selected && click == false)
            {
                element.Click();
            }
            else if (!element.Selected && click == false)
            {
                //
            }
        }

        //Aguradar primeiro campo
        public static Boolean WaitForFirstExist(IWebDriver driver, IWebElement element, int timeOut)
        {
            bool obj = false;
            for (int i = 0; i < timeOut; i++)
            {
                IWebElement objElemnt = element;
                if (objElemnt.Enabled == true)
                {
                    obj = true;
                }
                Thread.Sleep(100);
            }

            return obj;
        }

    }
}