using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;

namespace Warden.Views.Fitness {
    public partial class Etapas : Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Aluno"] != null) {
                UserFormUsc.LoadForm((AlunoPst)Session["Aluno"]);
                UserFormUsc.BtnText = "Editar";
            }
        }

    }
}