<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextBoxUsc.ascx.cs" Inherits="Warden.Component.Common.TextBox.TextBoxUsc" %>

<div class="input-group input-group-alternative">
    
    <div class="input-group-prepend">
        <span class="input-group-text"><i class="<%=LoadIcon()%>"></i></span>
    </div>
    
    <asp:TextBox ID="txt_control" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
</div>