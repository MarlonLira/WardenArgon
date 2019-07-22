<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChartUsc.ascx.cs" Inherits="Warden.Component.Common.Charts.ChartUsc" %>
<%@ Import Namespace="Warden.Helper" %>


<asp:Panel ID="pnl_control" runat="server">
    <form style="background-color: white">
        <div class="bar-chart-area">
            <div class="container">
                <div class="row">
                    <div class="col-lg-<%=Scale %> col-md-<%=Scale %> col-sm-<%=Scale %> col-xs-<%=Scale * 2 %>">
                        <div class="bar-chart-wp">
                            <canvas height="240vh" width="380vw" id="barchart1" style="padding-top:15px"></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>  
    </form>
</asp:Panel>
<script src="<%=Help.FormatUrl("/assets/js/charts/Chart.js") %>"></script>

<script type="text/javascript">

	 /*----------------------------------------*/
	/*  1.  Bar Chart
	/*----------------------------------------*/

    var ctx = document.getElementById("barchart1");
	var barchart1 = new Chart(ctx, {
		type: 'bar',
        data: {
            <%
            String Titulos = "";
            String Valores = "";
            if (this.DataSource != null && this.DataSource.Count > 0) {
                foreach (KeyValuePair<String, String> item in this.DataSource) {
                    Titulos += '"' + item.Key + '"' + ",";
                    Valores += item.Value + ",";
                }
            }
            %>
            labels: [<%=Titulos.Substring(0, Titulos.Length - 1) %>],
			datasets: [{
            label: 'Resultado',
			data: [<%=Valores.Substring(0, Valores.Length - 1) %>],
			backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgb(50,205,50, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)'
            ],
			borderColor: [
                'rgba(255,99,132,1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)'
            ],
            borderWidth: 1
			}]
		},
		options: {
			scales: {
				yAxes: [{
					ticks: {
						beginAtZero:true
					}
				}]
			}
		}
    });

</script>

