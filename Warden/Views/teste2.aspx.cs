using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Views {
    public partial class teste2 : Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            LoadCalendar();
        }
        public void LoadCalendar() {
            calendar_control.Calendar = new Component.Common.Calendar.CalendarUsc.CalendarDay();
            calendar_control.Calendar.Date = DateTime.Now;

            calendar_control.LoadCalendar(calendar_control.Calendar);
        }
        
    }
}