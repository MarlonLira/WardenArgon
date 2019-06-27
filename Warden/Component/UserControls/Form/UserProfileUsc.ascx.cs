using System;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;

namespace Warden.Component.UserControls.Form {
    public partial class UserProfileUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
        }

        public Boolean IsReadOnly {
            set {
                txt_cep.ReadOnly = value;
                txt_data.ReadOnly = value;
                txt_email.ReadOnly = value;
                txt_empresa.ReadOnly = value;
                txt_endereco.ReadOnly = value;
                txt_etapa.ReadOnly = value;
                txt_matricula.ReadOnly = value;
                txt_nome.ReadOnly = value;
                txt_observacao.ReadOnly = value;
                txt_professor.ReadOnly = value;
            }
        }

        public void LoadForm(AlunoPst AlunoEdit) {
            AlunoPst Aluno;
            try {
                Aluno = AlunoEdit;

                txt_matricula.Text = Aluno.Codigo;
                txt_nome.Text = Aluno.Nome;
                txt_empresa.Text = Aluno.Empresa.Nome;
                txt_endereco.Text = Aluno.Endereco;
                txt_cep.Text = Aluno.Cep;
                txt_email.Text = Aluno.Email;
                txt_observacao.Text = "Aluno está na 2º etapa concluida, com a 3ª etapa marcada para o dia 26/06/2019 com o professor fulano.";
                txt_data.Text = DateTime.Now.ToShortDateString();
                txt_etapa.Text = "2º Etapa";
                txt_professor.Text = "fulano";
                lbl_limite_acesso.Text = "Dt.limite Acesso: " + Aluno.DataLimiteAcesso.ToShortDateString();
                lbl_plano.Text = "Plano: " + Aluno.ContratoObservacao;
                lbl_aluno.Text = Aluno.Nome;

            } catch (Exception Err) {

            }
            
        }

    }
}