<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RoundButtonUsc.ascx.cs" Inherits="Warden.Component.Common.Button.RoundButtonUsc" %>

<div class="col-lg-4">
    <img class="rounded-circle" src="<%=UrlImg %>" alt="Generic placeholder image" width="140" height="140">
    <h2><usc:LabelUsc runat="server" ID="lbl_title" /></h2>
    <p><usc:LabelUsc runat="server" ID="lbl_description" /></p>
    <p> <a class="btn btn-secondary" href="#" role="button" data-toggle="modal" data-target="#modal-leads" id="Btn_confirmar"><%=BtnText %> &raquo;</a></p>
</div>
