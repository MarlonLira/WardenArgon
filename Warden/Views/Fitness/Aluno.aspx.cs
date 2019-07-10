using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Warden.Component.Common.Button;

namespace Warden.Views.Fitness {
    public partial class Aluno : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Aluno"] != null) {
                profile_control.IsReadOnly = true;
                AlunoEdit = (AlunoPst)Session["Aluno"];
                profile_control.LoadForm(AlunoEdit);
            }
            if (Global.Funcionario == null & Global.Aluno == null) {
                Response.Redirect("~/Views/Login.aspx", false);
            }
            
            btn_prox_etapa.OnClick += new SquareButtonUsc.OnClickEvent(BtnProxEtapa_Click);
            btn_verif_etapa.OnClick += new SquareButtonUsc.OnClickEvent(BtnVerifEtapa_Click);
        }

        public AlunoPst AlunoEdit { get; set; }

        public void BtnProxEtapa_Click() {

            try {
                MarcarProxEtapa();

            } finally {

            }
        }

        public void BtnVerifEtapa_Click() {
            
        }

        public void MarcarProxEtapa() {
            Session.Add("MarcarProxEtapa", AlunoEdit);
            Response.Redirect("~/views/fitness/Colaborador/Calendario.aspx");
        }

        public void LoadEtapa() {

            Response.Redirect("~/views/fitness/etapas.aspx");
        }
    }
}