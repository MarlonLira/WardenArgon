using Brasdat.Gestor.Library.Business.Classes.Administracao;
using Brasdat.Gestor.Library.Core.Classes.Helpers;
using System;
using System.Web.UI;

namespace Warden.Views {
    public partial class Login : Page {
        protected void Page_Load(object sender, EventArgs e) {
            ButtonUsc.BtnControl_Click += new EventHandler(ButtonUsc_Click);
        }

        protected void ButtonUsc_Click(object sender, EventArgs e) {
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

                    Response.Redirect("./Fitness/Etapas.aspx", false);
                }
                
            } finally {
                Funcionario = null;
            }
        }
    }
}