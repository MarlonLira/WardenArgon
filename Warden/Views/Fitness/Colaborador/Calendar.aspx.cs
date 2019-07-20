using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Warden.Views.Fitness.Colaborador {
    public partial class Calendar : FitnessPge {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }
        //this method only updates Aluno and Observacao
        //this is called when a event is clicked on the calendar
        [System.Web.Services.WebMethod(true)]
        public static string UpdateEvent(CalendarEvent cevent) {

            List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];
            if (idList != null && idList.Contains(cevent.Id)) {
                if (CheckAlphaNumeric(cevent.Aluno) && CheckAlphaNumeric(cevent.Observacao)) {
                    EventDAO.updateEvent(cevent.Id, cevent.Aluno, cevent.Observacao);

                    return "updated event with id:" + cevent.Id + " update title to: " + cevent.Aluno +
                    " update description to: " + cevent.Observacao;
                }

            }

            return "unable to update event with id:" + cevent.Id + " title : " + cevent.Aluno +
                " description : " + cevent.Observacao;
        }

        //this method only updates start and end time
        //this is called when a event is dragged or resized in the calendar
        [System.Web.Services.WebMethod(true)]
        public static string UpdateEventTime(ImproperCalendarEvent improperEvent) {
            List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];
            if (idList != null && idList.Contains(improperEvent.Id)) {
                EventDAO.updateEventTime(improperEvent.Id,
                    DateTime.ParseExact(improperEvent.DataAgendamento, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
                    DateTime.ParseExact(improperEvent.DataAgendamentoFinal, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture));

                return "updated event with id:" + improperEvent.Id + "update start to: " + improperEvent.DataAgendamento +
                    " update end to: " + improperEvent.DataAgendamentoFinal;
            }

            return "unable to update event with id: " + improperEvent.Id;
        }

        //called when delete button is pressed
        [System.Web.Services.WebMethod(true)]
        public static String deleteEvent(int id) {
            //idList is stored in Session by JsonResponse.ashx for security reasons
            //whenever any event is update or deleted, the event id is checked
            //whether it is present in the idList, if it is not present in the idList
            //then it may be a malicious user trying to delete someone elses events
            //thus this checking prevents misuse
            List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];
            if (idList != null && idList.Contains(id)) {
                EventDAO.deleteEvent(id);
                return "deleted event with id:" + id;
            }

            return "unable to delete event with id: " + id;

        }

        //called when Add button is clicked
        //this is called when a mouse is clicked on open space of any day or dragged 
        //over mutliple days
        [System.Web.Services.WebMethod]
        public static int addEvent(ImproperCalendarEvent improperEvent) {

            CalendarEvent cevent = new CalendarEvent() {
                Aluno = improperEvent.Aluno,
                Status = "AT",
                Auditoria = Global.Funcionario.Usuario + " - " + DateTime.UtcNow.AddHours(-3) + " - INCLUIR",
                Observacao = improperEvent.Observacao,
                AlunoId = improperEvent.AlunoId,
                OperadorId = improperEvent.OperadorId,
                DataAgendamento = DateTime.ParseExact(improperEvent.DataAgendamento, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
                DataAgendamentoFinal = DateTime.ParseExact(improperEvent.DataAgendamentoFinal, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)

            };

            if (CheckAlphaNumeric(cevent.Aluno) && CheckAlphaNumeric(cevent.Observacao)) {
                int key = EventDAO.addEvent(cevent);

                List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];

                if (idList != null) {
                    idList.Add(key);
                }

                return key;//return the primary key of the added cevent object

            }

            return -1;//return a negative number just to signify nothing has been added

        }

        private static bool CheckAlphaNumeric(string str) {

            return Regex.IsMatch(str, @"^[a-zA-Z0-9 ]*$");


        }
    }
}