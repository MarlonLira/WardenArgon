using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Button {
    public partial class RadioButtonUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        public String Text { get; set; }
        public String Title { get; set; }

        public RadioButtonList Control {
            get { return rb_control; }
            set { rb_control = value; }
        }
        public String Itens { get; set; }

        public void LoadTitle() {
            String[] Title;
            if (!String.IsNullOrEmpty(Itens)) {
                Title = Itens.Split('/');
                foreach (String item in Title) {
                    rb_control.Items.Add(item);
                }
            } else {
                rb_control.Text = "Title";
            }
        }

        public void LoadTitle(String Array) {
            String[] Title;
            if (!String.IsNullOrEmpty(Array)) {
                Title = Array.Split('/');
                foreach (String item in Title) {
                    Control.Items.Add(item);
                }
            } else {
                Control.Text = "Title";
            }
        }
    }
}