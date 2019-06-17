using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Core.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;

namespace Warden.Component.UserControls.Form {
    public partial class UserSearchFormUsc : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            btn_pesquisar.BtnControl_Click += new EventHandler(BtnPesquisar_Click);
        }

        protected void BtnPesquisar_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txt_matricula.Text) || !String.IsNullOrEmpty(txt_nome.Text)) {
                CarregarAluno();
            }
        }


        private void CarregarAluno() {
            DataTable Table = new DataTable();
            AlunoPst Aluno;

            Aluno = new AlunoPst() { Filters = new List<BaseMdl.Filter>() };
            Aluno.Filters.Add(new BaseMdl.Filter("[status] = 'AT'", CompareModeTypes.EXPRESSION));
            if (!String.IsNullOrEmpty(txt_matricula.Text)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[codigo]", CompareModeTypes.EQUAL, txt_matricula.Text));
            }
            if (!String.IsNullOrEmpty(txt_nome.Text)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[nome] COLLATE Latin1_General_CI_AI", CompareModeTypes.LIKE, txt_nome.Text + "%"));
            }
            //Aluno.Filters.Add(new BaseMdl.Filter("[empresa_id]", CompareModeTypes.EQUAL, Convert.ToInt32(cmbEmpresa.SelectedValue)));

            Table = Aluno.Pesquisar();
            
            Session.Add("AlunoTable", Table);
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "LoginUsc", "$(function(){$('#modal-form').modal('show');})", true);
        }
    }
}