<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AvatarUsc.ascx.cs" Inherits="Warden.Component.UserControls.Avatar.AvatarUsc" %>
<%@ Import Namespace="Warden.Helper" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Brasdat.Gestor.Library.Business.Classes.Fitness" %>


<%

    AlunoPst Aluno = new AlunoPst();
    DataTable Table = (DataTable)Session["Table"];

    foreach (DataRow Row in Table.Rows) {
        
        lbl_aluno.Text = Row["nome"].ToString();
        lbl_plano.Text = Row["codigo"].ToString();
        lbl_data.Text = "23/06/2019";

    %>
<div class="col-md-16" style=" padding-left:20px; padding-right:20px; padding-bottom: 20px; padding-top: 20px ;position:relative">
<div class="card card-user" style="background-color:lightgray">
    <div class="card-body">
        <div class="author">
            <a href="?Matricula=<%= Row["codigo"].ToString()%>&Empresa=<%= Row["empresa_id"].ToString()%>">
            <img class="avatar border-gray" style="width: 150px; height:150px" src="<%=Help.FormatUrl("/assets/img/default-avatar.png") %>" alt="...">

            <usc:LabelUsc 
                ID="lbl_aluno" 
                runat="server" 
                Text="Aluno" 
                FontSize="10" 
                Bold="true"
            />  
                        
            </a>

            <usc:LabelUsc
                Class="description text-center" 
                runat="server" 
                ID="lbl_data"
                Text="Dt.Avaliação:"
                FontSize="9"
            />
                    
        </div>
                    
            <usc:LabelUsc 
                Class="description" 
                runat="server" 
                ID="lbl_plano" 
                Text="Plano:" 
                FontSize="8" 
            />
            
    </div>
</div>
</div>
<br />
<%} %>
    