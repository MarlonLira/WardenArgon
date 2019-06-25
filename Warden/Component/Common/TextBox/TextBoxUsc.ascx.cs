using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.TextBox {
    public partial class TextBoxUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            LoadTextBox();
        }
        public String Text {
            get { return this.txt_control.Text; }
            set { this.txt_control.Text = value; }
        }

        public Boolean ReadOnly { set { txt_control.ReadOnly = value; } }
        public String Style { get; set; }
        public String Icon { get; set; }
        public String Placeholder { get; set; }
        public Int32 Size { get; set; }
        public String Mode { get; set; }
        public Boolean IsModified { get; set; }
        

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

        public String LoadMode() {
            String NewMode = "";
            if (String.IsNullOrEmpty(Mode)) {
                NewMode = "md";
            } else {

                switch (Mode.ToUpper()) {
                    case "SMALL": {
                        NewMode = "md";
                        break;
                    }
                    case "MEDIUM": {
                        NewMode = "md";
                        break;
                    }
                    case "LARGER": {
                        NewMode= "lg";
                        break;
                    }
                }
            }

            return NewMode;
        }

        public Int32 LoadSize() {
            Int32 NewSize;
            if (Size <= 0) {
                NewSize = 3;
            } else {
                NewSize = Size;
            }
            return NewSize;
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
                case "WORLD": {
                        CreateIcon = "ni ni-world";
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
                case "CITY": {
                        CreateIcon = "ni ni-istanbul";
                        break;
                }
                case "CEP": {
                        CreateIcon = "ni ni-square-pin";
                        break;
                }
                case "GENDER": {
                        CreateIcon = "fa fa-venus-mars";
                        break;
                }
                case "COMPANY": {
                        CreateIcon = "fa fa-building";
                        break;
                }
                case "ADRESS": {
                        CreateIcon = "fa fa-map-marker";
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