using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Views.Fitness {
    public partial class FitnessPge : Page {

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