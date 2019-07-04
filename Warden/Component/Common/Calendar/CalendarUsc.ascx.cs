using System;
using System.Web.UI.WebControls;

namespace Warden.Component.Common.Calendar
{
    public partial class CalendarUsc : BaseUsc
    {
        public class CalendarDay {
            public DateTime Date;
            public Int32 Day;
            public Int32 Month;
            public Int32 Year;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            
            Calendar_Control.DayRender += Calendar_Control_DayRender;
        }

        public System.Web.UI.WebControls.Calendar Calendar_Control = new System.Web.UI.WebControls.Calendar();
        public CalendarDay Calendar;
        public void LoadCalendar(CalendarDay CalendarEdit) {
            Calendar = CalendarEdit;
            Calendar_Control.OtherMonthDayStyle.ForeColor = System.Drawing.Color.LightGray;
            Calendar_Control.TitleStyle.BackColor = System.Drawing.Color.Black;
            Calendar_Control.TitleStyle.ForeColor = System.Drawing.Color.White;
            Calendar_Control.DayStyle.BackColor = System.Drawing.Color.Gray;
            Calendar_Control.SelectionMode = CalendarSelectionMode.Day;
            Calendar_Control.ShowNextPrevMonth = true;

            frm_calendar.Controls.Add(Calendar_Control);
        }
        private void Calendar_Control_DayRender(object sender, DayRenderEventArgs e) {
            String CreateCalendarDay = e.Day.Date.ToShortDateString();
            String DaySelected = Calendar.Date.ToShortDateString();

            if (CreateCalendarDay == DaySelected) {
                e.Cell.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}