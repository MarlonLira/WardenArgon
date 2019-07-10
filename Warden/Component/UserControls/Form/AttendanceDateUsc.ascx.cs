using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warden.Component.UserControls.Form {
    public partial class AttendanceDateUsc : BaseUsc {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            calendar_control.Calendar = new Common.Calendar.CalendarUsc.CalendarDay();
            calendar_control.Calendar.Date = DateTime.Now;
            calendar_control.LoadCalendar();
        }


    }
}