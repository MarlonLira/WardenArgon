using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Dropdown {
    public partial class DropdownUsc : BaseUsc {

        public class NewItem {
            public String Nome { get; set; }
            public String Value { get; set; }
        }

        public List<NewItem> NewItemList { get; set; }


        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

        public String SelectedValue { get { return this.dd_control.SelectedValue; } }
        public String SelectedNome { get { return Convert.ToString(this.dd_control.SelectedItem); } }

        public Boolean Clear {
            set {
                if (value == true) {
                    dd_control.Items.Clear();
                }
            }
        }

        public void ClearItemList() {
            dd_control.Items.Clear();

        }

        public void LoadDataSource(List<NewItem> NewItemList) {
            ClearItemList();
            try {

                if (NewItemList != null) {

                    foreach (NewItem Item in NewItemList) {
                        dd_control.Items.Add(Item.Nome);
                        dd_control.DataValueField = Item.Value;
                    }
                }

            } finally {

            }
        }

        public void LoadDataSource(NewItem[] Itens) {
            ClearItemList();
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