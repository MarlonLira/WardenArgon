using System;
using System.Collections.Generic;
using System.Data;
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
            CalendarEvent Agenda;
            String Obs = "";
            try {
                Aluno = AlunoEdit;
                Agenda = new CalendarEvent();
                Agenda = EventDAO.getEvents(Aluno.Id);

                if (Agenda.Etapa <= 0) {
                    Agenda.Etapa = 0;
                }
                if (Agenda.Etapa <= 0) {
                    Obs = "O Aluno não tem agendamento!";
                }else {
                    Obs = "Aluno está na " + Agenda.Etapa + "º etapa, marcada para o dia " + Agenda.DataAgendamento + " com o professor " + Agenda.OperadorNome + ".";
                }

                txt_matricula.Text = Aluno.Codigo;
                txt_nome.Text = Aluno.Nome;
                txt_empresa.Text = Aluno.Empresa.Nome;
                txt_endereco.Text = Aluno.Endereco;
                txt_cep.Text = Aluno.Cep;
                txt_email.Text = Aluno.Email;
                txt_observacao.Text = Obs;
                txt_data.Text = DateTime.Now.ToShortDateString();
                txt_etapa.Text = Agenda.Etapa + "º Etapa";
                txt_professor.Text = Agenda.OperadorNome;
                lbl_limite_acesso.Text = "Dt.limite Acesso: " + Aluno.DataLimiteAcesso.ToShortDateString();
                lbl_plano.Text = "Plano: " + Aluno.ContratoObservacao;
                lbl_aluno.Text = Aluno.Nome;

            } catch (Exception Err) {

            }
            
        }

        public void LoadForm(DataRow Row) {
            AlunoPst Aluno;
            CalendarEvent Agenda;
            try {
                Aluno = new AlunoPst();
                Agenda = new CalendarEvent();
                Aluno.Preencher(Row);
                Agenda = EventDAO.getEvents(Convert.ToInt32(Row["aluno_id"]));

                if (Agenda.Etapa <= 0) {
                    Agenda.Etapa = 0;
                }

                txt_matricula.Text = Aluno.Codigo;
                txt_nome.Text = Aluno.Nome;
                txt_empresa.Text = Aluno.Empresa.Nome;
                txt_endereco.Text = Aluno.Endereco;
                txt_cep.Text = Aluno.Cep;
                txt_email.Text = Aluno.Email;
                txt_observacao.Text = "Aluno está na " + Agenda.Etapa + "º etapa, marcada para o dia " + Agenda.DataAgendamento + " com o professor " + Agenda.OperadorNome + ".";
                txt_data.Text = DateTime.Now.ToShortDateString();
                txt_etapa.Text = Agenda.Etapa + "º Etapa";
                txt_professor.Text = Agenda.OperadorNome;
                lbl_limite_acesso.Text = "Dt.limite Acesso: " + Aluno.DataLimiteAcesso.ToShortDateString();
                lbl_plano.Text = "Plano: " + Aluno.ContratoObservacao;
                lbl_aluno.Text = Aluno.Nome;

            } catch (Exception Err) {

            }

        }

    }
}