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
        public String Text {
            get { return txt_control.Text; }
            set { this.txt_control.Text = value; }
        }

        
        public String Style { get; set; }
        public String Icon { get; set; }
        public String Placeholder { get; set; }

        public TextBoxMode TextMode {
            get {
                return txt_control.TextMode;
            }
            set {
                txt_control.TextMode = value;
            }
        }

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
                case "USER": {
                        CreateIcon = "ni ni-single-02";
                        break;
                }
                case "RUN": {
                        CreateIcon = "ni ni-user-run";
                        break;
                }
                case "WAVE": {
                        CreateIcon = "ni ni-sound-wave";
                        break;
                }
                case "GEAR": {
                        CreateIcon = "ni ni-settings-gear-65";
                        break;
                }
                case "SETTINGS": {
                        CreateIcon = "ni ni-settings";
                        break;
                }
                case "SATISFIED": {
                        CreateIcon = "ni ni-satisfied";
                        break;
                }
                case "COLLECTION": {
                        CreateIcon = "ni ni-collection";
                        break;
                }
                case "BADGE": {
                        CreateIcon = "ni ni-badge";
                        break;
                }
                case "ATOM": {
                        CreateIcon = "ni ni-atom";
                        break;
                }
                case "SUPPORT": {
                        CreateIcon = "ni ni-support-16";
                        break;
                }
                case "PHONE": {
                        CreateIcon = "ni ni-headphones";
                        break;
                }
                case "DATE": {
                        CreateIcon = "ni ni-calendar-grid-58";
                        break;
                }
                case "GENDER": {
                        CreateIcon = "fa fa-venus-mars";
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