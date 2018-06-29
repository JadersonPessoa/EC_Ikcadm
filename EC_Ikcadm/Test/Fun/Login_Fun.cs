using EC_Ikcadm.Test.Dao;
using EC_Ikcadm.Test.Map;
using EC_Ikcadm.Tool.Browser;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace EC_Ikcadm.Test.Fun
{
    public class Login_Fun
    {
        public static bool Login(IWebDriver driver)
        {
            bool obj = false;

            try
            {
                //Carregar o Browser
                var url = ConfigurationManager.AppSettings.GetValues("SA_Url")[0];
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                //Loga no sistema
                var user = Login_Dao.Usuario;
                var pass = Login_Dao.Senha;

                if (!string.IsNullOrEmpty(user))
                {
                    Login_Map.TxtUsuario(driver).Clear();
                    Login_Map.TxtUsuario(driver).SendKeys(user);
                }

                if (!string.IsNullOrEmpty(pass))
                {
                    Login_Map.TxtSenha(driver).Clear();
                    Login_Map.TxtSenha(driver).SendKeys(pass);
                }

                Login_Map.BtnEntrar(driver).Click();

                var wait = Tbwait.Displayed(driver, driver.FindElement(By.LinkText("Sair")), 10);

                obj = true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return obj;
        }
    }
}