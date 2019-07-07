using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Core.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using Warden.Component.Common.Button;
using Warden.Component.Common.Table;
using static Warden.Component.Common.Table.TableUsc;

namespace Warden.Component.Common.Card {
    public partial class CardUsc : BaseUsc {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (!String.IsNullOrEmpty(Request.QueryString["Matricula"])) {
                SelectedValue();
            }
        }
        public AlunoPst AlunoEdit { get; set; }
        public List<TableColumnUsc> TableColumns { get; set; }
        public String Aluno {
            get { return this.lbl_aluno.Text; }
            set { this.lbl_aluno.Text = value; } }
        public String Matricula {
            get { return this.lbl_matricula.Text; }
            set { this.lbl_matricula.Text = value; } }
        public String Date { set { this.lbl_data.Text = value; } }

        public Int32 EmpresaId { get; set; }
        
        public String ID { get; set; }
        public String Text { get; set; }
        public DateTime Time { get; set; }
        public String UrlImg { get; set; }
        public String Class { get; set; }
        public String Href { get; set; }
        public String btn1Text {
            get { return btn1.Text; }
            set { this.btn1.Text = value; }
        }
        public Boolean IsModal { get; set; }


        public String LoadRef() {
            String Ref = "";

            Ref = Href;

            return Ref;
        }

        public String LoadImg() {
            String Url = "";
            
            Url = Helper.Help.FormatUrl(UrlImg);

            return Url;
        }


        public void SelectedValue() {

            string AlunoMatricula = Request.QueryString["Matricula"];

            string AlunoEmpresa = Request.QueryString["Empresa"];

            if (!String.IsNullOrEmpty(AlunoMatricula)) {
                CarregarAluno(AlunoMatricula, AlunoEmpresa);
            }
        }

        public String LoadClass() {

            String Type = "";
            if (String.IsNullOrEmpty(Class)) {
                Class = "";
            }
            switch (Class.ToUpper()) {
                case "SQUARE" : {
                    Type = "card-img-top";
                    break;
                }
                case "ROUND": {
                    Type = "avatar border-gray";
                    break;
                }
                default: {
                    Type = "card-img-top";
                    break;
                }
            }
            return Type;
        }

        public String LoadTime() {
            String TimeToString = "";
            TimeToString = DateTime.Now.ToShortTimeString();

            return TimeToString;
        }
        private void CarregarAluno(String Matricula, String Empresa) {
            DataTable Table = new DataTable();
            AlunoPst Aluno;

            Aluno = new AlunoPst() { Filters = new List<BaseMdl.Filter>() };
            Aluno.Filters.Add(new BaseMdl.Filter("[status] = 'AT'", CompareModeTypes.EXPRESSION));
            if (!String.IsNullOrEmpty(Matricula)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[codigo]", CompareModeTypes.EQUAL, Matricula));
            }
            if (!String.IsNullOrEmpty(Empresa)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[empresa_id]", CompareModeTypes.EQUAL, Empresa));
            }

            Table = Aluno.Pesquisar();

            if (Table.Rows.Count > 0) {

                foreach (DataRow Row in Table.Rows) {
                    Aluno.Preencher(Row);

                    Session.Add("Aluno", Aluno);
                }

                Response.Redirect("~/views/fitness/Aluno.aspx");
            }
        }

        public DataTable ComentariosAluno(String Matricula, String Empresa) {
            DataTable Table = new DataTable();
            AlunoPst Aluno;

            Aluno = new AlunoPst() { Filters = new List<BaseMdl.Filter>() };
            Aluno.Filters.Add(new BaseMdl.Filter("[status] = 'AT'", CompareModeTypes.EXPRESSION));
            if (!String.IsNullOrEmpty(Matricula)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[codigo]", CompareModeTypes.EQUAL, Matricula));
            }
            if (!String.IsNullOrEmpty(Empresa)) {
                Aluno.Filters.Add(new BaseMdl.Filter("[empresa_id]", CompareModeTypes.EQUAL, Empresa));
            }

            Table = Aluno.Pesquisar();

            return Table;



        }
    }
}