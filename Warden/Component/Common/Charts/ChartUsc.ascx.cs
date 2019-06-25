using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Warden.Component.Common.Charts {
    public partial class ChartUsc : UserControl {
      
        public Dictionary<String, String> DataSource;

        public class ChartLoad{
            public Dictionary<String, String> Value;
            
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {

                if (Scale <= 0) {
                    Scale = 6;
                }
                DataSource = new Dictionary<string, string>();

                DataSource = (Dictionary<string, string>)Session["LoadCharts"];
                /*
                DataSource.Add("Pouco", "12");
                DataSource.Add("Quase meio", "25");
                DataSource.Add("Meio", "30");
                DataSource.Add("Prime", "50");*/

            }
        }

        public void LoadDataSource(ChartLoad Data) {
            if (Scale <= 0) {
                Scale = 6;
            }

            DataSource = Data.Value;
        }

        public Int32 Scale { get; set; }
    }
}