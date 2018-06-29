using EC_Ikcadm.Test.Dao;
using EC_Ikcadm.Test.Map;
using EC_Ikcadm.Tool.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Ikcadm.Test.Fun
{
    public class Menu_Fun
    {
        public static void Look(IWebDriver driver, string menuOpcao)
        {
            switch (menuOpcao)
            {
                case "Consulta":
                    //Menu Principal
                    Tbutil.MouseOver(driver, By.LinkText("CATÁLOGO"));

                    //Menu Secundario
                    Tbutil.MouseOver(driver, By.LinkText("LOOK"));

                    //Opção do Menu Secundario
                    BarraMenu_Map.HplLookConsulta(driver).Click();
                    break;

                case "Inserir":
                    //Menu Principal
                    Tbutil.MouseOver(driver, By.LinkText("CATÁLOGO"));

                    //Menu Secundario
                    Tbutil.MouseOver(driver, By.LinkText("LOOK"));

                    //Opção do Menu Secundario
                    BarraMenu_Map.HplLookInserir(driver).Click();
                    break;

                case "Importar":
                    //Menu Principal
                    Tbutil.MouseOver(driver, By.LinkText("CATÁLOGO"));

                    //Menu Secundario
                    Tbutil.MouseOver(driver, By.LinkText("LOOK"));

                    //Opção do Menu Secundario
                    BarraMenu_Map.HplLookImportar(driver).Click();
                    break;

                case "Filtro":
                    //Menu Principal
                    Tbutil.MouseOver(driver, By.LinkText("CATÁLOGO"));

                    //Menu Secundario
                    Tbutil.MouseOver(driver, By.LinkText("LOOK"));

                    //Opção do Menu Secundario
                    BarraMenu_Map.HplLookFiltros(driver).Click();
                    break;
            }


        }
    }
}