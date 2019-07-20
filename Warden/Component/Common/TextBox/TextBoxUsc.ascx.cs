using System;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.TextBox {
    public partial class TextBoxUsc : BaseUsc {

        #region Eventos
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            LoadTextBox();
        }

        #endregion

        #region Atributos

        public Boolean ReadOnly { set { this.pnl_Control.Enabled = value; } } 
        public String Style { get; set; }
        public String Placeholder { get; set; }
        public Int32 Size { get; set; }
        public String Mode { get; set; }
        public Boolean IsModified { get; set; }
        public Boolean IsLabel { get; set; }
        public String Label { set { lbl_control.Text = value; } }
        public Int32 LabelSize { set { lbl_control.FontSize = value; } }
        public Int32 TextRow { set { this.txt_control.Rows = value; } }
        public Boolean IsHtml { get; set; }
        public Boolean IsTextArea { get; set; }
        public String Title { get; set; }
        public String ComponentId { get; set; }
        public TextBoxMode TextMode {
            get {
                return txt_control.TextMode;
            }
            set {
                txt_control.TextMode = value;
            }
        }

        public String Value { get; set; }
        public String Text {
            get { return this.txt_control.Text; }
            set { this.txt_control.Text = value; }
        }

        #endregion

        #region Metodos

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

        #endregion
    }
}