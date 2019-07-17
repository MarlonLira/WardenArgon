using Brasdat.Gestor.Library.Business.Classes.Fitness;
using System;

namespace Warden.Views.Fitness {
    public partial class FitnessPge : BasePge {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

       public AlunoPst SelectedAluno {
            get {
                AlunoPst Aluno = new AlunoPst();
                if (Session["Aluno"] != null) {
                    Aluno = (AlunoPst)Session["Aluno"];
                }
                return Aluno;
            }
        }
    }
}