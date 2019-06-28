<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="TesteLogin.aspx.cs" Inherits="Warden.Views.TesteLogin" %>
<asp:Content ID="ctt_teste" ContentPlaceHolderID="MainContent" runat="server">
    <usc:LabelUsc Text=" Escolha o Sistema" FontSize="16" runat="server" />
    <button type="button" class="btn btn-block btn-default" data-toggle="modal" data-target="#modal-form">2Gether</button>
    <usc:Login2GetherUsc runat="server" />
</asp:Content>
