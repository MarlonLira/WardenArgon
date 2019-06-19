using System;
using System.Web.UI;
using Warden.Component.Common.Button;

namespace Warden.Views.Fitness {
    public partial class Graficos : Page {
        protected void Page_Load(object sender, EventArgs e) {
            btnteste.OnClick += new ButtonUsc.OnClickEvent (Btnteste_OnClick);
        }

        private void Btnteste_OnClick() {
            Int16 kk = 15;
            throw new NotImplementedException();
        }
    }
}