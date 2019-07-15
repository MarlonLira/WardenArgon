using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Core.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using Warden.Component.Common.Button;

namespace Warden.Component.Common.Tabs {
    public partial class TabEtapaUsc : BaseUsc {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            btn_anamnese_salvar.OnClick += new ButtonUsc.OnClickEvent(BtnAnamneseSalvar_Click);
            LoadEtapas();

            if (Session["Aluno"] != null) {
                AlunoEdit = (AlunoPst)Session["Aluno"];
            }
        }

        public AlunoPst AlunoEdit;

        protected void BtnAnamneseSalvar_Click() {
            SalvarAnamnese();
        }
        private void PreencherAnamnese(DataRow Row) {
            
            Question1.SelectValue(Convert.ToBoolean(Row["problema_cardiaco"]));
            Question2.SelectValue(Convert.ToBoolean(Row["dor_peito_atividade"]));
            Question3.SelectValue(Convert.ToBoolean(Row["dor_peito_ultimo_mes"]));
            Question4.SelectValue(Convert.ToBoolean(Row["perda_consciencia"]));
            Question5.SelectValue(Convert.ToBoolean(Row["problema_osseo"]));
            Question6.SelectValue(Convert.ToBoolean(Row["medicacao"]));
            Question7.SelectValue(Convert.ToBoolean(Row["pressao_arterial"]));
            Question8.SelectValue(Convert.ToBoolean(Row["impedimento_atividade"]));
            Question9.SelectValue(Convert.ToBoolean(Row["cirurgia"]));
            Question10.SelectValue(Convert.ToBoolean(Row["comprometer_saude_atividade"]));
            pnl_question.Enabled = false;

        }

        private Boolean ProcurarAnamnese(AlunoPst Aluno) {
            AlunoParqPst Parq = null;
            DataTable Table;
            Boolean Result = false;
            try {
                Parq = new AlunoParqPst();
                Parq.Filters = new List<BaseMdl.Filter>();
                Parq.Filters.Add(new BaseMdl.Filter("[status]", CompareModeTypes.EQUAL, "AT"));
                Parq.Filters.Add(new BaseMdl.Filter("[empresa_id]", CompareModeTypes.EQUAL, Global.Empresa.Id));
                Parq.Filters.Add(new BaseMdl.Filter("[aluno_id]", CompareModeTypes.EQUAL, Aluno.Id));
                Table = Parq.Pesquisar();

                if (Table.Rows.Count > 0) {
                    Result = true;
                    foreach (DataRow Row in Table.Rows) {
                        PreencherAnamnese(Row);
                        break;
                    }
                }

            } catch (Exception Err) {

            }
            return Result;
        }
        private void SalvarAnamnese() {
            AlunoParqPst Parq = null;
            String CurrentDate = DateTime.UtcNow.AddHours(-3).ToLongDateString();

            try {
                Parq = new AlunoParqPst();
                Parq.AlunoAgenda = new AlunoAgendaPst();

                if (Session["Aluno"] != null) {
                    Parq.Empresa = Global.Empresa;
                    Parq.Operador = Global.Funcionario;
                    Parq.Aluno = AlunoEdit;
                    Parq.Status = "AT";
                    Parq.AlunoAgenda.Id = 0;
                    Parq.ProblemaCardiaco = Question1.BoolValue;
                    Parq.DorPeitoAtividade = Question2.BoolValue;
                    Parq.DorPeitoUltimoMes = Question3.BoolValue;
                    Parq.PerdaConsciencia = Question4.BoolValue;
                    Parq.ProblemaOsseo = Question5.BoolValue;
                    Parq.Medicacao = Question6.BoolValue;
                    Parq.PressaoArterial = Question7.BoolValue;
                    Parq.ImpedimentoAtividade = Question8.BoolValue;
                    Parq.Cirugia = Question9.BoolValue;
                    Parq.ComprometerSaudeAtividade = Question10.BoolValue;
                    Parq.Auditoria = Parq.Operador.Usuario  + CurrentDate + " - INCLUIR";
                    Parq.Incluir();
                }

            }catch(Exception Err) {

            } finally {
                Parq = null;
            }
        }

