using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Button {
    public partial class RadioButtonUsc : BaseUsc {

        public class Item {
            public String Text { get; set; }
            public String Value { get; set; }
            
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }
        
        public void LoadDataSource(Item[] Itens) {

            foreach (Item Item in Itens) {
               rb_control.Items.Add(Item.Text);
            }
        }
       
        public String Title {
            get { return lbl_control.Text; }
            set { lbl_control.Text = value; }
        }
        public void SelectValue(Boolean Value) {
            if (Value == true) {
                rb_control.SelectedIndex = 0;
            }else if (Value == false) {
                rb_control.SelectedIndex = 1;
            }
        }

        public Boolean ReadOnly {
            set { rb_control.Enabled = value; }
        }

        public Boolean BoolValue {
            get {
                Boolean CheckValue = false;

                if (!String.IsNullOrEmpty(Text)) {

                    if (Text == "Sim") {
                        CheckValue = true;
                    }else if (Text == "Não") {
                        CheckValue = false;
                    }
                }

                return CheckValue;
            } }
        public String Text {
            get {
                String SelectedText = "";
                if (rb_control.SelectedIndex > -1) {
                    SelectedText = rb_control.SelectedItem.Text;
                }
                return SelectedText;
            }
        } 
        public String Value {
            get {
                String SelectValue = "";
                if (rb_control.SelectedIndex > -1) {
                    SelectValue = rb_control.SelectedValue;
                }
                return SelectValue;
            }
        }
    }
}