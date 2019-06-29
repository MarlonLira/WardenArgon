using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Core.Classes.Model;
using Warden.Component.Common.Button;
using Warden.Component.Common.Table;

namespace Warden.Component.UserControls.Form {
    public partial class UserSearchFormUsc : UserControl {

        public delegate void OnFindEvent(DataRow SelectedRow);
        public event OnFindEvent OnFind;

        protected void Page_Load(object sender, EventArgs e) {
            btn_pesquisar.OnClick += new ButtonUsc.OnClickEvent(BtnPesquisar_Click);
        }

        public String TitleText { set { this.lbl_title_control.Text = value; } }
        public String CategoryText { set { this.lbl_category_control.Text = value; } }

        protected void BtnPesquisar_Click() {
            if (!String.IsNullOrEmpty(txt_matricula.Text) || !String.IsNullOrEmpty(txt_nome.Text)) {
                CarregarAluno();
            }
        }

        private void CarregarAluno() {
            DataTable Table = new DataTable();
            AlunoPst Aluno;
            TableUsc TableUsc;

            Aluno = new AlunoPst() { Filters = new List<BaseMdl.Filter>() };
            Aluno.Filters.Add(new BaseMdl.Filter("[status] = 'AT'", CompareModeTypes.EXPRESSION));
            if (!String.IsNullOrEmpty(txt_matricula.Text)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[codigo]", CompareModeTypes.EQUAL, txt_matricula.Text));
            }
            if (!String.IsNullOrEmpty(txt_nome.Text)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[nome] COLLATE Latin1_General_CI_AI", CompareModeTypes.LIKE, txt_nome.Text + "%"));
            }

            Table = Aluno.Pesquisar();
            Session.Add("Table", Table);


            if (Table.Rows.Count == 1) {
                //Aluno.Preencher(Table.Rows[0]);
                if (OnFind != null) {
                    OnFind(Table.Rows[0]);
                }
            } else {
                TableUsc = tbl_control;
                TableUsc.TableColumns = new List<TableUsc.TableColumnUsc>();
                TableUsc.TableColumns.Add(new TableUsc.TableColumnUsc() { ColumText = "Matrícula", ColumName = "codigo" });
                TableUsc.TableColumns.Add(new TableUsc.TableColumnUsc() { ColumText = "Nome", ColumName = "nome" });
                TableUsc.TableColumns.Add(new TableUsc.TableColumnUsc() { ColumText = "Dt.Limite", ColumName = "data_limite_acesso", ColumFormat = "dd/MM/yyyy" });
                TableUsc.HeaderCellsBold = true;
                TableUsc.BodyCellsBold = false;
                TableUsc.LoadDataSource(Table);
            }

        }
    }
}