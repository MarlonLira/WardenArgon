<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AttendanceCalendarUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.AttendanceCalendarUsc" %>

<div style="padding-top:15px">
<usc:CardInitUsc runat="server" />
<div style="justify-content:center; align-items:center" class="container">
    <usc:LabelUsc runat="server" FontSize="12" Text="Marcar Atendimento" />
        
    <usc:CalendarUsc runat="server" ID="clr_control"/>
       
    <div class="row" style="padding-top:15px">
        <usc:DropdownUsc runat="server" ID="dd_horas" />
        <usc:DropdownUsc runat="server" ID="dd_professor" />
    </div>
    <div style="padding-top:10px; float:left">
        <usc:ButtonUsc ID="btn_teste" runat="server" Text="Salvar" />
    </div>
</div>
<usc:CardCloseUsc runat="server" />
<usc:LabelUsc ID="lbl_teste" FontSize="12" Color="red" runat="server" />
</div>

