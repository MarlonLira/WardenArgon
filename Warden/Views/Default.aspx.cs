using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;

namespace Warden.Views {
    public partial class Default : Page {

        protected void Page_Load(object sender, EventArgs e) {
            /*this.TabsUsc.OnFind += TabsUsc_OnFind;*/
            this.UserSearchFormUsc.OnFind += UserSearchFormUsc_OnFind;
        }

        private void TabsUsc_OnFind(System.Data.DataRow SelectedRow) {
            AlunoPst Aluno = new AlunoPst();
            Aluno.Preencher(SelectedRow);
            Session["Aluno"] = Aluno;

            Response.Redirect("~/views/fitness/Aluno.aspx");
        }

        private void UserSearchFormUsc_OnFind(System.Data.DataRow SelectedRow) {
            AlunoPst Aluno = new AlunoPst();
            Aluno.Preencher(SelectedRow);
            Session["Aluno"] = Aluno;

            Response.Redirect("~/views/fitness/Aluno.aspx");
        }

    }
}