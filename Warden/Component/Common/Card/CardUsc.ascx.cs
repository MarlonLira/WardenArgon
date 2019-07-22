using Brasdat.Gestor.Library.Business.Classes.Fitness;
using Brasdat.Gestor.Library.Core.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using static Warden.Component.Common.Table.TableUsc;

namespace Warden.Component.Common.Card {
    public partial class CardUsc : BaseUsc {

        #region Eventos

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (!String.IsNullOrEmpty(Request.QueryString["Matricula"])) {
                SelectedValue();
            }
        }

        #endregion

        #region Atributos
        public AlunoPst AlunoEdit { get; set; }
        public List<TableColumnUsc> TableColumns { get; set; }
        public String UrlImg { get; set; }
        public String SmallText { get; set; }
        public String Class { get; set; }
        public DateTime Time { get; set; }
        public String Href { get; set; }
        public Boolean IsModal { get; set; }
        public String Btn1Text {
            get { return btn1.Text; }
            set { this.btn1.Text = value; }
        }
        #endregion

        #region Atributos Defasados // verificar
        public String Btn2Text { set { this.btn2.InnerText = value; } }

        public String ID { get; set; }
        public Int32 EmpresaId { get; set; }

        public String Aluno {
            get { return this.lbl_aluno.Text; }
            set { this.lbl_aluno.Text = value; } }
        public String Matricula {
            get { return this.lbl_matricula.Text; }
            set { this.lbl_matricula.Text = value; } }
        public String Date { set { this.lbl_data.Text = value; } }
        public String Text { get; set; }
        #endregion

        #region Metodos

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

            if (AlunoRow == null) {
                if (!String.IsNullOrEmpty(AlunoMatricula)) {
                    CarregarAluno(AlunoMatricula, AlunoEmpresa);
                }
            } else {
                CarregarAluno(AlunoRow);
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

        public DataRow AlunoRow { get; set; }

        public String LoadTime() {
            String TimeToString = "";

            if (!String.IsNullOrEmpty(SmallText)) {
                TimeToString = SmallText;
            }
            TimeToString += DateTime.Now.ToShortTimeString();
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

        private void CarregarAluno(DataRow AlunoRow) {
            DataTable Table = new DataTable();
            AlunoPst Aluno = new AlunoPst();

            if (AlunoRow != null) {
                Aluno.Preencher(AlunoRow);
                Session.Add("Aluno", Aluno);
            }

            Response.Redirect("~/views/fitness/Aluno.aspx");
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

        public void LoadDataSource(AlunoPst Aluno) {
            AlunoPst NewAluno;
            try {
                NewAluno = Aluno;
                if (Aluno != null) {

                    EmpresaId = Aluno.Empresa.Id;
                    lbl_aluno.Text = Aluno.Nome;
                    lbl_matricula.Text = "Matricula: " + Aluno.Codigo;
                    lbl_data.Text = "Dt. Ultimo Contrato: " + Aluno.DataUltContrato.ToShortDateString();
                }

            } finally {
                NewAluno = null;
            }
        }

        #endregion
    }
}