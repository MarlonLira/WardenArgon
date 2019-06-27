<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="Warden.Views.Fitness.Aluno" %>

<asp:Content ID="ctt_aluno" ContentPlaceHolderID="MainContent" runat="server">
     <usc:UserProfileUsc runat="server" ID="profile_control" IsReadOnly="true"/>
    <div class="row" style="padding-top: 20px; padding-left:20px">

        <usc:SquareButtonUsc 
            runat="server" 
            Title="Marcar Proxima Etapa" 
            Category="---- Etapa ----"
            IsButton="true"
            BtnText="Selecionar"
            ID="btn_prox_etapa"
         />

        <usc:SquareButtonUsc 
            runat="server" 
            Title="Verificar Etapa Atual" 
            Category="---- Etapa ----"
            IsButton="true"
            BtnText="Selecionar"
            ID="btn_verif_etapa"
         />
    </div>
</asp:Content>
