using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Ikcadm.Test.Dao
{
    public class Look_Dao
    {
        //ID_Teste
        private int _ID_Teste;
        public int ID_Teste { get { return _ID_Teste; } set { _ID_Teste = value; } }

        //Descricao_CasoTeste
        private string _Descricao_CasoTeste;
        public string Descricao_CasoTeste { get { return _Descricao_CasoTeste; } set { _Descricao_CasoTeste = value; } }

        //Operacao
        private string _Operacao;
        public string Operacao { get { return _Operacao; } set { _Operacao = value; } }

        //ConfigID
        private int _ConfigID;
        public int ConfigID { get { return _ConfigID; } set { _ConfigID = value; } }

        //SuiteID
        private int _SuiteID;
        public int SuiteID { get { return _SuiteID; } set { _SuiteID = value; } }

        //TestCaseID
        private int _TestCaseID;
        public int TestCaseID { get { return _TestCaseID; } set { _TestCaseID = value; } }

        //MassaDados
        private bool _MassaDados;
        public bool MassaDados { get { return _MassaDados; } set { _MassaDados = value; } }

        //MenuOpcao
        private string _MenuOpcao;
        public string MenuOpcao { get { return _MenuOpcao; } set { _MenuOpcao = value; } }

        //SearchNomeLook
        private string _SearchNomeLook;
        public string SearchNomeLook { get { return _SearchNomeLook; } set { _SearchNomeLook = value; } }

        //SearchCodigoInternoLook
        private string _SearchCodigoInternoLook;
        public string SearchCodigoInternoLook { get { return _SearchCodigoInternoLook; } set { _SearchCodigoInternoLook = value; } }

        //SearchCodigoInternoProduto
        private string _SearchCodigoInternoProduto;
        public string SearchCodigoInternoProduto { get { return _SearchCodigoInternoProduto; } set { _SearchCodigoInternoProduto = value; } }

        //SearchStatus
        private string _SearchStatus;
        public string SearchStatus { get { return _SearchStatus; } set { _SearchStatus = value; } }

        //InserirNome
        private string _InserirNome;
        public string InserirNome { get { return _InserirNome; } set { _InserirNome = value; } }

        //InserirCodigoInterno
        private string _InserirCodigoInterno;
        public string InserirCodigoInterno { get { return _InserirCodigoInterno; } set { _InserirCodigoInterno = value; } }

        //InserirCodigoYoutube
        private string _InserirCodigoYoutube;
        public string InserirCodigoYoutube { get { return _InserirCodigoYoutube; } set { _InserirCodigoYoutube = value; } }

        //InserirStatus
        private string _InserirStatus;
        public string InserirStatus { get { return _InserirStatus; } set { _InserirStatus = value; } }

        //InserirDesconto
        private int _InserirDesconto;
        public int InserirDesconto { get { return _InserirDesconto; } set { _InserirDesconto = value; } }

        //InserirPorcentagem
        private int _InserirPorcentagem;
        public int InserirPorcentagem { get { return _InserirPorcentagem; } set { _InserirPorcentagem = value; } }

        //InserirFabricante
        private string _InserirFabricante;
        public string InserirFabricante { get { return _InserirFabricante; } set { _InserirFabricante = value; } }

        //InserirNovoFabricante
        private bool _InserirNovoFabricante;
        public bool InserirNovoFabricante { get { return _InserirNovoFabricante; } set { _InserirNovoFabricante = value; } }

        //NovoFabricanteCodigoInterno
        private string _NovoFabricanteCodigoInterno;
        public string NovoFabricanteCodigoInterno { get { return _NovoFabricanteCodigoInterno; } set { _NovoFabricanteCodigoInterno = value; } }

        //NovoFabricanteNome
        private string _NovoFabricanteNome;
        public string NovoFabricanteNome { get { return _NovoFabricanteNome; } set { _NovoFabricanteNome = value; } }

        //NovoFabricanteMenu
        private string _NovoFabricanteMenu;
        public string NovoFabricanteMenu { get { return _NovoFabricanteMenu; } set { _NovoFabricanteMenu = value; } }

        //InserirDataLancamento
        private string _InserirDataLancamento;
        public string InserirDataLancamento { get { return _InserirDataLancamento; } set { _InserirDataLancamento = value; } }

        //InserirCompraCompleta
        private bool _InserirCompraCompleta;
        public bool InserirCompraCompleta { get { return _InserirCompraCompleta; } set { _InserirCompraCompleta = value; } }

        //InserirCompraCompletaClientePodeAlterarQuantidadeItens
        private bool _InserirCompraCompletaClientePodeAlterarQuantidadeItens;
        public bool InserirCompraCompletaClientePodeAlterarQuantidadeItens { get { return _InserirCompraCompletaClientePodeAlterarQuantidadeItens; } set { _InserirCompraCompletaClientePodeAlterarQuantidadeItens = value; } }

        //InserirCompraCompletaSkuEmGrade
        private bool _InserirCompraCompletaSkuEmGrade;
        public bool InserirCompraCompletaSkuEmGrade { get { return _InserirCompraCompletaSkuEmGrade; } set { _InserirCompraCompletaSkuEmGrade = value; } }

        //InserirCategorias
        private string _InserirCategorias;
        public string InserirCategorias { get { return _InserirCategorias; } set { _InserirCategorias = value; } }

        //InserirNovaCategoria
        private bool _InserirNovaCategoria;
        public bool InserirNovaCategoria { get { return _InserirNovaCategoria; } set { _InserirNovaCategoria = value; } }

        //NovaCategoriaNome
        private string _NovaCategoriaNome;
        public string NovaCategoriaNome { get { return _NovaCategoriaNome; } set { _NovaCategoriaNome = value; } }

        //NovaCategoriaCodigoInterno
        private string _NovaCategoriaCodigoInterno;
        public string NovaCategoriaCodigoInterno { get { return _NovaCategoriaCodigoInterno; } set { _NovaCategoriaCodigoInterno = value; } }

        //NovaCategoriaPai
        private string _NovaCategoriaPai;
        public string NovaCategoriaPai { get { return _NovaCategoriaPai; } set { _NovaCategoriaPai = value; } }

        //NovaCategoriaMenu
        private string _NovaCategoriaMenu;
        public string NovaCategoriaMenu { get { return _NovaCategoriaMenu; } set { _NovaCategoriaMenu = value; } }

        //NovaCategoriaStatus
        private string _NovaCategoriaStatus;
        public string NovaCategoriaStatus { get { return _NovaCategoriaStatus; } set { _NovaCategoriaStatus = value; } }

        //InserirDescricao
        private string _InserirDescricao;
        public string InserirDescricao { get { return _InserirDescricao; } set { _InserirDescricao = value; } }

        //InserirLongPage
        private string _InserirLongPage;
        public string InserirLongPage { get { return _InserirLongPage; } set { _InserirLongPage = value; } }

        //InserirOcasiao
        private string _InserirOcasiao;
        public string InserirOcasiao { get { return _InserirOcasiao; } set { _InserirOcasiao = value; } }

        //Inserirestilo
        private string _Inserirestilo;
        public string InserirEstilo { get { return _Inserirestilo; } set { _Inserirestilo = value; } }

        //InserirTendencia
        private string _InserirTendencia;
        public string InserirTendencia { get { return _InserirTendencia; } set { _InserirTendencia = value; } }

        //InserirNomeProduto
        private string _InserirNomeProduto;
        public string InserirNomeProduto { get { return _InserirNomeProduto; } set { _InserirNomeProduto = value; } }

        //InserirCodigoInternoProduto
        private string _InserirCodigoInternoProduto;
        public string InserirCodigoInternoProduto { get { return _InserirCodigoInternoProduto; } set { _InserirCodigoInternoProduto = value; } }

        //InserrirQuantidadeProdutoSkuSelecionado
        private int _InserrirQuantidadeProdutoSkuSelecionado;
        public int InserrirQuantidadeProdutoSkuSelecionado { get { return _InserrirQuantidadeProdutoSkuSelecionado; } set { _InserrirQuantidadeProdutoSkuSelecionado = value; } }


    }
}
