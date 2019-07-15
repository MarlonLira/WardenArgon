using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;

namespace Warden.Component.UserControls.Form {
    public partial class UserFormUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(BtnText)) {
                BtnText = "Editar";
            }

            if (Session["MarcarProxEtapa"] != null) {
                LoadForm((AlunoPst)Session["MarcarProxEtapa"]);
            }
        }

        public String BtnText {
            get { return this.btn_confirmar.Text; }
            set { this.btn_confirmar.Text = value; }
        }

        public void LoadForm(AlunoPst AlunoEdit) {
            AlunoPst Aluno;
            DateTime CurrentDate = DateTime.Now;
            try {
                Aluno = AlunoEdit;

                txt_nome.Text = Aluno.Nome;
                txt_email.Text = Aluno.Email;
                txt_idade.Text = BirthDate(CurrentDate, Aluno.DataNascimento);
                txt_data.Text = CurrentDate.ToShortDateString();
                txt_sexo.Text = Aluno.Sexo;
                txt_tel.Text = Aluno.TelCelular;

            } catch(Exception Err) {

            }
            
        }

        public String BirthDate(DateTime DataAtual, DateTime DataNascimento) {
            Int32 Year;
            String Result = "";

            Year = Convert.ToInt32(DateTime.Now.Year - DataNascimento.Year);
            
            if(DateTime.Now.Month > DataNascimento.Month) {
                Result = Convert.ToString(Year);
            } else if(DateTime.Now.Month == DataNascimento.Month) {
                if (DateTime.Now.Day >= DataNascimento.Day) {
                    Result = Convert.ToString(Year);
                }else {
                    Result = Convert.ToString(Year - 1);
                }

            } else {
                Result = Convert.ToString(Year - 1);
            }

            return Result;
        }
    }
}