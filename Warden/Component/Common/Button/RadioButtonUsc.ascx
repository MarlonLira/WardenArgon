<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonUsc.ascx.cs" Inherits="Warden.Component.Common.Button.RadioButtonUsc" %>

<asp:Panel ID="pnl_control" runat="server">
    
        <!-- Radio buttons -->
        <div class="mb-3">
            <small class="text-uppercase font-weight-bold"><%=Title %></small>
        </div>
        <div class="custom-control custom-radio mb-3">
            <asp:RadioButtonList class="custom-control-input" ID="rb_control" runat="server">
                <asp:ListItem Text="Sim"></asp:ListItem>
                <asp:ListItem Text="Não"></asp:ListItem>
            </asp:RadioButtonList>
            <label class="custom-control-label" for="customRadio1">
            <span><%=Text %></span>
            </label>
        </div>
    
</asp:Panel>