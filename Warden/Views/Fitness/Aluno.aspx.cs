using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Warden.Component.Common.Button;

namespace Warden.Views.Fitness {
    public partial class Aluno : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Aluno"] != null) {
                profile_control.IsReadOnly = true;
                profile_control.LoadForm((AlunoPst)Session["Aluno"]);
            }
            
            btn_prox_etapa.OnClick += new SquareButtonUsc.OnClickEvent(BtnProxEtapa_Click);
            btn_verif_etapa.OnClick += new SquareButtonUsc.OnClickEvent(BtnVerifEtapa_Click);
        }

        public void BtnProxEtapa_Click() {

            try {
                LoadEtapa();

            } catch (Exception Err) {

            }
        }

        public void BtnVerifEtapa_Click() {
            
        }

        public void LoadEtapa() {

            Response.Redirect("~/views/fitness/etapas.aspx");
        }
    }
}