using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Table {
    public partial class TableUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) { LoadTable(); }
        }

        public void LoadTable() {
            DataTable Table;
            TableRow[] TableRow;
            if (Session["AlunoTable"] != null) {
                Table = (DataTable)Session["AlunoTable"];
                TableRow = TableLoad(Table);
                tbl_control.Rows.AddRange(TableRow);
            }
        }

        public TableRow[] TableLoad(DataTable TableEdit) {
            System.Web.UI.WebControls.Table WebTable;
            TableCell WebCell;
            TableRow WebRow;
            TableRow[] WebRow2;

            try {

                WebTable = new System.Web.UI.WebControls.Table();
                WebRow = new TableRow();

                WebRow2 = new TableRow[TableEdit.Rows.Count];
                int count = 0;
                foreach (DataRow Rows in TableEdit.Rows) {

                    foreach (object Cells in Rows.ItemArray) {
                        WebCell = new TableCell();
                        WebCell.Text = Cells.ToString();

                        WebRow.Cells.Add(WebCell);
                    }

                    WebTable.Rows.Add(WebRow);
                    WebRow2[count] = WebRow;
                    WebRow = new TableRow();
                    count++;
                }
            } catch (Exception Err) {
                WebTable = null;
                WebRow2 = null;
            }

            return WebRow2;
        }

    }
}