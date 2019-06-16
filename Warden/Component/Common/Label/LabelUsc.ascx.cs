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

        public String FontSize {get; set;}
    
        public void LoadLabel() {
            lbl_control.Attributes.Add("Font-Size", FontSize);
        }
    }
}