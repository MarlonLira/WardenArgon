using System;
using System.Web.UI;

namespace Warden.Views {
    public partial class Login : Page {
        protected void Page_Load(object sender, EventArgs e) {
            ButtonUsc.BtnControl_Click += new EventHandler(ButtonUsc_Click);
        }

        protected void ButtonUsc_Click(object sender, EventArgs e) {
            Response.Redirect("./Fitness/Etapas.aspx", false);
        }
    }
}