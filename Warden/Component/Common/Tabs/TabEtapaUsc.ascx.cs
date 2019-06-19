using System;
using System.Web.UI;
using Warden.Component.Common.Button;

namespace Warden.Component.Common.Tabs {
    public partial class TabEtapaUsc : UserControl {

        protected void Page_Load(object sender, EventArgs e) {

            btn_anamnese_salvar.OnClick += new ButtonUsc.OnClickEvent(BtnAnamneseSalvar_Click);
            LoadEtapas();
        }

        protected void BtnAnamneseSalvar_Click() {
            SalvarAnamnese();
        }

        private void SalvarAnamnese() {
            RadioButtonUsc Q1 = Question1;

            String Teste = Question1.Value;
        }

        public void LoadEtapas() {
            RadioButtonUsc.Item Item1 = new RadioButtonUsc.Item() { Text = "Sim"};
            RadioButtonUsc.Item Item2 = new RadioButtonUsc.Item() { Text = "Não"};
            RadioButtonUsc.Item [] Itens = new RadioButtonUsc.Item[] { Item1, Item2 };

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
