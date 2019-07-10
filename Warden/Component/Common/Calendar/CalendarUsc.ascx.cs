using System;
using System.Collections.Generic;
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

            clr_control.DayRender += Clr_control_DayRender;
            LoadCalendar();
        }

        private void Clr_control_DayRender(object sender, DayRenderEventArgs e) {
            String CreateCalendarDay = e.Day.Date.ToShortDateString();
            String DaySelected;
           
            if (DateList != null) {
                foreach (DateTime Date in DateList) {
                    DaySelected = Date.ToShortDateString();
                    if (CreateCalendarDay == DaySelected) {
                        e.Cell.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        public DateTime SelectedDate { get { return this.clr_control.SelectedDate; } }
        public System.Web.UI.WebControls.Calendar Calendar_Control = new System.Web.UI.WebControls.Calendar();
        public CalendarDay Calendar;
        public List<DateTime> DateList;

        public void LoadCalendar() {
            Calendar_Control.OtherMonthDayStyle.ForeColor = System.Drawing.Color.LightGray;
            Calendar_Control.TitleStyle.BackColor = System.Drawing.Color.Black;
            Calendar_Control.TitleStyle.ForeColor = System.Drawing.Color.White;
            Calendar_Control.DayStyle.BackColor = System.Drawing.Color.Gray;
            Calendar_Control.SelectionMode = CalendarSelectionMode.Day;
            Calendar_Control.ShowNextPrevMonth = true;

            clr_control = Calendar_Control;
            clr_control.DataBind();
            //clr_control.Controls.Add(Calendar_Control);
        }
    }
}