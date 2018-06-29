using EC_Ikcadm.Test.Dao;
using EC_Ikcadm.Test.Fun;
using EC_Ikcadm.Tool.Browser;
using EC_Ikcadm.Tool.Systen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

namespace EC_Ikcadm.Test.Run
{
    [TestClass]
    public class CenariosDeTestes
    {
        //Properties DataRow
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        //Properties Webdriver
        private IWebDriver _browser;
        public IWebDriver browser
        {
            get { return _browser; }
            set { _browser = value; }
        }


        //Look
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                        "|DataDirectory|\\MassaDados\\MassaDados.xml",
                         "IK_Look", DataAccessMethod.Sequential)]
        [Timeout(TestTimeout.Infinite)]
        [DeploymentItem(@"MassaDados")]
        [TestMethod]
        public void TestMethod2000_Look()
        {
            try
            {
                //Abrir o browser
                browser = Tbbrowser.OpenBrowser(browser);

                //Logar no sistema
                var login = Login_Fun.Login(browser);

                //Inicializa objeto testes
                var objTest = new Look_Fun();

                //Inicializa objeto dados
                var objDados = new Look_Dao();
                objDados = objTest.PreencherDados(TestContext);

                //Valida Ur e title da pagina
                var objTitle = Tbwait.Title(browser, "ECService | pense e-commerce", By.Id("ctl00_Cabecalho_btnSair"));
                var objUrl = Tbwait.Url(browser, "IKCADM");

                if (objTitle == true && objUrl == true)
                {
                    Menu_Fun.Look(browser, objDados.MenuOpcao);
                    Tbwait.Playback(browser, 5);
                }

                //Inicializa o teste
                objTest.GerenciarLook(objDados, browser);

                //Tempo para o proximo teste
                Thread.Sleep(3000);

            }
            catch (Exception ex)
            {
                Assert.IsFalse(true, "Report Category button element is not found.");
                Tbreport.GetScreenShot(browser, "Error Webdriver");
                throw ex;
            }
        }
    }
}