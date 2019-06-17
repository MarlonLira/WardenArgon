using Brasdat.Gestor.Library.Business.Classes.Administracao;
using Brasdat.Gestor.Library.Business.Classes.Enums;
using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Core.Classes.Helpers;
using Brasdat.Gestor.Library.Core.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace Warden {
    public class Global : HttpApplication {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        #region Constants

        private const String KEY_CACHE_GRUPO_EMPRESAS = "Global.GrupoEmpresas";
        public const String KEY_CACHE_EMPRESAS = "Global.Empresas";
        private const String KEY_CACHE_EMPRESA = "Global.Empresa";
        private const String KEY_CACHE_PROFESSORES = "Global.Professores";
        private const String KEY_CACHE_CONSULTORES = "Global.Consultores";

        #endregion

        #region Attributes

        private static Exception _ServerScriptError;

        public static DataTable GrupoEmpresas {
            get {
                DataTable Result = (DataTable)ContextHlp.GetCache(KEY_CACHE_GRUPO_EMPRESAS);
                if (Result == null) {
                    EmpresaPst _EmpresaFiltro;
                    try {
                        if (Empresa.EmpresaGrupo != null) {
                            _EmpresaFiltro = new EmpresaPst();
                            _EmpresaFiltro.Filters = new List<BaseMdl.Filter>();
                            _EmpresaFiltro.Filters.Add(new BaseMdl.Filter("[empresa_grupo_id] IN (501, 502)", CompareModeTypes.EXPRESSION));
                            Result = _EmpresaFiltro.Pesquisar();
                            ContextHlp.SetCache(KEY_CACHE_GRUPO_EMPRESAS, Result);
                        }
                    } finally {
                        _EmpresaFiltro = null;
                    }
                }
                return Result;
            }
        }

        public static DataTable Empresas {
            get {
                DataTable Result = (DataTable)ContextHlp.GetCache(KEY_CACHE_EMPRESAS);
                if (Result == null) {
                    EmpresaPst _EmpresaFiltro;
                    try {
                        if (Empresa != null && Empresa.EmpresaGrupo != null) {
                            _EmpresaFiltro = new EmpresaPst();
                            _EmpresaFiltro.Filters = new List<BaseMdl.Filter>();
                            _EmpresaFiltro.Filters.Add(new BaseMdl.Filter("[empresa_grupo_id]", CompareModeTypes.EQUAL,
                                Empresa.EmpresaGrupo.Id));
                            Result = _EmpresaFiltro.Pesquisar();
                            ContextHlp.SetCache(KEY_CACHE_EMPRESAS, Result);
                        }
                    } finally {
                        _EmpresaFiltro = null;
                    }
                }
                return Result;
            }
        }

        public static EmpresaPst Empresa {
            get {
                EmpresaPst Result = (EmpresaPst)ContextHlp.GetCache(KEY_CACHE_EMPRESA);
                if (Result == null) {
                    Result = new EmpresaPst();
                    Result.Filters = new List<BaseMdl.Filter>();
                    Result.Filters.Add(new BaseMdl.Filter("[codigo_externo]", CompareModeTypes.EQUAL,
                        ContextHlp.GetSettings(SettingKeyList.CONTEXT_EMPRESA_COD)));
                    Result.Carregar();
                    ContextHlp.SetCache(KEY_CACHE_EMPRESA, Result);
                }
                return Result;
            }
        }

        public static Exception ScriptException {
            get {
                return _ServerScriptError;
            }
            set {
                _ServerScriptError = value;
            }
        }

        public static String CurrentUrl {
            get {
                String Result = "";
                if (HttpContext.Current.Request.Url != null) {
                    if (!String.IsNullOrEmpty(ContextHlp.GetSettings(SettingKeyList.URL_WEB_APPLICATION))) {
                        Result = @"~" + HttpContext.Current.Request.Url.LocalPath.Replace(ContextHlp.GetSettings(SettingKeyList.URL_WEB_APPLICATION), "");
                    } else {
                        Result = @"~" + HttpContext.Current.Request.Url.LocalPath;
                    }
                }
                return Result;
            }
        }

        public static AlunoPst Aluno {
            get {
                return (AlunoPst)ContextHlp.GetCache("Global.Aluno");
            }
            set {
                ContextHlp.SetCache("Global.Aluno", value);
            }
        }

        public static FuncionarioPst Funcionario {
            get {
                return (FuncionarioPst)ContextHlp.GetCache("Global.Funcionario");
            }
            set {
                ContextHlp.SetCache("Global.Funcionario", value);
            }
        }

        public static Int16 WebLocal {
            get {
                return Convert.ToInt16(ContextHlp.GetSettings(SettingKeyList.WEB_LOCAL));
            }
        }

        public static Boolean UseIntranet {
            get {
                return WebLocal.Equals(1);
            }
        }

        public static ParametroPst Parametro {
            get {
                ParametroPst Result = ((ParametroPst)ContextHlp.GetCache("Global.Parametro"));
                if (Result == null) {
                    Result = new ParametroPst();
                    ContextHlp.SetCache("Global.Parametro", Result);
                }
                return Result;
            }
        }

        public static Boolean UsePerfilGerencial {
            get {
                Boolean Result = false;
                if (Global.Funcionario != null) {
                    String[] Grupos = Parametro.GetValor("GRUPOS_GERENCIADOR").Split(',');
                    foreach (String Grupo in Grupos) {
                        if (Global.Funcionario.Grupo.Codigo == ((GrupoEnm)Convert.ToInt32(Grupo))) {
                            Result = true;
                            break;
                        }
                    }
                }
                return Result;
            }
        }

        public static Boolean UsePerfilGestor {
            get {
                Boolean Result = false;
                if (Global.Funcionario != null) {
                    String[] Grupos = Parametro.GetValor("GRUPOS_GESTOR").Split(',');
                    foreach (String Grupo in Grupos) {
                        if (Global.Funcionario.Grupo.Codigo == ((GrupoEnm)Convert.ToInt32(Grupo))) {
                            Result = true;
                            break;
                        }
                    }
                }
                return Result;
            }
        }

        public static DataTable Professores {
            get {
                DataTable Result = null;
                FuncionarioPst Funcionario;
                List<Object> GrupoList = new List<Object>();
                try {

                    Result = ((DataTable)ContextHlp.GetCache(KEY_CACHE_PROFESSORES));
                    if (Result == null) {

                        String[] Grupos = Parametro.GetValor("GRUPOS_PROFESSOR").Split(',');
                        foreach (String Grupo in Grupos) {
                            GrupoList.Add(Grupo);
                        }

                        Funcionario = new FuncionarioPst() { Filters = new List<BaseMdl.Filter>() };
                        Funcionario.Filters.Add(new BaseMdl.Filter("[status]", CompareModeTypes.EQUAL, "AT"));
                        Funcionario.Filters.Add(new BaseMdl.Filter("[empresa_id]", CompareModeTypes.EQUAL, Global.Empresa.Id));
                        Funcionario.Filters.Add(new BaseMdl.Filter("[grupo_codigo]", GrupoList));

                        Result = Funcionario.Pesquisar();
                        ContextHlp.SetCache(KEY_CACHE_PROFESSORES, Result);

                    }

                    return Result.DefaultView.ToTable();

                } finally {
                    Funcionario = null;
                    GrupoList = null;
                    Result = null;
                }
            }
        }

        public static DataTable Consultores {
            get {
                DataTable Table = null;
                DataTable Result = null;
                DataRow NewRow = null;
                FuncionarioPst Funcionario;
                List<Object> GrupoList = new List<Object>();
                try {

                    Result = ((DataTable)ContextHlp.GetCache(KEY_CACHE_CONSULTORES));
                    if (Result == null) {

                        String[] Grupos = Parametro.GetValor("GRUPOS_CONSULTOR").Split(',');
                        foreach (String Grupo in Grupos) {
                            GrupoList.Add(Grupo);
                        }

                        Funcionario = new FuncionarioPst() { Filters = new List<BaseMdl.Filter>() };
                        Funcionario.Filters.Add(new BaseMdl.Filter("[status]", CompareModeTypes.EQUAL, "AT"));
                        Funcionario.Filters.Add(new BaseMdl.Filter("[empresa_id]", CompareModeTypes.EQUAL, Global.Empresa.Id));
                        Funcionario.Filters.Add(new BaseMdl.Filter("[grupo_codigo]", GrupoList));

                        Result = Funcionario.Pesquisar();
                        if (Result != null) {
                            //acrescentar o usuario logado caso seja um consultor
                            if (Global.Funcionario != null && Global.Funcionario.Grupo != null &&
                                Global.Funcionario.Grupo.Codigo == GrupoEnm.CONSULTORES_DE_VENDAS) {
                                if (Result.Select("id = " + Convert.ToString(Global.Funcionario.Id)).Length.Equals(0)) {
                                    NewRow = Result.NewRow();
                                    foreach (DataColumn Col in Result.Columns) {
                                        Col.AllowDBNull = true;
                                    }
                                    Funcionario = new FuncionarioPst() { Filters = new List<BaseMdl.Filter>() };
                                    Funcionario.Filters.Add(new BaseMdl.Filter("[id]", CompareModeTypes.EQUAL, Global.Funcionario.Id));
                                    Table = Funcionario.Pesquisar();
                                    if (Table != null && Table.Rows.Count > 0) {
                                        for (Int32 IndexCol = 0; IndexCol < Result.Columns.Count; IndexCol++) {
                                            NewRow[Result.Columns[IndexCol].ColumnName] = Table.Rows[0][Result.Columns[IndexCol].ColumnName];
                                        }
                                        Result.Rows.Add(NewRow);
                                    }
                                }
                            }
                        }

                        ContextHlp.SetCache(KEY_CACHE_CONSULTORES, Result);

                    }

                    return Result.DefaultView.ToTable();

                } finally {
                    Funcionario = null;
                    GrupoList = null;
                    Table = null;
                    Result = null;
                    NewRow = null;
                }
            }
        }

        public static String EMailSuporte {
            get {
                return Parametro.GetValor("EMAIL_SUPORTE_PORTAL");
            }
        }

        #endregion

        #region Methods

        public static void ProfessoresLimpar() {
            ContextHlp.SetCache(KEY_CACHE_PROFESSORES, null);
        }

        public static void EmpresasLimpar() {
            ContextHlp.SetCache(KEY_CACHE_EMPRESAS, null);
        }

        public static void SetEmpresa(Int32 EmpresaId) {
            if (WebLocal.Equals(0)) { //na internet deve assumir a empresa do usuário autenticado
                ContextHlp.SetCache(KEY_CACHE_EMPRESA, new EmpresaPst(EmpresaId));
                ContextHlp.SetCache(KEY_CACHE_EMPRESAS, null);
            }
        }

        public static String FormatUrl(String Url) {
            String Result = (HttpContext.Current.Request.Url.Authority + @"/" +
                ContextHlp.GetSettings(SettingKeyList.URL_WEB_APPLICATION) + @"/" + Url.Replace(@"~/", @"/"));
            while (Result.IndexOf(@"//") > -1) {
                Result = Result.Replace(@"//", @"/");
            }
            return HttpContext.Current.Request.Url.Scheme + @"://" + Result;
        }

        public static void NavigateForUrl(String Url) {
            NavigateForUrl(Url, false);
        }

        public static void NavigateForUrl(String Url, Boolean UseNewWindow) {
            try {
                if (!UseNewWindow) {
                    HttpContext.Current.Response.Redirect(Url, true);
                } else {
                    HttpContext.Current.Response.Write(@"<script type='text/javascript'>window.open('" + FormatUrl(Url) + "', '_blank');</script>");
                }
            } catch { }
        }

        private Boolean UseSessionEnd(Exception Except) {
            return (Except.GetType().Equals(typeof(System.Data.SqlClient.SqlException)) && ((System.Data.SqlClient.SqlException)Except).Number.Equals(233)) |
                Except.Message.IndexOf("Cannot find column [param_id]", StringComparison.InvariantCultureIgnoreCase) > -1 |
                Except.Message.IndexOf("ASP.NET session has expired or could not be found", StringComparison.InvariantCultureIgnoreCase) > -1 |
                Except.Message.IndexOf("Exception of type 'System.Web.HttpUnhandledException' was thrown", StringComparison.InvariantCultureIgnoreCase) > -1;
        }

        public static void RefreshSession(out String Info) {
            SistemaSessaoPst SistemaSessao = (Global.Funcionario != null &&
                Global.Funcionario.SistemaSessao != null ? Global.Funcionario.SistemaSessao : null);
            try {
                if (SistemaSessao != null) {
                    String CurrentTag = "";
                    SistemaSessao.Atualizar(out CurrentTag);
                    //---
                    if (!String.IsNullOrEmpty(CurrentTag)) {
                        String[] CurrentTagParts = CurrentTag.Split('|');
                        if (CurrentTagParts[0].Equals("kill", StringComparison.InvariantCultureIgnoreCase)) {
                            HttpContext.Current.Session.Abandon();
                        }
                    }
                    //--
                    Info = FormatterHlp.FormatDateTimeToString(SistemaSessao.DataComunicacao);
                } else {
                    Info = "Não há sessão";
                }
            } finally {
                SistemaSessao = null;
            }
        }

        /*
        public static void SendMail(String Email, String Titulo, String Mensagem, String ResponderPara) {
            GatewayWebService.GatewayWsv GatewayWeb;
            try {

                GatewayWeb = new GatewayWebService.GatewayWsv() {
                    CookieContainer = new System.Net.CookieContainer()
                };
                GatewayWeb.Url = ContextHlp.GetSettings(SettingKeyList.URL_SERVICE_SINC) + @"webservice/gatewaywsv.asmx";

                if (!String.IsNullOrEmpty(Email)) {

                    Titulo = CryptoHlp.Encrypt(Titulo);
                    Mensagem = CryptoHlp.Encrypt(Mensagem);

                    String Result = GatewayWeb.EnviarEmail(Global.Empresa.CodigoExterno, Titulo, Mensagem, new String[] { Email },
                        ResponderPara, null);
                    if (!Result.Equals("Ok", StringComparison.InvariantCultureIgnoreCase)) {
                        throw new ExceptionHlp(Result);
                    }

                } else {
                    throw new ExceptionHlp(UIExceptionDicPortal.ENVIAR_EMAIL_NAO_INF);
                }

            } finally {
                GatewayWeb = null;
            }
        }*/

        #endregion
    }
}