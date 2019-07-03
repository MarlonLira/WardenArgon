using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Button {
    public partial class RoundButtonUsc : BaseUsc {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

        public String UrlImg { get; set; }
        public String Title {
            get { return this.lbl_title.Text; }
            set { this.lbl_title.Text = value; }
        }

        public String Text {
            get { return this.lbl_description.Text; }
            set {
                this.lbl_description.FontSize = 10;
                this.lbl_description.Text = value;
            }
        }

        public String BtnText { get; set; }
    }
}