using Brasdat.Gestor.Library.Business.Classes.Administracao;
using Brasdat.Gestor.Library.Core.Classes.Helpers;
using System;
using System.Web.UI;
using Warden.Component.Common.Button;

namespace Warden.Views {
    public partial class Login : Page {
        protected void Page_Load(object sender, EventArgs e) {
           ButtonUsc.OnClick += new ButtonUsc.OnClickEvent(ButtonUsc_Click);
        }

        protected void ButtonUsc_Click() {
            if (!(String.IsNullOrEmpty(txt_email.Text) || String.IsNullOrEmpty(txt_password.Text))) {
                ColaboradorEntrar(txt_email.Text, txt_password.Text);
            }
        }

        private void ColaboradorEntrar(String ContaAcesso, String Senha) {
            FuncionarioPst Funcionario = null;
            String Advertencia = "";
            try {

                Funcionario = new FuncionarioPst();
                Funcionario.Usuario = ContaAcesso;
                Funcionario.Senha = Senha;

                if (Funcionario.Autenticar("",
                    Request.ServerVariables["REMOTE_ADDR"], Request.ServerVariables["REMOTE_HOST"],
                    Global.Empresa.EmpresaGrupo.Id, out Advertencia, ModulesNameList.PORTAL, 1)) {

                    Global.Funcionario = Funcionario;
                    Global.SetEmpresa(Funcionario.Empresa.Id);

                    Response.Redirect("./Default.aspx", false);
                }
                
            } finally {
                Funcionario = null;
            }
        }
    }
}