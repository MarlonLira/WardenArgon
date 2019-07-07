using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Table {

    public partial class TableUsc : BaseUsc {

        public class TableColumnUsc {

            public String ColumText { get; set; }
            public String ColumName { get; set; }
            public String ColumFormat { get; set; }

        }

        public List<TableColumnUsc> TableColumns { get; set; }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (Session["Table"] != null && IsTmk == true) {

                /*TableColumns = new List<TableUsc.TableColumnUsc>();
                TableColumns.Add(new TableUsc.TableColumnUsc() { ColumText = "Aluno", ColumName = "nome" });*/
                HeaderCellsBold = true;
                BodyCellsBold = false;

                /*LoadDataSource((DataTable)Session["Table"]);*/
            }
        }

        public Boolean HeaderCellsBold { set { tbh_control.Font.Bold = value; } }
        public Boolean BodyCellsBold { set { tbr_control.Font.Bold = value; } }
        public Boolean IsTmk { get; set; }

        public void LoadDataSource(DataTable TableEdit) {
            System.Web.UI.WebControls.Table WebTable;
            TableCell WebCell;
            TableRow WebRow;
            TableRow[] WebRow2;

            if (tbl_control.Rows.Count > 0) {
                //tbl_control.Rows.Clear();
                tbl_control.Rows.RemoveAt(1);
                tbh_control.Cells.Clear();
                
            }
            try {
                WebTable = new System.Web.UI.WebControls.Table();
                WebRow = new TableRow();

                if (this.TableColumns != null) {
                    foreach (TableColumnUsc Col in this.TableColumns) {

                        WebCell = new TableCell();
                        WebCell.Text = Col.ColumText;

                        tbh_control.Cells.Add(WebCell);
                    }
                }

                WebRow2 = new TableRow[TableEdit.Rows.Count];
                int count = 0;
                foreach (DataRow Rows in TableEdit.Rows) {

                    if (this.TableColumns != null) {

                        foreach (TableColumnUsc Col in this.TableColumns) {

                            WebCell = new TableCell();

                            if (String.IsNullOrEmpty(Col.ColumFormat)) {
                                WebCell.Text = Convert.ToString(Rows[Col.ColumName]);
                            } else {
                                WebCell.Text = String.Format("{0:" + Col.ColumFormat + "}", Rows[Col.ColumName]);
                            }

                            WebRow.Cells.Add(WebCell);
                        }

                        WebTable.Rows.Add(WebRow);
                        WebRow2[count] = WebRow;
                        WebRow = new TableRow();
                        count++;
                    }
                }
                tbl_control.Rows.AddRange(WebRow2);
            } catch (Exception Err) {
                WebTable = null;
                WebRow2 = null;
            }
        }

    }
}