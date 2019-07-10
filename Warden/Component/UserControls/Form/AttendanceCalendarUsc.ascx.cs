using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Warden.Component.Common.Dropdown;

namespace Warden.Component.UserControls.Form
{
    public partial class AttendanceCalendarUsc : BaseUsc
    {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            Carregar();
        }

        public List<DateTime> Dates;
        

        public void Carregar() {
            List<String> Horario = new List<string>();
            dd_horas.NewItemList = new List<DropdownUsc.NewItem>();
            dd_professor.NewItemList = new List<DropdownUsc.NewItem>();

            DropdownUsc.NewItem Hora = new DropdownUsc.NewItem() { Nome = "HORARIOS DISPONIVEIS" };
            DropdownUsc.NewItem Hora1 = new DropdownUsc.NewItem() { Nome = "13:30" };
            DropdownUsc.NewItem Hora2 = new DropdownUsc.NewItem() { Nome = "14:30" };
            DropdownUsc.NewItem Hora3 = new DropdownUsc.NewItem() { Nome = "15:30" };

            DropdownUsc.NewItem Professor = new DropdownUsc.NewItem() { Nome = "PROFESSORES DISPONIVEIS" };
            DropdownUsc.NewItem Professor1 = new DropdownUsc.NewItem() { Nome = "ZEO" };
            DropdownUsc.NewItem Professor2 = new DropdownUsc.NewItem() { Nome = "ZEZO" };
            DropdownUsc.NewItem Professor3 = new DropdownUsc.NewItem() { Nome = "ZIO" };

            dd_horas.NewItemList.Add(Hora);
            dd_horas.NewItemList.Add(Hora1);
            dd_horas.NewItemList.Add(Hora2);
            dd_horas.NewItemList.Add(Hora3);

            dd_professor.NewItemList.Add(Professor);
            dd_professor.NewItemList.Add(Professor1);
            dd_professor.NewItemList.Add(Professor2);
            dd_professor.NewItemList.Add(Professor3);

            dd_horas.LoadDataSource(dd_horas.NewItemList);
            dd_professor.LoadDataSource(dd_professor.NewItemList);

            Dates = new List<DateTime>();

            clr_control.DateList = new List<DateTime>();
            Dates.Add(Convert.ToDateTime("2019-07-01"));
            Dates.Add(Convert.ToDateTime("2019-07-01"));
            Dates.Add(Convert.ToDateTime("2019-07-01"));
            Dates.Add(Convert.ToDateTime("2019-07-01"));
            Dates.Add(Convert.ToDateTime("2019-07-01"));
            Dates.Add(Convert.ToDateTime("2019-07-05"));
            Dates.Add(Convert.ToDateTime("2019-07-05"));
            Dates.Add(Convert.ToDateTime("2019-07-05"));
            Dates.Add(Convert.ToDateTime("2019-07-05"));
            Dates.Add(Convert.ToDateTime("2019-07-05"));
            Dates.Add(Convert.ToDateTime("2019-07-06"));
            Dates.Add(Convert.ToDateTime("2019-07-07"));
            Dates.Add(Convert.ToDateTime("2019-07-07"));
            Dates.Add(Convert.ToDateTime("2019-07-07"));
            Dates.Add(Convert.ToDateTime("2019-07-07"));
            Dates.Add(Convert.ToDateTime("2019-07-07"));

            foreach (DateTime Date in CheckLimitDates(Dates)) {
                clr_control.DateList.Add(Date);
                lbl_teste.Text += " " + Date.ToShortDateString();
            }
        }

        public List<DateTime> CheckLimitDates(List<DateTime> Dates) {
            List<DateTime> LimitDates = null;

            if (Dates != null) {
                LimitDates = Dates
                    .GroupBy(x => x.Date)
                    .Where(g => g.Count() > 4)
                    .Select(g => g.Key)
                    .ToList();
            }

            return LimitDates;
        }
    }
}