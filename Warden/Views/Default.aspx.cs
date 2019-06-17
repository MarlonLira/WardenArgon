using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;

namespace Warden.Views {
    public partial class Default : Page {

        protected void Page_Load(object sender, EventArgs e) {
            this.TabsUsc.OnFind += TabsUsc_OnFind;

        }

        private void TabsUsc_OnFind(System.Data.DataRow SelectedRow) {
            AlunoPst Aluno = new AlunoPst();
            Aluno.Preencher(SelectedRow);
            Session["Aluno"] = Aluno;
            Response.Redirect("~/views/fitness/etapas.aspx");
        }

    }
}