using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.TextBox {
    public partial class TextBoxUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            LoadTextBox();
        }

        public String Style { get; set; }
        public String Icon { get; set; }
        public String Placeholder { get; set; }

        public void LoadTextBox() {
            if (String.IsNullOrEmpty(Style)) { Style = ""; }
            if (String.IsNullOrEmpty(Placeholder)) { Placeholder = ""; }
            
            txt_control.Attributes.Add("placeholder", Placeholder);
        }

        public String LoadIcon() {
            String CreateIcon = "";
            if (String.IsNullOrEmpty(Icon)) { Icon = ""; }
            switch (Icon.ToUpper()) {
                case "EMAIL": {

                        CreateIcon = "ni ni-email-83";
                        break;
                }
                case "PASSWORD": {
                        CreateIcon = "ni ni-lock-circle-open";
                        break;
                }
                default: {
                        CreateIcon = "ni ni-email-83";
                        break;
                }
            }

            return CreateIcon;
        }
        
    }
}