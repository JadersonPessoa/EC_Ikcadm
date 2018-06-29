using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Ikcadm.Test.Map
{
    public class Look_Map
    {
        #region Consulta Look

        public static IWebElement TxtSearchNomeLook(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtNomeLook"));
        }

        public static IWebElement TxtSearchCodigoInternoLook(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtCodigoInternoLook"));
        }

        public static IWebElement TxtSearchCodigoInternoProduto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtCodigoInternoProduto"));
        }

        public static IWebElement RdoSearchStatusTodos(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_rbTodos"));
        }

        public static IWebElement RdoSearcStatusAtivo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_rbAtivo"));
        }

        public static IWebElement RdoSearchStatusInativo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_rbInativo"));
        }

        public static IWebElement BtnSearchPsesquisar(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_btnPesquisar"));
        }

        public static IWebElement BtnSearchInserir(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_btnInserir"));
        }

        public static IWebElement CkbSearchItem(IWebDriver driver)
        {
            return driver.FindElement(By.Name("chkItem"));
        }

        public static IWebElement BtnSearchEditarItem(IWebDriver driver)
        {
            return driver.FindElement(By.Name("ctl00_ContentPlaceHolder2_rpLooks_ctl00_imgEditar"));
        }

        public static IWebElement BtnSearchExcluirItem(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//img[@alt='Excluir']"));
        }
        #endregion

        #region Inserir

        public static IWebElement TxtInserirNome(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtName"));
        }

        public static IWebElement TxtInserirCodigoInterno(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtInternalId"));
        }

        public static IWebElement TxtInserirCodigoYoutube(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtYoutubeId"));
        }

        public static IWebElement RdotInserirStatusAtivo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("rdoActive"));
        }

        public static IWebElement RdotInserirStatusInativo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("rdoInactive"));
        }

        public static IWebElement TxtinserirDesconto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtDiscount"));
        }

        public static IWebElement TxtinserirPorcentagem(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtPercentage"));
        }

        public static IWebElement TxtInserirSelecioneFabricante(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtBrand"));
        }

        public static IWebElement HplInserirNovoFabricante(IWebDriver driver)
        {
            return driver.FindElement(By.Id("hypNewBrand"));
        }

        public static IWebElement TxtInserirFabricanteCodigoInterno(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtCI"));
        }


        public static IWebElement TxtInserirFabricanteNome(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtNome"));
        }

        public static SelectElement SelectInserirFabricanteMenu(IWebDriver driver)
        {
            return new SelectElement(driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_ddlMenu")));
        }

        public static IWebElement BtnInserirFabricanteInserirFabricante(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_btnInserir"));
        }

        public static IWebElement BtnInserirFabricanteClose(IWebDriver driver)
        {
            return driver.FindElement(By.Id("fancybox-close"));
        }

        public static IWebElement TxtInserirDataLancamento(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtReleaseDate"));
        }

        public static IWebElement CkbInserirCompraCompleta(IWebDriver driver)
        {
            return driver.FindElement(By.Id("chkCompleteBuy"));
        }

        public static IWebElement CkbInserirClientePodeAlterarQuantidadeitens(IWebDriver driver)
        {
            return driver.FindElement(By.Id("chkCustomerChoosesQuantity"));
        }

        public static IWebElement CkbInserirSkuEmGrade(IWebDriver driver)
        {
            return driver.FindElement(By.Id("chkSkuGrid"));
        }

        public static IWebElement txtInserirSelecioneCategoria(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtNameCategory"));
        }

        public static IWebElement HplInserirNovaCategoria(IWebDriver driver)
        {
            return driver.FindElement(By.Id("hypNewCategory"));
        }

        public static IWebElement BtnInserirPesquisarCategoria(IWebDriver driver)
        {
            return driver.FindElement(By.Id("btnSearchCategory"));
        }

        public static IWebElement TxtInserirCategoriaNome(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtNome"));
        }

        public static IWebElement TxtInserirCategoriaCodigoInterno(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtCodInterno"));
        }

        public static IWebElement TxtInserirCategoriaPai(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtCategoriaPai"));
        }

        public static SelectElement SelectInserirCategoriaMenu(IWebDriver driver)
        {
            return new SelectElement(driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtCategoriaPai")));
        }

        public static IWebElement RdoInserirCategoriaStatusAtivo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_rdoStatusAtivo"));
        }

        public static IWebElement RdoInserirCategoriaStatusInativo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_rdoStatusInativo"));
        }

        public static IWebElement BtnInserirCategoriaStatusInativo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_btnInserir"));
        }

        public static IWebElement BtnInserirCategoriaClose(IWebDriver driver)
        {
            return driver.FindElement(By.Id("fancybox-close"));
        }

        public static IWebElement ChbInserirResultadoPesquisaCategoria(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_rptCategories_ctl00_chkCategory"));
        }

        public static IWebElement BtnInserirAdicionarCategoria(IWebDriver driver)
        {
            return driver.FindElement(By.Id("btnAddCategory"));
        }

        public static IWebElement TxtInserirDescricao(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtDescription"));
        }

        public static IWebElement TxtInserirLongPage(IWebDriver driver)
        {
            return driver.FindElement(By.Id("txtLongPage"));
        }

        public static IWebElement TxtInserirFiltroOcasiao(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtFiltro_1"));
        }

        public static IWebElement TxtInserirFiltroEstilo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtFiltro_2"));
        }

        public static IWebElement TxtInserirFiltroTendencia(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_txtFiltro_3"));
        }

        public static IWebElement BtnInserirFiltroOcasiao(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_bt_adicionar_filtro_1"));
        }

        public static IWebElement BtnInserirFiltroEstilo(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_bt_adicionar_filtro_2"));
        }

        public static IWebElement BtnInserirFiltroTendencia(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_bt_adicionar_filtro_3"));
        }

        public static IWebElement TxtInserirNomeProduto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_productsLook_txtNomeBusca"));
        }

        public static IWebElement TxtInserirCodigoInternoProduto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_productsLook_txtCodigoInternoBusca"));
        }

        public static IWebElement BtnInserirProduto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_productsLook_txtCodigoInternoBusca"));
        }

        public static IWebElement RdoInserirResultadoProduto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_productsLook_rpProdutosBusca_ctl00_rdoProdutoBusca"));
        }

        public static IWebElement ChbInserirSkuProduto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_productsLook_chkProdutoSelecionado"));
        }

        public static IWebElement ChbInserirQuantidadeProduto(IWebDriver driver)
        {
            return driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_productsLook_rpProdutosLook_ctl00_txtQuantity"));
        }

        public static SelectElement SelectInserirPosicaoProduto(IWebDriver driver)
        {
            return new SelectElement(driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_productsLook_rpProdutosLook_ctl00_ddlOrder")));
        }

        public static IWebElement BtnInserirSalvar(IWebDriver driver)
        {
            return driver.FindElement(By.Id("btnSave"));
        }

        #endregion
    }
}