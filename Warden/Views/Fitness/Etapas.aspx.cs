using Brasdat.Gestor.Library.Business.Classes.Fitness;
using System;

namespace Warden.Views.Fitness {
    public partial class Etapas : FitnessPge {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            LoadEtapas();
        }

        public void LoadEtapas() {
            if (Session["Aluno"] != null) {
                UserFormUsc.LoadForm((AlunoPst)Session["Aluno"]);
                UserFormUsc.BtnText = "Editar";
            }
        }

    }
}