using System;
using System.Data;
using System.Web.UI;
using Warden.Component.Common.Table;

namespace Warden.Views {
    public partial class teste : Page {
        protected void Page_Load(object sender, EventArgs e) {
            Table();
        }

        public void Table() {

            DataTable Table = new DataTable();

            Table.Columns.Add("Column1");
            Table.Columns.Add("Column2");
            Table.Columns.Add("Column3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            Table.Rows.Add("Teste", "Teste2", "Teste3");
            tbl_teste.Colunas = new String[] { "Column1", "Column2", "Column3" };
            tbl_teste.LoadDataSource(Table);

        }
    }
}