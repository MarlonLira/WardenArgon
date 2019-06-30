using Brasdat.Gestor.Library.Core.Classes.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Warden.Views.Fitness.Colaborador {
    public partial class Atendimento : FitnessPge {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (Session["Table"] == null) {
                DataTable Table = new DataTable();
                Table = Sql.ExecuteReader("SELECT TOP 10 * FROM [FITNESS].[VIW_ALUNO] " +
                                          " WHERE [STATUS] = 'AT' " +
                                          " AND CODIGO IS NOT NULL " +
                                          " ORDER BY ID DESC");
                Session["Table"] = Table;
            }
        }

        SqlHlp Sql { get { return SqlHlp.Instance; } }
    }
}