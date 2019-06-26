<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Warden.Views.Menu" %>
<%@ Import Namespace="Warden.Helper" %>

<asp:Content ID="cttMenu" ContentPlaceHolderID="MainContent" runat="server">
    
    
<div class="content" style="justify-content:center">
    
    <div class="row" style="justify-content:center">
        <usc:LabelUsc runat="server" Bold="true" FontSize="15" Text="Menu" Color="White" />

    </div>
    
    <div class="row" style="justify-content:center; padding-top: 10px">
        
        <usc:SquareButtonUsc 
            runat="server" 
            Title="Marcar" 
            Category="Etapa"
            IsButton="true"
            BtnText="Selecionar"
            Icon="Date"
         />
        
        <usc:SquareButtonUsc 
            runat="server" 
            Title="Verificar" 
            Category="Etapa"
            IsButton="true"
            BtnText="Selecionar"
            Icon="User"
         />

        <usc:SquareButtonUsc 
            runat="server" 
            Title="Cadastrar" 
            Category="Fitness"
            IsButton="true"
            BtnText="Selecionar"
            Icon="settings"
         />
    </div>
</div>
   
</asp:Content>
