using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;

namespace Warden.Views.Fitness {
    public partial class Aluno : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Aluno"] != null) {
                profile_control.IsReadOnly = true;
                profile_control.LoadForm((AlunoPst)Session["Aluno"]);
            }
        }

        public void LoadEtapa() {

            Response.Redirect("~/views/fitness/etapas.aspx");
        }
    }
}