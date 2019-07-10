using Brasdat.Gestor.Library.Business.Classes.Fitness;
using System;

namespace Warden.Views.Fitness.Colaborador
{
    public partial class Calendario : BasePge
    {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["MarcarProxEtapa"] != null) {
                AlunoEdit = (AlunoPst)Session["MarcarProxEtapa"];
            }
            LoadTeste();
        }

        public AlunoPst AlunoEdit { get; set; }
        public void LoadTeste() {
            if (AlunoEdit != null) {
                user_form.LoadForm(AlunoEdit);
                
            }
        }
    }
}