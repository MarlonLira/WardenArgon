using System;
using System.Web.UI;

namespace Warden.Component.Common.Button {
    public partial class SquareButtonUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {

        }

        public delegate void OnClickEvent();
        public event OnClickEvent OnClick;

        public String Icon { get; set; }
        public Boolean IsButton { get; set; }
        public String BtnText {
            get { return btn_control.Text; }
            set { this.btn_control.Text = value; }
        }

        public Int32 TitleSize { set { lbl_title.FontSize = value; } } 
        public Int32 CategorySize { set { lbl_category.FontSize = value; } }

        public String Title {
            get { return lbl_title.Text; }
            set { this.lbl_title.Text = value; }
        }

        public String Category {
            get { return lbl_category.Text; }
            set { this.lbl_category.Text = value; }
        }

        protected void btn_control_Click(object sender, EventArgs e) {
            try {
                if (OnClick != null) {
                    OnClick();
                }
            } catch (Exception Except) {

            }
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
                        CreateIcon = "";
                        break;
                    }
            }

            return CreateIcon;
        }
    }
}