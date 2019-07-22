<%@ Page Title="" Language="C#" MasterPageFile="~/Views/WebMst.Master" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="Warden.Views.Fitness.Colaborador.Calendario" %>
<asp:Content ID="ctt_calendario" ContentPlaceHolderID="MainContent" runat="server">
    <usc:CardInitUsc runat="server" />
    <usc:UserFormUsc runat="server" ID="user_form"/>
    <usc:CardCloseUsc runat="server" />
    <usc:AttendanceCalendarUsc runat="server" ID="calendar_control"/>
</asp:Content>
