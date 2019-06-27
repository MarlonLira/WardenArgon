<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextBoxUsc.ascx.cs" Inherits="Warden.Component.Common.TextBox.TextBoxUsc" %>


    
<% if (IsModified) {%>
<div class="col-<%=LoadMode() %>-<%=LoadSize() %>">
    <%} %>

    <%if (IsLabel == true) { %>
            <div style="text-align:left">
                <usc:LabelUsc FontSize="14" runat="server" Text="label" Class="font-weight-bold mb-4" ID="lbl_control"/>
            </div>
    <%} %>
    <div class="input-group input-group-alternative">
    
        <div class="input-group-prepend">
            <span class="input-group-text"><i class="<%=LoadIcon()%>"></i></span>
        </div>
    
        <asp:TextBox ID="txt_control" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
    </div>

<%if (IsModified) { %>
</div>
<%} %>
