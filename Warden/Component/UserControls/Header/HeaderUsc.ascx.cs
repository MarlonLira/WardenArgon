using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Warden.Component.Common.Button;

namespace Warden.Component.UserControls.Header {
    public partial class HeaderUsc : BaseUsc {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            btn_sair.OnClick += new ButtonUsc.OnClickEvent(Btn_sair_OnClick);
        }

        private void Btn_sair_OnClick() {
            try {
                Session.Clear();
                Session.RemoveAll();
                Session.Abandon();
            } finally {
                Response.Redirect("~/Views/Login.aspx", false);
            }
        }
    }
}