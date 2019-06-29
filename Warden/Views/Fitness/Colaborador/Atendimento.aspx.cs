using Brasdat.Gestor.Library.Business.Classes.Fitness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Views.Fitness.Colaborador {
    public partial class Atendimento : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Table"] != null) {

            }
        }

        public void LoadAvatar() {

            DataTable Table = new DataTable();
            AlunoPst Aluno = new AlunoPst();

            if (Session["Table"] != null) {
                Table = (DataTable)Session["Table"];
            }

            foreach (DataRow Row in Table.Rows) {

                Aluno.Preencher(Row);
                avatar_control.Aluno = Aluno;
            }
        }
    }
}