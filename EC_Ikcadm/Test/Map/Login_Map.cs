using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Ikcadm.Test.Map
{
    public class Login_Map
    {
        //Campo "Usuario"
        public static IWebElement TxtUsuario(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtUsuario"));
        }

        //Campo "Senha"
        public static IWebElement TxtSenha(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtSenha"));
        }

        //Boatão <Entrar>
        public static IWebElement BtnEntrar(IWebDriver driver)
        {
            return driver.FindElement(By.Id("btnEntrar"));
        }
    }
}