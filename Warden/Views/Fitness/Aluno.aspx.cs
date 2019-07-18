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
            
            btn_marcar_atendimento.OnClick += new ButtonUsc.OnClickEvent(BtnMarcarAtendimento_Click);
            btn_verif_progresso.OnClick += new ButtonUsc.OnClickEvent(BtnVerifProgresso_Click);
            btn_atendimento.OnClick += new ButtonUsc.OnClickEvent(Btn_atendimento_OnClick);
        }

        private void Btn_atendimento_OnClick() {
            try {
                Atendimento();
            } finally {

            }
        }

        public AlunoPst AlunoEdit { get; set; }

        public void BtnMarcarAtendimento_Click() {

            try {
                MarcarProxEtapa();

            } finally {

            }
        }

        public void BtnVerifProgresso_Click() {
            
        }
        public void Atendimento() {
            Response.Redirect("~/views/fitness/Etapas.aspx");
        }

        public void MarcarProxEtapa() {
            Session.Add("MarcarProxEtapa", AlunoEdit);
            Response.Redirect("~/views/fitness/Colaborador/Calendar.aspx");
        }

        public void LoadEtapa() {

            Response.Redirect("~/views/fitness/etapas.aspx");
        }
    }
}