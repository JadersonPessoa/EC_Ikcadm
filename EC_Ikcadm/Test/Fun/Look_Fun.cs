using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EC_Ikcadm.Test.Dao;
using EC_Ikcadm.Test.Map;
using EC_Ikcadm.Tool.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace EC_Ikcadm.Test.Fun
{
    public class Look_Fun
    {
        public Look_Dao PreencherDados(TestContext objDados)
        {
            var objLook = new Look_Dao();

            //ID_Teste
            if (objDados.DataRow["ID_Teste"] != DBNull.Value)
                objLook.ID_Teste = Convert.ToInt16(objDados.DataRow["ID_Teste"].ToString());

            //Descricao_CasoTeste
            if (objDados.DataRow["Descricao_CasoTeste"] != DBNull.Value)
                objLook.Descricao_CasoTeste = objDados.DataRow["Descricao_CasoTeste"].ToString();

            //Operacao
            if (objDados.DataRow["Operacao"] != DBNull.Value)
                objLook.Operacao = objDados.DataRow["Operacao"].ToString();

            //TestCaseID
            if (objDados.DataRow["TestCaseID"] != DBNull.Value)
                objLook.TestCaseID = Convert.ToInt16(objDados.DataRow["TestCaseID"].ToString());

            //MenuOpcao
            if (objDados.DataRow["MenuOpcao"] != DBNull.Value)
                objLook.MenuOpcao = objDados.DataRow["MenuOpcao"].ToString();

            //SearchNomeLook
            if (objDados.DataRow["SearchNomeLook"] != DBNull.Value)
                objLook.SearchNomeLook = objDados.DataRow["SearchNomeLook"].ToString();

            //SearchCodigoInternoLook
            if (objDados.DataRow["SearchCodigoInternoLook"] != DBNull.Value)
                objLook.SearchCodigoInternoLook = objDados.DataRow["SearchCodigoInternoLook"].ToString();

            //SearchCodigoInternoProduto
            if (objDados.DataRow["SearchCodigoInternoProduto"] != DBNull.Value)
                objLook.SearchCodigoInternoProduto = objDados.DataRow["SearchCodigoInternoProduto"].ToString();

            //SearchStatus
            if (objDados.DataRow["SearchStatus"] != DBNull.Value)
                objLook.SearchStatus = objDados.DataRow["SearchStatus"].ToString();

            //InserirNome
            if (objDados.DataRow["InserirNome"] != DBNull.Value)
                objLook.InserirNome = objDados.DataRow["InserirNome"].ToString();

            //InserirCodigoInterno
            if (objDados.DataRow["InserirCodigoInterno"] != DBNull.Value)

                objLook.InserirCodigoInterno = objDados.DataRow["InserirCodigoInterno"].ToString();
            //InserirCodigoYoutube
            if (objDados.DataRow["InserirCodigoYoutube"] != DBNull.Value)
                objLook.InserirCodigoYoutube = objDados.DataRow["InserirCodigoYoutube"].ToString();

            //InserirStatus
            if (objDados.DataRow["InserirStatus"] != DBNull.Value)
                objLook.InserirStatus = objDados.DataRow["InserirStatus"].ToString();

            //InserirDesconto
            if (objDados.DataRow["InserirDesconto"] != DBNull.Value)
                objLook.InserirDesconto = Convert.ToInt16(objDados.DataRow["InserirDesconto"].ToString());

            //InserirPorcentagem
            if (objDados.DataRow["InserirPorcentagem"] != DBNull.Value)
                objLook.InserirPorcentagem = Convert.ToInt16(objDados.DataRow["InserirPorcentagem"].ToString());

            //InserirFabricante
            if (objDados.DataRow["InserirFabricante"] != DBNull.Value)
                objLook.InserirFabricante = objDados.DataRow["InserirFabricante"].ToString();

            //InserirNovoFabricante
            if (objDados.DataRow["InserirNovoFabricante"] != DBNull.Value)
                objLook.InserirNovoFabricante = Convert.ToBoolean(objDados.DataRow["InserirNovoFabricante"].ToString());

            //NovoFabricanteCodigoInterno
            if (objDados.DataRow["NovoFabricanteCodigoInterno"] != DBNull.Value)
                objLook.NovoFabricanteCodigoInterno = objDados.DataRow["NovoFabricanteCodigoInterno"].ToString();

            //NovoFabricanteNome
            if (objDados.DataRow["NovoFabricanteNome"] != DBNull.Value)
                objLook.NovoFabricanteNome = objDados.DataRow["NovoFabricanteNome"].ToString();

            //NovoFabricanteMenu
            if (objDados.DataRow["NovoFabricanteMenu"] != DBNull.Value)
                objLook.NovoFabricanteMenu = objDados.DataRow["NovoFabricanteMenu"].ToString();

            //InserirDataLancamento
            if (objDados.DataRow["InserirDataLancamento"] != DBNull.Value)
                objLook.InserirDataLancamento = objDados.DataRow["InserirDataLancamento"].ToString();

            //InserirCompraCompleta
            if (objDados.DataRow["InserirCompraCompleta"] != DBNull.Value)
                objLook.InserirCompraCompleta = Convert.ToBoolean(objDados.DataRow["InserirCompraCompleta"].ToString());

            //InserirCompraCompletaClientePodeAlterarQuantidadeItens
            if (objDados.DataRow["InserirCompraCompletaClientePodeAlterarQuantidadeItens"] != DBNull.Value)
                objLook.InserirCompraCompletaClientePodeAlterarQuantidadeItens = Convert.ToBoolean(objDados.DataRow["InserirCompraCompletaClientePodeAlterarQuantidadeItens"].ToString());

            //InserirCompraCompletaSkuEmGrade
            if (objDados.DataRow["InserirCompraCompletaSkuEmGrade"] != DBNull.Value)
                objLook.InserirCompraCompletaSkuEmGrade = Convert.ToBoolean(objDados.DataRow["InserirCompraCompletaSkuEmGrade"].ToString());

            //InserirCategorias
            if (objDados.DataRow["InserirCategorias"] != DBNull.Value)
                objLook.InserirCategorias = objDados.DataRow["InserirCategorias"].ToString();

            //InserirNovaCategoria
            if (objDados.DataRow["InserirNovaCategoria"] != DBNull.Value)
                objLook.InserirNovaCategoria = Convert.ToBoolean(objDados.DataRow["InserirNovaCategoria"].ToString());

            //NovaCategoriaNome
            if (objDados.DataRow["NovaCategoriaNome"] != DBNull.Value)
                objLook.NovaCategoriaNome = objDados.DataRow["NovaCategoriaNome"].ToString();

            //NovaCategoriaCodigoInterno
            if (objDados.DataRow["NovaCategoriaCodigoInterno"] != DBNull.Value)
                objLook.NovaCategoriaCodigoInterno = objDados.DataRow["NovaCategoriaCodigoInterno"].ToString();

            //NovaCategoriaPai
            if (objDados.DataRow["NovaCategoriaPai"] != DBNull.Value)
                objLook.NovaCategoriaPai = objDados.DataRow["NovaCategoriaPai"].ToString();

            //NovaCategoriaMenu
            if (objDados.DataRow["NovaCategoriaMenu"] != DBNull.Value)
                objLook.NovaCategoriaMenu = objDados.DataRow["NovaCategoriaMenu"].ToString();

            //NovaCategoriaStatus
            if (objDados.DataRow["NovaCategoriaStatus"] != DBNull.Value)
                objLook.NovaCategoriaStatus = objDados.DataRow["NovaCategoriaStatus"].ToString();

            //InserirDescricao
            if (objDados.DataRow["InserirDescricao"] != DBNull.Value)
                objLook.InserirDescricao = objDados.DataRow["InserirDescricao"].ToString();

            //InserirLongPage
            if (objDados.DataRow["InserirLongPage"] != DBNull.Value)
                objLook.InserirLongPage = objDados.DataRow["InserirLongPage"].ToString();

            //InserirOcasiao
            if (objDados.DataRow["InserirOcasiao"] != DBNull.Value)
                objLook.InserirOcasiao = objDados.DataRow["InserirOcasiao"].ToString();

            //Inserirestilo
            if (objDados.DataRow["InserirEstilo"] != DBNull.Value)
                objLook.InserirEstilo = objDados.DataRow["Inserirestilo"].ToString();

            //InserirTendencia
            if (objDados.DataRow["InserirTendencia"] != DBNull.Value)
                objLook.InserirTendencia = objDados.DataRow["InserirTendencia"].ToString();

            //InserirNomeProduto
            if (objDados.DataRow["InserirNomeProduto"] != DBNull.Value)
                objLook.InserirNomeProduto = objDados.DataRow["InserirNomeProduto"].ToString();

            //InserirCodigoInternoProduto
            if (objDados.DataRow["InserirCodigoInternoProduto"] != DBNull.Value)
                objLook.InserirCodigoInternoProduto = objDados.DataRow["InserirCodigoInternoProduto"].ToString();

            //InserrirQuantidadeProdutoSkuSelecionado
            if (objDados.DataRow["InserrirQuantidadeProdutoSkuSelecionado"] != DBNull.Value)
                objLook.InserrirQuantidadeProdutoSkuSelecionado = Convert.ToInt16(objDados.DataRow["InserrirQuantidadeProdutoSkuSelecionado"].ToString());

            return objLook;
        }

        public void GerenciarLook(Look_Dao objDados, IWebDriver driver)
        {
            StackFrame sf = new StackFrame();
            var method = sf.GetMethod().Name;

            switch (objDados.Operacao)
            {
                case "C":
                    //Consulta look
                    ConsultaLook(driver, objDados);
                    break;
                case "I":
                    //Inserir novo look
                    Look_Map.BtnSearchInserir(driver);
                    PreencherLook(driver, objDados);
                    break;
                case "U":
                    //Atualizar look existente
                    ConsultaLook(driver, objDados);
                    Look_Map.CkbSearchItem(driver).Click();
                    Look_Map.BtnSearchEditarItem(driver).Click();
                    PreencherLook(driver, objDados);
                    break;
                case "D":
                    //Excluir look existente
                    ConsultaLook(driver, objDados);
                    Look_Map.CkbSearchItem(driver).Click();
                    Look_Map.BtnSearchExcluirItem(driver).Click();
                    ExcluirLook(driver);
                    break;
                case "X":
                    //Importar look
                    ImportarLook(driver);
                    break;
            }
        }

        //Consultar Look
        public void ConsultaLook(IWebDriver driver, Look_Dao objLook)
        {
            var primeiroCampo = Tbutil.WaitForFirstExist(driver, Look_Map.TxtSearchNomeLook(driver), 10);

            if (primeiroCampo == true)
            {
                if (!string.IsNullOrEmpty(objLook.SearchNomeLook))
                {
                    Tbreport.GetScreenShot(driver, objLook.SearchNomeLook);
                    Look_Map.TxtSearchNomeLook(driver).Clear();
                    Look_Map.TxtSearchNomeLook(driver).SendKeys(objLook.SearchNomeLook);
                }
                if (!string.IsNullOrEmpty(objLook.SearchCodigoInternoProduto))
                {
                    Tbreport.GetScreenShot(driver, objLook.SearchCodigoInternoLook);
                    Look_Map.TxtSearchCodigoInternoLook(driver).Clear();
                    Look_Map.TxtSearchCodigoInternoLook(driver).SendKeys(objLook.SearchCodigoInternoLook);
                }
                if (!string.IsNullOrEmpty(objLook.SearchCodigoInternoProduto))
                {
                    Tbreport.GetScreenShot(driver, objLook.SearchCodigoInternoProduto);
                    Look_Map.TxtSearchCodigoInternoProduto(driver).Clear();
                    Look_Map.TxtSearchCodigoInternoProduto(driver).SendKeys(objLook.SearchCodigoInternoProduto);
                }
                if (!string.IsNullOrEmpty(objLook.SearchStatus))
                {
                    switch (objLook.SearchStatus)
                    {
                        case "Todos":
                            Look_Map.RdoSearchStatusTodos(driver).Click();
                            Tbreport.GetScreenShot(driver, "SearchStatus");
                            break;

                        case "Ativo":
                            Look_Map.RdoSearcStatusAtivo(driver).Click();
                            Tbreport.GetScreenShot(driver, "SearchStatus");
                            break;

                        case "Inativo":
                            Look_Map.RdoSearchStatusInativo(driver).Click();
                            Tbreport.GetScreenShot(driver, "SearchStatus");
                            break;
                    }
                }
                Look_Map.BtnSearchPsesquisar(driver).Click();
            }
        }

        public void PreencherLook(IWebDriver driver, Look_Dao objLook)
        {
            var primeiroCampo = Tbutil.WaitForFirstExist(driver, Look_Map.TxtInserirNome(driver), 10);

            if (primeiroCampo == true)
            {
                if (!string.IsNullOrEmpty(objLook.InserirNome))
                {
                    Tbreport.GetScreenShot(driver, objLook.SearchNomeLook);
                    Look_Map.TxtInserirNome(driver).Clear();
                    Look_Map.TxtInserirNome(driver).SendKeys(objLook.InserirNome);
                }
                if (!string.IsNullOrEmpty(objLook.InserirCodigoInterno))
                {
                    Tbreport.GetScreenShot(driver, objLook.SearchNomeLook);
                    Look_Map.TxtInserirCodigoInterno(driver).Clear();
                    Look_Map.TxtInserirCodigoInterno(driver).SendKeys(objLook.InserirCodigoInterno);
                }
                if (!string.IsNullOrEmpty(objLook.InserirCodigoYoutube))
                {
                    Tbreport.GetScreenShot(driver, objLook.SearchNomeLook);
                    Look_Map.TxtInserirCodigoYoutube(driver).Clear();
                    Look_Map.TxtInserirCodigoYoutube(driver).SendKeys(objLook.InserirCodigoYoutube);
                }
                if (!string.IsNullOrEmpty(objLook.InserirStatus))
                {
                    if (objLook.InserirStatus == "Ativo")
                    {
                        Tbreport.GetScreenShot(driver, objLook.InserirStatus);
                        Look_Map.RdotInserirStatusAtivo(driver).Click();
                    }
                    else
                    {
                        Tbreport.GetScreenShot(driver, objLook.InserirStatus);
                        Look_Map.RdotInserirStatusInativo(driver).Click();
                    }
                }
                if (!string.IsNullOrEmpty(Convert.ToString(objLook.InserirDesconto)))
                {
                    Tbreport.GetScreenShot(driver, Convert.ToString(objLook.InserirDesconto));
                    Look_Map.TxtinserirDesconto(driver).Clear();
                    Look_Map.TxtinserirDesconto(driver).SendKeys(Convert.ToString(objLook.InserirDesconto));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(objLook.InserirPorcentagem)))
                {
                    Tbreport.GetScreenShot(driver, Convert.ToString(objLook.InserirPorcentagem));
                    Look_Map.TxtinserirPorcentagem(driver).Clear();
                    Look_Map.TxtinserirPorcentagem(driver).SendKeys(Convert.ToString(objLook.InserirPorcentagem));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(objLook.InserirFabricante)))
                {
                    if (objLook.InserirNovoFabricante == false)
                    {
                        Tbreport.GetScreenShot(driver, objLook.InserirFabricante);
                        Look_Map.TxtInserirSelecioneFabricante(driver).Clear();
                        Look_Map.TxtInserirSelecioneFabricante(driver).SendKeys(objLook.InserirFabricante);
                        Look_Map.TxtInserirSelecioneFabricante(driver).SendKeys(Keys.ArrowDown);
                        Look_Map.TxtInserirSelecioneFabricante(driver).SendKeys(Keys.Enter);
                        Look_Map.BtnInserirPesquisarCategoria(driver).Click();
                    }
                    else
                    {
                        Look_Map.HplInserirNovoFabricante(driver).Click();

                        driver.SwitchTo().Frame(driver.FindElement(By.Id("fancybox-frame")));

                        //Wait

                        if (!string.IsNullOrEmpty(Convert.ToString(objLook.NovoFabricanteCodigoInterno)))
                        {
                            Tbreport.GetScreenShot(driver, Convert.ToString(objLook.NovoFabricanteCodigoInterno));
                            Look_Map.TxtInserirFabricanteCodigoInterno(driver).Clear();
                            Look_Map.TxtInserirFabricanteCodigoInterno(driver).SendKeys(Convert.ToString(objLook.NovoFabricanteCodigoInterno));
                        }
                        if (!string.IsNullOrEmpty(Convert.ToString(objLook.NovoFabricanteNome)))
                        {
                            Tbreport.GetScreenShot(driver, objLook.NovoFabricanteNome);
                            Look_Map.TxtInserirFabricanteNome(driver).Clear();
                            Look_Map.TxtInserirFabricanteNome(driver).SendKeys(objLook.NovoFabricanteNome);
                        }
                        if (!string.IsNullOrEmpty(Convert.ToString(objLook.NovoFabricanteMenu)))
                        {
                            Tbreport.GetScreenShot(driver, objLook.NovoFabricanteMenu);
                            Look_Map.SelectInserirFabricanteMenu(driver).SelectByText(objLook.NovoFabricanteMenu);
                        }

                        if (!string.IsNullOrEmpty(Convert.ToString(objLook.NovoFabricanteMenu)))
                        {
                            Tbreport.GetScreenShot(driver, objLook.NovoFabricanteMenu);
                            Look_Map.SelectInserirFabricanteMenu(driver).SelectByText(objLook.NovoFabricanteMenu);
                        }

                        Look_Map.BtnInserirFabricanteInserirFabricante(driver);

                        Look_Map.BtnInserirFabricanteClose(driver);

                        //wait

                        if (!string.IsNullOrEmpty(Convert.ToString(objLook.InserirFabricante)))
                        {
                            Tbreport.GetScreenShot(driver, objLook.InserirFabricante);
                            Look_Map.TxtInserirSelecioneFabricante(driver).Clear();
                            Look_Map.TxtInserirSelecioneFabricante(driver).SendKeys(objLook.InserirFabricante);
                            Look_Map.TxtInserirSelecioneFabricante(driver).SendKeys(Keys.ArrowDown);
                            Look_Map.TxtInserirSelecioneFabricante(driver).SendKeys(Keys.Enter);
                            Look_Map.BtnInserirPesquisarCategoria(driver).Click();
                        }
                    }
                }

                Look_Map.ChbInserirResultadoPesquisaCategoria(driver).Click();

                Look_Map.BtnInserirAdicionarCategoria(driver).Click();

                if (!string.IsNullOrEmpty(objLook.InserirDescricao))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirDescricao);
                    Look_Map.TxtInserirDescricao(driver).Clear();
                    Look_Map.TxtInserirDescricao(driver).SendKeys(objLook.InserirDescricao);
                }
                if (!string.IsNullOrEmpty(objLook.InserirLongPage))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirLongPage);
                    Look_Map.TxtInserirLongPage(driver).Clear();
                    Look_Map.TxtInserirLongPage(driver).SendKeys(objLook.InserirLongPage);
                }
                if (!string.IsNullOrEmpty(objLook.InserirOcasiao))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirOcasiao);
                    Look_Map.TxtInserirFiltroOcasiao(driver).Clear();
                    Look_Map.TxtInserirFiltroOcasiao(driver).SendKeys(objLook.InserirOcasiao);
                    Look_Map.BtnInserirFiltroOcasiao(driver).Click();
                }
                if (!string.IsNullOrEmpty(objLook.InserirEstilo))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirEstilo);
                    Look_Map.TxtInserirFiltroEstilo(driver).Clear();
                    Look_Map.TxtInserirFiltroEstilo(driver).SendKeys(objLook.InserirEstilo);
                    Look_Map.BtnInserirFiltroEstilo(driver).Click();
                }
                if (!string.IsNullOrEmpty(objLook.InserirTendencia))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirEstilo);
                    Look_Map.TxtInserirFiltroTendencia(driver).Clear();
                    Look_Map.TxtInserirFiltroTendencia(driver).SendKeys(objLook.InserirTendencia);
                    Look_Map.BtnInserirFiltroTendencia(driver).Click();
                }
                if (!string.IsNullOrEmpty(objLook.InserirNomeProduto))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirNomeProduto);
                    Look_Map.TxtInserirNomeProduto(driver).Clear();
                    Look_Map.TxtInserirNomeProduto(driver).SendKeys(objLook.InserirNomeProduto);
                }
                if (!string.IsNullOrEmpty(objLook.InserirCodigoInternoProduto))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirCodigoInternoProduto);
                    Look_Map.TxtInserirCodigoInternoProduto(driver).Clear();
                    Look_Map.TxtInserirCodigoInternoProduto(driver).SendKeys(objLook.InserirCodigoInternoProduto);
                    Look_Map.BtnInserirProduto(driver).Click();
                }

                Look_Map.RdoInserirResultadoProduto(driver).Click();

                Look_Map.ChbInserirSkuProduto(driver).Click();

                if (!string.IsNullOrEmpty(Convert.ToString(objLook.InserrirQuantidadeProdutoSkuSelecionado)))
                {
                    Tbreport.GetScreenShot(driver, objLook.InserirCodigoInternoProduto);
                    Look_Map.ChbInserirQuantidadeProduto(driver).Clear();
                    Look_Map.ChbInserirQuantidadeProduto(driver).SendKeys(Convert.ToString(objLook.InserrirQuantidadeProdutoSkuSelecionado));
                }

                Look_Map.BtnInserirSalvar(driver).Click();
            }
        }

        public void ExcluirLook(IWebDriver driver)
        {

        }

        public void ImportarLook(IWebDriver driver)
        {

        }
    }
}