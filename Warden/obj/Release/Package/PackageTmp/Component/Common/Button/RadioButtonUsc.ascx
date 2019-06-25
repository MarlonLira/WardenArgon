<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonUsc.ascx.cs" Inherits="Warden.Component.Common.Button.RadioButtonUsc" %>

<asp:Panel ID="pnl_control" runat="server">
        <!-- Radio buttons -->
        <div class="mb-3">
            <asp:Label class="text-uppercase font-weight-bold" ID="lbl_control" runat="server"></asp:Label>
        </div>
        <div class="custom-control custom-radio mb-3">
            <asp:RadioButtonList  ID="rb_control" runat="server">
            </asp:RadioButtonList>
        </div>
</asp:Panel>

<!--RadioButtom: class="custom-control-input"-->