<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HtmlTableUsc.ascx.cs" Inherits="Warden.Component.Common.Table.HtmlTableUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<!-- Table CSS -->
<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css">

<asp:Panel ID="pnl_control" runat="server">

    <div class="data-table-area" style="background-color:white">
        <div class="container">
            <div class="row">
                <div class="col-lg-<%=Scale%> col-md-<%=Scale%> col-sm-<%=Scale%> col-xs-<%=Scale * 3%> ">
                    <div class="data-table-list">
                        <div class="table-responsive">
                            <table id="data-table-basic" class="table table-striped table table-cl">
                                <thead id="th_control" runat="server"></thead>
                                <tbody id="tb_control" runat="server"></tbody>
                                <tfoot id="tf_control" runat="server"></tfoot>
                            </table> 
                        </div>
                    </div>
                </div>
            </div>
        </div>
</div>
</asp:Panel>

<!-- Table -->
<script src="<%=Help.FormatUrl("/assets/js/table/jquery.dataTables.min.js") %>"></script>
<script src="<%=Help.FormatUrl("/assets/js/table/data-table-act.js") %>"></script>