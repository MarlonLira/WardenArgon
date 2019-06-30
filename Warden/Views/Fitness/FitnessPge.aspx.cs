using System;

namespace Warden.Views.Fitness {
    public partial class FitnessPge : BasePge {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (Global.Funcionario == null & Global.Aluno == null) {
                Response.Redirect("~/Views/Login.aspx", false);
            }
            if (Global.Aluno == null) {
                Response.Redirect("~/Views/Default.aspx", false);
            }
        }
        
    }
}