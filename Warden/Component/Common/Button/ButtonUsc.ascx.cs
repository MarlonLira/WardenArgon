using System;
using System.Web.UI;

namespace Warden.Component.Common.Button {
    public partial class ButtonUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            LoadButton();
        }
        //public event EventHandler BtnControl_Click;

        public delegate void OnClickEvent();
        public event OnClickEvent OnClick;

        //public String OnClick { get; set; }
        public String Style { get; set; }
        public String Type { get; set; }

        public String Text {
            get { return btn_control.Text; }
            set { btn_control.Text = value; }
        }

        public void LoadButton() {
            String CreateClass = "";
            if (String.IsNullOrEmpty(Style)) { Style = ""; }

            switch (Style.ToUpper()) {
                case "OUTLINE": {

                    CreateClass = "btn btn-outline-default";
                    break;
                }
                case "DEFAULT": {
                    CreateClass = "btn btn-default";
                    break;
                }
                default: {
                    CreateClass = "btn btn-outline-default";
                    break;
                }
            }

            btn_control.Attributes.Add("class", CreateClass);
        }

        protected void btn_control_Click(object sender, EventArgs e) {
            try {
                if (OnClick != null) {
                    OnClick();
                }
            } catch (Exception Except) {

            }
        }
    }
}