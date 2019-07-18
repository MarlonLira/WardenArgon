<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="Warden.Views.Fitness.Aluno" %>

<asp:Content ID="ctt_aluno" ContentPlaceHolderID="MainContent" runat="server">
     <usc:UserProfileUsc runat="server" ID="profile_control" IsReadOnly="true"/>

    <div class="content" style="padding-top:15px; background-color:gray">
        <h5 class="card-title"><b>OPÇÕES</b></h5>
        <usc:CardInitUsc runat="server" />
            <usc:ButtonUsc runat="server" Text="Atendimento" ID="btn_atendimento"/>
            <usc:ButtonUsc runat="server" Text="Marcar Atendimento" ID="btn_marcar_atendimento"/>
            <usc:ButtonUsc runat="server" Text="Verificar Progresso" ID="btn_verif_progresso"/>
        <usc:CardCloseUsc runat="server" />
    </div>
</asp:Content>
