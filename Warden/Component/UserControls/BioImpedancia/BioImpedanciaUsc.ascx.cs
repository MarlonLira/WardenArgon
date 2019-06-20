using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Business.Classes.Administracao;
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
            AlunoPst Aluno = (AlunoPst)Session["Aluno"];
            AlunoBioimpedanciaPst Bioimpedancia = new AlunoBioimpedanciaPst();
            String CurrentDate = DateTime.Now.ToShortDateString();
            if (Aluno == null) {

            }

            try {
                Bioimpedancia.Operador = new FuncionarioPst() { Id = Global.Funcionario.Id};
                Bioimpedancia.Aluno = new AlunoPst() { Id = Aluno.Id };
                Bioimpedancia.Empresa = new EmpresaPst() { Id = Aluno.Empresa.Id };

                Bioimpedancia.Auditoria = "INCLUIR - " + Global.Funcionario.Usuario + " - " + CurrentDate;
                Bioimpedancia.Imc = Convert.ToInt64(txt_imc.Text);
                Bioimpedancia.GorduraCorporal = Convert.ToInt64(txt_gordura.Text);
                Bioimpedancia.GorduraVisceral = Convert.ToInt64(txt_visceral.Text);
                Bioimpedancia.IdadeCorporal = Convert.ToInt64(txt_bioIdade.Text);
                Bioimpedancia.MassaMuscular = Convert.ToInt64(txt_massa.Text);
                Bioimpedancia.MetabolismoBasal = Convert.ToInt64(txt_metabolismo.Text);
                Bioimpedancia.Status = "AT";
                
                Bioimpedancia.Incluir();
            } catch (Exception Err) {
                lbl_erro.Style.Add("color", "red");
                lbl_erro.Text = Err.Message + " - " + Err.InnerException;
            }

        }
    }
}