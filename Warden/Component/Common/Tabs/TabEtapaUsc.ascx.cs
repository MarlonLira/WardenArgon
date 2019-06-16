using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Warden.Component.Common.Button;

namespace Warden.Component.Common.Tabs {
    public partial class TabEtapaUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            LoadEtapas();
        }

        public void LoadEtapas() {

            

        }

        //public Int16 NumQuestion { get; set; }

        public String Question(Int16 NumQuestion) {
            String SelectedQuestion = "Questão não encontrada";
            switch (NumQuestion) {
                case 1: {
                        SelectedQuestion = "Algum médico já disse que você possui algum problema de coração ou pressão arterial, " +
                            "e que somente deveria realizar atividades física supervisionado por profissionais de saúde ?";
                        break;
                    }
                case 2: {
                        SelectedQuestion = "Você sente dores no peito e/ou tórax quando caminha ou pratica atividade física ?";
                        break;
                    }
                case 3: {
                        SelectedQuestion = "No último mês, você sentiu dores no peito, independente da prática de atividades física?";
                        break;
                    }
                case 4: {
                        SelectedQuestion = "Você apresenta algum desequilíbrio devido a tontura e/ou perda de consciência ?";
                        break;
                    }
                case 5: {
                        SelectedQuestion = "Você possui algum problema ósseo ou articular que pode ser afetado ou agravado em " +
                            "consequência de alteração em sua atividade física ?";
                        break;
                    }
                case 6: {
                        SelectedQuestion = "Você toma atualmente algum tipo de medicação de uso contínuo ?";
                        break;
                    }
                case 7: {
                        SelectedQuestion = "Você realiza algum tipo de tratamento médico para pressão arterial e/ou problemas cardíacos ?";
                        break;
                    }
                case 8: {
                        SelectedQuestion = "Você realiza algum tipo de tratamento médico continuo, que possa ser afetado ou prejudicado com a atividade física ?";
                        break;
                    }
                case 9: {
                        SelectedQuestion = "Você já se submeteu a algum tipo de cirurgia que comprometa de alguma forma a atividade física ?";
                        break;
                    }
                case 10: {
                        SelectedQuestion = "Você sabe de alguma razão pela qual a atividade física possa eventualmente comprometer sua saúde ?";
                        break;
                    }
            }
            return SelectedQuestion;
        }
    }
}
