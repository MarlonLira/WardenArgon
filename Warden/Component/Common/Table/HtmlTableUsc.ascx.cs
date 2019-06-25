using System;
using System.Data;
using System.Web.UI;

namespace Warden.Component.Common.Table {
    public partial class HtmlTableUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {

        }

        public String[] Colunas { get; set; }
        public Int16 Scale { get; set; }

        public void LoadDataSource(DataTable TableAux) {
            th_control.InnerHtml = TableLoad(Colunas, true);
            tb_control.InnerHtml = TableLoad(TableAux, true);
            tf_control.InnerHtml = TableLoad(Colunas, true);
            if (Scale <= 0) { Scale = 10; }
        }

        public String TableLoad(DataTable Table, Boolean IsHtml) {
            String TableHtml = "";
            String InitTr = "<tr>";
            String CloseTr = "</tr>";
            String InitTd = "<td>";
            String CloseTd = "</td>";

            foreach (DataRow Row in Table.Rows) {
                TableHtml += InitTr;

                foreach (var Cell in Row.ItemArray) {
                    TableHtml += InitTd + Convert.ToString(Cell) + CloseTd;
                }
                TableHtml += CloseTr;
            }
            return TableHtml;
        }

        public String TableLoad(String[] Colunas, Boolean IsHtml) {
            String TableHtml = "";
            String InitTr = "<tr>";
            String CloseTr = "</tr>";
            String InitTh = "<th>";
            String CloseTh = "</th>";

            TableHtml += InitTr;
            foreach (String Row in Colunas) {
                TableHtml += InitTh + Convert.ToString(Row) + CloseTh;
            }
            TableHtml += CloseTr;

            return TableHtml;
        }

    }
}