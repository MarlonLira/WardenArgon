using System;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Dropdown {
    public partial class DropdownUsc : BaseUsc {

        public class NewItem {
            public String Nome { get; set; }
            public String Value { get; set; }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

        public String SelectedValue { get { return this.dd_control.SelectedValue; } }
        public String SelectedNome { get { return Convert.ToString(this.dd_control.SelectedItem); } }


        public void LoadDataSource(NewItem[] Itens) {

            try {

                if (Itens != null) {

                    foreach (NewItem Item in Itens) {
                        dd_control.Items.Add(Item.Nome);
                        dd_control.DataValueField = Item.Value;
                    }
                }

            } finally {

            }

        }

    }
}