<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Graficos.aspx.cs" Inherits="Warden.Views.Fitness.Graficos" %>

<asp:Content ID="ctt_graficos" ContentPlaceHolderID="MainContent" runat="server">
    <usc:UserFormUsc runat="server" ID="UserFormUsc"/>
    <usc:ChartUsc runat="server" ID="ChartUsc"/>
    <usc:ButtonUsc runat="server" ID="btnteste" Text=" Teste" />
</asp:Content>
