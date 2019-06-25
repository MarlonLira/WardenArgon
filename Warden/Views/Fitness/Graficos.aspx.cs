using System;
using System.Web.UI;
using System.Collections.Generic;
using Warden.Component.Common.Charts;

namespace Warden.Views.Fitness {
    public partial class Graficos : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                ChartUsc = new ChartUsc();
                ChartUsc.DataSource = new Dictionary<string, string>();

                ChartUsc.DataSource.Add("IMC", "22");
                ChartUsc.DataSource.Add("Gordura", "33");
                ChartUsc.DataSource.Add("Idade Corporal", "32");
                ChartUsc.DataSource.Add("Peso", "69");

                Session.Add("LoadCharts", ChartUsc.DataSource);
            }
        }

    }
}