using System;
using System.Web.UI;

namespace Warden.Views {
    public partial class Login : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Error"] != null) {
                lbl_erro.Text = (String)Session["Error"];
            }
            
        }
    }
}