using Brasdat.Gestor.Library.Core.Classes.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Warden.Views.Fitness.Colaborador {
    public partial class Atendimento : FitnessPge {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CarregarAtendimento();
        }

        SqlHlp Sql { get { return SqlHlp.Instance; } }

        private void CarregarAtendimento() {
            DataTable Table;
            try {
                Table = new DataTable();
                Table = Sql.ExecuteReader("EXEC [fitness].[stp_agenda_2gether_pesquisar]");
                Session["Table"] = Table;
            } finally {
                Table = null;
            }
        }
    }
}