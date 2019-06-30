using System;

namespace Warden.Component.Common.Button {
    public partial class MenuButtonUsc : BaseUsc {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

        public String Title { get; set; }
        public String Description { get; set; }
        
    }
}