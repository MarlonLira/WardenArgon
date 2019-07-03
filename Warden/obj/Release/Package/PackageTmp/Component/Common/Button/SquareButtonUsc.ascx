<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SquareButtonUsc.ascx.cs" Inherits="Warden.Component.Common.Button.SquareButtonUsc" %>
<%@ Import Namespace="Warden.Helper" %>


<asp:Panel ID="pnl_control" runat="server">
 <div style="padding-left: 10px; padding-top:10px !important">  
<div class=" col-lg-12 col-md-12 col-sm-8 card card-user " style=" background-color:lightgray">
        <div class="row">
            <%if (!String.IsNullOrEmpty(LoadIcon())) { %>
            <div class="col-4 col-md-3">
                <div class="icon-big text-center icon-warning">
                    <i class="<%=LoadIcon()%>"></i>
                </div>
            </div>
            <%} %>
            <div class="col-15 col-md-16" style="padding-left:10px; padding-top:10px">
                <div class="numbers" >
                    <usc:LabelUsc runat="server" ID="lbl_category" FontSize="12" Text="teste2" Class="card-category" />
                    <usc:LabelUsc runat="server" ID="lbl_title" FontSize="14" Text="Teste" Class="card-title" />
                </div>
            </div>
        </div>
            
    <div class="card-footer " style="background-color:lightgray">
        <hr>

        <%if (IsButton) { %>

        <asp:Button class="btn btn-outline-default" ID="btn_control" runat="server" Text="Button" OnClick="btn_control_Click" />

        <%} else { %>

        <div class="stats">
            <i class="fa fa-refresh"></i> Update Now
        </div>

        <%} %>
    </div>
</div>
</div>
</asp:Panel>