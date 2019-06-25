<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChartUsc.ascx.cs" Inherits="Warden.Component.Common.Charts.ChartUsc" %>

<asp:Panel ID="pnl_control" runat="server">
    <form>
        <div class="bar-chart-area">
            <div class="container">
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="bar-chart-wp">
                            <canvas height="140vh" width="180vw" id="barchart1"></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>  
    </form>
</asp:Panel>

