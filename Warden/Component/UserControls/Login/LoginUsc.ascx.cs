using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Warden.Component.Common.Button;

namespace Warden.Component.UserControls.Login {
    public partial class LoginUsc : BaseUsc {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            btn_hi.OnClick += new ButtonUsc.OnClickEvent(BtnHi_OnClick);
            btn_hix.OnClick += new ButtonUsc.OnClickEvent(BtnHix_OnClick);
        }

        public void BtnHi_OnClick() {
            Response.Redirect("https://www.hiacademia.com.br/portal", false);
        }

        public void BtnHix_OnClick() {
            Response.Redirect("https://www.hixacademia.com.br/portal", false);
        }


    }
}