        public void LoadEtapas() {
            AlunoEdit = (AlunoPst)Session["Aluno"];

            RadioButtonUsc.Item Item1 = new RadioButtonUsc.Item() { Text = "Sim" };
            RadioButtonUsc.Item Item2 = new RadioButtonUsc.Item() { Text = "Não" };
            RadioButtonUsc.Item[] Itens = new RadioButtonUsc.Item[] { Item1, Item2 };
           
        
            if (!IsPostBack) {

                
                Question1.Title = Question(1);
                Question1.LoadDataSource(Itens);

                Question2.Title = Question(2);
                Question2.LoadDataSource(Itens);

                Question3.Title = Question(3);
                Question3.LoadDataSource(Itens);

                Question4.Title = Question(4);
                Question4.LoadDataSource(Itens);

                Question5.Title = Question(5);
                Question5.LoadDataSource(Itens);

                Question6.Title = Question(6);
                Question6.LoadDataSource(Itens);

                Question7.Title = Question(7);
                Question7.LoadDataSource(Itens);

                Question8.Title = Question(8);
                Question8.LoadDataSource(Itens);

                Question9.Title = Question(9);
                Question9.LoadDataSource(Itens);

                Question10.Title = Question(10);
                Question10.LoadDataSource(Itens);

                if (AlunoEdit != null) {
                    ProcurarAnamnese(AlunoEdit);
                }
                calendar_control.Calendar = new Calendar.CalendarUsc.CalendarDay();
                calendar_control.Calendar.Date = DateTime.Now;
                calendar_control.LoadCalendar();
            }

        }

        //public Int16 NumQuestion { get; set; }

        public String Question(Int16 NumQuestion) {
            String SelectedQuestion = "Questão não encontrada";
            switch (NumQuestion) {
                case 1: {
                        SelectedQuestion = "1. Algum médico já disse que você possui algum problema de coração ou pressão arterial, " +
                            "e que somente deveria realizar atividades física supervisionado por profissionais de saúde ?";
                        break;
                    }
                case 2: {
                        SelectedQuestion = "2. Você sente dores no peito e/ou tórax quando caminha ou pratica atividade física ?";
                        break;
                    }
                case 3: {
                        SelectedQuestion = "3. No último mês, você sentiu dores no peito, independente da prática de atividades física?";
                        break;
                    }
                case 4: {
                        SelectedQuestion = "4. Você apresenta algum desequilíbrio devido a tontura e/ou perda de consciência ?";
                        break;
                    }
                case 5: {
                        SelectedQuestion = "5. Você possui algum problema ósseo ou articular que pode ser afetado ou agravado em " +
                            "consequência de alteração em sua atividade física ?";
                        break;
                    }
                case 6: {
                        SelectedQuestion = "6. Você toma atualmente algum tipo de medicação de uso contínuo ?";
                        break;
                    }
                case 7: {
                        SelectedQuestion = "7. Você realiza algum tipo de tratamento médico para pressão arterial e/ou problemas cardíacos ?";
                        break;
                    }
                case 8: {
                        SelectedQuestion = "8. Você realiza algum tipo de tratamento médico continuo, que possa ser afetado ou prejudicado com a atividade física ?";
                        break;
                    }
                case 9: {
                        SelectedQuestion = "9. Você já se submeteu a algum tipo de cirurgia que comprometa de alguma forma a atividade física ?";
                        break;
                    }
                case 10: {
                        SelectedQuestion = "10. Você sabe de alguma razão pela qual a atividade física possa eventualmente comprometer sua saúde ?";
                        break;
                    }
            }
            return SelectedQuestion;
        }

        
    }
}
