<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuButtonUsc.ascx.cs" Inherits="Warden.Component.Common.Button.MenuButtonUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<asp:Panel ID="pnl_control" runat="server">
<div style="padding-top: 5px; padding-bottom: 5px">
    <a href="<%=NavigateForUrl() %>" class="media d-flex align-items-center">
        <div class="icon icon-shape bg-gradient-<%=LoadType() %> rounded-circle text-white">
            <i class="<%=LoadIcon() %>"></i>
        </div>
        <div class="media-body ml-3">
            <h5 class="heading text-warning mb-md-1"><%=Title %></h5>
            <p class="description d-none d-md-inline-block mb-0"><%=Description %></p>
        </div>
    </a>
</div>
</asp:Panel>