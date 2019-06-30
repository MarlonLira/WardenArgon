using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Core.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;

namespace Warden.Component.UserControls.Avatar {
    public partial class AvatarUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(Request.QueryString["Matricula"])) {
                SelectedValue();
            }
        }

        public AlunoPst Aluno;

        public void SelectedValue() {
            
            string AlunoMatricula = Request.QueryString["Matricula"];

            string AlunoEmpresa = Request.QueryString["Empresa"];

            if (!String.IsNullOrEmpty(AlunoMatricula)) {
                CarregarAluno(AlunoMatricula, AlunoEmpresa);
            }
        }


        private void CarregarAluno(String Matricula, String Empresa) {
            DataTable Table = new DataTable();
            AlunoPst Aluno;

            Aluno = new AlunoPst() { Filters = new List<BaseMdl.Filter>() };
            Aluno.Filters.Add(new BaseMdl.Filter("[status] = 'AT'", CompareModeTypes.EXPRESSION));
            if (!String.IsNullOrEmpty(Matricula)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[codigo]", CompareModeTypes.EQUAL, Matricula));
            }
            if (!String.IsNullOrEmpty(Empresa)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[empresa_id]", CompareModeTypes.EQUAL, Empresa));
            }

            Table = Aluno.Pesquisar();

            if (Table.Rows.Count > 0) {

                foreach (DataRow Row in Table.Rows) {
                    Aluno.Preencher(Row);

                    Session.Add("Aluno", Aluno);
                }

                Response.Redirect("~/views/fitness/Aluno.aspx");
            }
        }
    }
}