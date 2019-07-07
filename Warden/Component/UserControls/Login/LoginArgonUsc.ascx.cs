using Brasdat.Gestor.Library.Business.Classes.Administracao;
using Brasdat.Gestor.Library.Core.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Warden.Component.Common.Button;

namespace Warden.Component.UserControls.Login {
    public partial class LoginArgonUsc : BaseUsc {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
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

                    Session["Error"] = null;
                    Session["User"] = true;
                    Session.Add("App", "Argon");

                    Response.Redirect("./Telemarketing/Colaborador/Atendimento.aspx", false);
                }

            } catch (Exception Err) {
                Session.Add("Error", " Verifique os dados fornecidos ! " + Err.Message);
            } finally {
                Funcionario = null;
            }
        }
    }
}