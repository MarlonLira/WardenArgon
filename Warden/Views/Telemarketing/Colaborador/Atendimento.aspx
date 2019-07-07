<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Atendimento.aspx.cs" Inherits="Warden.Views.Telemarketing.Colaborador.Atendimento" %>
<%@ Import Namespace="Warden.Helper" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Brasdat.Gestor.Library.Business.Classes.Fitness" %>

<asp:Content ID="ctt_atendimento" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="container">
    <div class="row">
          
        <%

            AlunoPst Aluno;
            DataTable Table = (DataTable)Session["Table"];

            if (Table != null) {
                foreach (DataRow Row in Table.Rows) {
                    Aluno = new AlunoPst();
                    Aluno.Empresa = new Brasdat.Gestor.Library.Business.Classes.Administracao.EmpresaPst();

                    Aluno.Nome = Row["nome"].ToString();
                    Aluno.Empresa.Id = Convert.ToInt32(Row["empresa_id"]);
                    Aluno.Codigo = Row["codigo"].ToString();
                    Aluno.TelCelular = Row["tel_celular"].ToString();

                    card_control.AlunoEdit = Aluno;
                    card_control.LoadDataSource(Aluno);

                    /*
                    card_control.Aluno = Row["nome"].ToString();
                    card_control.EmpresaId = Convert.ToInt32(Row["empresa_id"]);
                    card_control.Matricula =" Matricula: " +  Row["codigo"].ToString();
                    card_control.Date = "23/06/2019";
                    card_control.Href = "?Matricula=" + Row["codigo"].ToString() + "&Empresa=" + Row["empresa_id"].ToString();
                    */

                %>
              <usc:CardUsc 
                  ID="card_control" 
                  runat="server" 
                  UrlImg="/assets/img/default-avatar.png"
                  IsModal="true"
                />
        <%} } %>
            
    </div>   
</div>

</asp:Content>
