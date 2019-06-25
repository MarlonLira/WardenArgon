<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SquareButtonUsc.ascx.cs" Inherits="Warden.Component.Common.Button.SquareButtonUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<asp:Panel ID="pnl_control" runat="server">
    <div class="col-lg-24 col-md-12 col-sm-8" style="padding-left: 10px">
        <div class="card card-stats">
            <div class="card-body ">
                <div class="row">
                    <div class="col-4 col-md-3">
                        <div class="icon-big text-center icon-warning">
                            <i class="<%=LoadIcon()%>"></i>
                        </div>
                    </div>
                    <div class="col-7 col-md-8">
                        <div class="numbers">
                            <p class="card-category"><asp:Label class="card-category" ID="lbl_category" runat="server" Text="Label"></asp:Label></p>
                            <p class="card-title"><asp:Label class="card-title" ID="lbl_Title" runat="server" Text="Label" Font-Size="Large"></asp:Label></p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="card-footer ">
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