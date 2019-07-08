﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Atendimento.aspx.cs" Inherits="Warden.Views.Fitness.Colaborador.Atendimento" %>
<%@ Import Namespace="Warden.Helper" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Brasdat.Gestor.Library.Business.Classes.Fitness" %>

<asp:Content ID="ctt_atendimento" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="container">
    <div class="row">
          
        <%

            AlunoPst Aluno = new AlunoPst();
            DataTable Table = (DataTable)Session["Table"];

            if (Table != null) {
                foreach (DataRow Row in Table.Rows) {

                    card_control.Aluno = Row["nome"].ToString();
                    card_control.Matricula =" Matricula: " +  Row["codigo"].ToString();
                    card_control.Date = "23/06/2019";
                    card_control.Href = "?Matricula=" + Row["codigo"].ToString() + "&Empresa=" + Row["empresa_id"].ToString();

                %>
              <usc:CardUsc ID="card_control" runat="server" UrlImg="/assets/gif/gym.gif"/>
        <%} } %>
            
    </div>   
</div>

</asp:Content>
