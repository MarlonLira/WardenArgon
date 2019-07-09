using Brasdat.Gestor.Library.Core.Classes.Helpers;
using System;
using System.Data;
using System.Web.UI;

namespace Warden.Views.Telemarketing.Colaborador {
    public partial class Atendimento : TelemarketingPge {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (Session["Table"] != null) {
                TableEdit = (DataTable)Session["TableEdit"];
            }


            if (Session["Table"] == null && TableEdit == null) {
                DataTable Table = new DataTable();
                Table = Sql.ExecuteReader("SELECT TOP 10 * FROM [FITNESS].[VIW_ALUNO] " +
                                          " WHERE [STATUS] = 'AT' " +
                                          " AND CODIGO IS NOT NULL " +
                                          " AND EMPRESA_ID IS NOT NULL " +
                                          " AND NOME NOT LIKE '%PERSONAL%' " +
                                          " ORDER BY ID DESC");
                Session["Table"] = Table;
            }            
        }

        public DataTable TableEdit { get; set; }

        SqlHlp Sql { get { return SqlHlp.Instance; } }

        
    }
}