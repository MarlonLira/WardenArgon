using System;
using System.Web.UI;

namespace Warden.Component.UserControls.BioImpedancia {
    public partial class BioImpedanciaUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            btn_confirmar.BtnControl_Click += new EventHandler(btnConfirmar_Click);
        }

        public void btnConfirmar_Click(object sender, EventArgs e) {

        }
    }
}