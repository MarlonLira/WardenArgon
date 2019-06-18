using System;
using System.Web.UI;

namespace Warden.Component.Common.Label {
    public partial class LabelUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            LoadLabel();
        }

        public String Text {
            get { return lbl_control.Text; }
            set { this.lbl_control.Text = value; }
        }

        public Int32 FontSize {
            set { lbl_control.Font.Size = new System.Web.UI.WebControls.FontUnit(value) ; }
        }

        public Boolean Bold {
            set { lbl_control.Font.Bold = value; }
        }
    
        public void LoadLabel() {
           
        }
    }
}