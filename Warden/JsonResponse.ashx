<%@ WebHandler Language="C#" Class="JsonResponse" %>

using System;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Web.SessionState;

public class JsonResponse : IHttpHandler, IRequiresSessionState 
{
    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "application/json";

        DateTime DataAgendamento = new DateTime(1970, 1, 1);
        DateTime DataAgendamentoFinal = new DateTime(1970, 1, 1);

        DataAgendamento = DataAgendamento.AddSeconds(double.Parse(context.Request.QueryString["start"]));
        DataAgendamentoFinal = DataAgendamentoFinal.AddSeconds(double.Parse(context.Request.QueryString["end"]));
        
        String result = String.Empty;

        result += "[";

        List<int> idList = new List<int>();
        foreach (CalendarEvent cevent in EventDAO.getEvents(DataAgendamento, DataAgendamentoFinal))
        {
            result += convertCalendarEventIntoString(cevent);
            idList.Add(cevent.Id);
        }

        if (result.EndsWith(","))
        {
            result = result.Substring(0, result.Length - 1);
        }

        result += "]";
        //store list of event ids in Session, so that it can be accessed in web methods
        context.Session["idList"] = idList;

        context.Response.Write(result);
    }

    private String convertCalendarEventIntoString(CalendarEvent cevent)
    {
        String allDay = "true";
        if (ConvertToTimestamp(cevent.DataAgendamento).ToString().Equals(ConvertToTimestamp(cevent.DataAgendamentoFinal).ToString()))
        {

            if (cevent.DataAgendamento.Hour == 0 && cevent.DataAgendamento.Minute == 0 && cevent.DataAgendamento.Second == 0)
            {
                allDay = "true";
            }
            else
            {
                allDay = "false";
            }
        }
        else
        {
            if (cevent.DataAgendamento.Hour == 0 && cevent.DataAgendamento.Minute == 0 && cevent.DataAgendamento.Second == 0
                && cevent.DataAgendamentoFinal.Hour == 0 && cevent.DataAgendamentoFinal.Minute == 0 && cevent.DataAgendamentoFinal.Second == 0)
            {
                allDay = "true";
            }
            else
            {
                allDay = "false";
            }
        }
        return    "{" +
                  "Id: '" + cevent.Id + "'," +
                  "AlunoId: '" + cevent.AlunoId + "'," +
                  "operadorId: '" + cevent.OperadorId + "'," +
                  "Aluno: '" + HttpContext.Current.Server.HtmlEncode(cevent.Aluno) + "'," +
                  "data_agendamento:  " + ConvertToTimestamp(cevent.DataAgendamento).ToString() + "," +
                  "data_agendamento_final: " + ConvertToTimestamp(cevent.DataAgendamentoFinal).ToString() + "," +
                  "allDay:" + allDay + "," +
                  "Observacao: '" + HttpContext.Current.Server.HtmlEncode(cevent.Observacao) + "'" +
                  "},";
    }

    
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    private long ConvertToTimestamp(DateTime value)
    {
        long epoch = (value.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        return epoch;

    }
}