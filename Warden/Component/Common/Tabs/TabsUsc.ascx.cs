using System;
using System.Data;
using System.Web.UI;

namespace Warden.Component.Common.Tabs {
    public partial class TabsUsc : UserControl {

        public delegate void OnFindEvent(DataRow SelectedRow);
        public event OnFindEvent OnFind;

        protected void Page_Load(object sender, EventArgs e) {
            this.UserSearchFormUsc.OnFind += UserSearchFormUsc_OnFind;
        }

        private void UserSearchFormUsc_OnFind(DataRow SelectedRow) {
            if(OnFind != null) {
                OnFind(SelectedRow);
            }
        }

    }
}