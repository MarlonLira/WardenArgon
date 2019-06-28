<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Warden.Views.Login" %>
<%@ Import Namespace="Warden.Helper" %>
<asp:Content ID="ctt_login" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding-bottom:20px">
        <image src="<%=Help.FormatUrl("/assets/img/bg/1.png") %>" ></image>
    </div>
        <usc:LabelUsc Text=" Escolha o Sistema" FontSize="16" runat="server" Color="white"/>
        <button type="button" class="btn btn-block btn-default" data-toggle="modal" data-target="#modal-2gether">2Gether</button>
        <button type="button" class="btn btn-block btn-default" data-toggle="modal" data-target="#modal-Argon">Argon</button>
        <usc:Login2GetherUsc runat="server" />
        <%if (Session["Error"] != null) {
                lbl_erro.Text = (String)Session["Error"]; %>
                <usc:LabelUsc FontSize="14" runat="server" ID="lbl_erro" Color="red" />
        <%} %>
    
</asp:Content>
