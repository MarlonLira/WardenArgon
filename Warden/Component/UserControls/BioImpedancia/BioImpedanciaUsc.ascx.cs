using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Warden.Component.Common.Button;

namespace Warden.Component.UserControls.BioImpedancia {
    public partial class BioImpedanciaUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            btn_confirmar.OnClick += new ButtonUsc.OnClickEvent(btnConfirmar_Click);
        }

        public void btnConfirmar_Click() {
            SalvarBioimpedancia();
        }

        public void SalvarBioimpedancia() {
            
            /*AlunoBioimpedanciaPst Bioimpedancia = new AlunoBioimpedanciaPst();
            Bioimpedancia.Aluno = new AlunoPst();
            Bioimpedancia.Empresa = new Brasdat.Gestor.Library.Business.Classes.Administracao.EmpresaPst();

            Bioimpedancia.Imc = Convert.ToInt64(txt_imc.Text);
            Bioimpedancia.GorduraCorporal = Convert.ToInt64(txt_gordura.Text);
            Bioimpedancia.GorduraVisceral = Convert.ToInt64(txt_visceral.Text);
            Bioimpedancia.IdadeCorporal = Convert.ToInt64(txt_bioIdade.Text);
            Bioimpedancia.MassaMagra = Convert.ToInt64(txt_massa.Text);
            Bioimpedancia.MetabolismoBasal = Convert.ToInt64(txt_metabolismo.Text);
            Bioimpedancia.Aluno.Id = 3171;
            Bioimpedancia.Empresa.Id = 1;
            Bioimpedancia.Incluir();*/

        }
    }
}