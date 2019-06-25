using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Button {
    public partial class RadioButtonUsc : UserControl {

        public class Item {
            public String Text { get; set; }
            public String Value { get; set; }
            
        } 
        protected void Page_Load(object sender, EventArgs e) {
            
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

        public String Value {
            get {
                return rb_control.SelectedItem.Text;
            }
        }
    }
}