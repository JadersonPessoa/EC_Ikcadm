using OpenQA.Selenium;

namespace EC_Ikcadm.Test.Map
{
    public class BarraMenu_Map
    {
        //Menu >>Favoritos
        public static IWebElement HplFavoritos(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Favoritos"));
        }

        //Menu >>Pedidos
        public static IWebElement HplPedidos(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Pedidos"));
        }

        //Menu >>clientes
        public static IWebElement HplClientes(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Clientes"));
        }

        //Menu >>Catalogo
        public static IWebElement HplCatalogo(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Catálogo"));
        }

        //Menu >>Banner
        public static IWebElement HplBanners(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Banners"));
        }

        //Menu >>Frete/Entrega
        public static IWebElement HplFreteEntrega(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Frete / Entrega"));
        }

        //Menu >>Precos e Promocoes
        public static IWebElement HplPrecosPromocoes(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Preços e Promoções"));
        }

        //Menu >>Parceiros
        public static IWebElement HplParaceiros(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Parceiros"));
        }

        //Menu >>Listas
        public static IWebElement HplListas(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Listas"));
        }

        //Menu >>Relatorios
        public static IWebElement HplRelatorios(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Relatórios"));
        }

        //Menu >>Configurações
        public static IWebElement HplConfiguracoes(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Configurações"));
        }

        //Menu >>Suporte
        public static IWebElement HplSuporte(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Suporte"));
        }


        #region >>Look
        //Look
        public static IWebElement HplLook(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Look"));
        }

        //Look>>Consultar
        public static IWebElement HplLookConsulta(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("(//a[contains(text(),'Consulta')])[20]"));
        }

        //Look>>Inserir
        public static IWebElement HplLookInserir(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("(//a[contains(text(),'Inserir')])[15]"));
        }

        //Look>>Importar
        public static IWebElement HplLookImportar(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("(//a[contains(text(),'Importar')])[3]"));
        }

        //Look>>Filtros
        public static IWebElement HplLookFiltros(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Filtros"));
        }
        #endregion
    }
}