﻿using Brasdat.Gestor.Library.Business.Classes.Fitness;
using System;
using System.Collections.Generic;
using System.Data;
using Warden.Component.Common.Button;
using static Warden.Component.Common.Table.TableUsc;

namespace Warden.Component.UserControls.Form {
    public partial class UserCommentsUsc : BaseUsc {

        #region Eventos
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            btn_salvar.OnClick += new ButtonUsc.OnClickEvent(Btn_salvar_OnClick);
        }

        private void Btn_salvar_OnClick() {
            throw new Exception("Botão não habilitado!");
        }

        #endregion

        #region Atributos

        public String ID { get; set; }
        public String Aluno { get; set; }
        public AlunoPst AlunoEdit { get; set; }
        public const String WhatsLink = "https://api.whatsapp.com/send?phone=ToPhone&text=ToText";
        public String Href { get; set; }

        #endregion

        #region Metodos
        public void LoadTable(DataTable Table, List<TableColumnUsc> TableColumns) {

            if (Table != null && Table.Rows.Count > 0) {
                tbl_comments.TableColumns = TableColumns;
                tbl_comments.LoadDataSource(Table);
            }
        }

        public void CarregarAluno() {
            String Text = "";
            String[] AlunoPart;
            if (AlunoEdit != null) {
                AlunoPart = AlunoEdit.Nome.Split(' ');
                Text = "Olá " + AlunoPart[0] + " Temos uma super promoção para você !, podemos conversar ? ";
            }
            if (AlunoEdit != null) {
                if (!String.IsNullOrEmpty(AlunoEdit.TelCelular)) {
                    txt_tel.Text = Helper.Help.ConvertToPhoneFormat(AlunoEdit.TelCelular);
                    Href = WhatsLink.Replace("ToPhone", "55" + AlunoEdit.TelCelular);
                    Href = Href.Replace("ToText", Text);
                }
                if (!String.IsNullOrEmpty(AlunoEdit.Email)) {
                    txt_email.Text = AlunoEdit.Email;
                }
            }
        }

        public String LoadTime() {
            String TimeToString = "";
            DateTime TimeNow = DateTime.Now.ToUniversalTime().AddHours(-3);
            TimeToString = TimeNow.ToString();
            
            return TimeToString;
        }
        #endregion

    }
}