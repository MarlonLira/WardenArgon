﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// EventDAO class is the main class which interacts with the database. SQL Server express edition
/// has been used.
/// the event information is stored in a table named 'event' in the database.
///
/// Here is the table format:
/// event(event_id int, title varchar(100), description varchar(200),event_start datetime, event_end datetime)
/// event_id is the primary key
/// </summary>
public class EventDAO
{
    //change the connection string as per your database connection. 198.38.83.33; Initial Catalog=hiacademia_web; Integrated Security=True
    //private static string connectionString = "Data Source=198.38.83.33;Initial Catalog=hiacademia_web;Persist Security Info=True;User ID=higestor_sa;Password=Root1526";
    private static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=gestor2;Persist Security Info=True;User ID=sa;Password=Root1526";

    //this method retrieves all events within range start-end
    public static List<CalendarEvent> getEvents(DateTime start, DateTime end)
    {
       
        List<CalendarEvent> events = new List<CalendarEvent>();
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("EXEC [fitness].[stp_agenda_2gether_pesquisar] @start, @end ", con);
        cmd.Parameters.AddWithValue("@start", start);
        cmd.Parameters.AddWithValue("@end", end);
        
        using (con)
        {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CalendarEvent cevent = new CalendarEvent();
                cevent.Id = (int)reader["id"];
                cevent.Aluno = (string)reader["aluno"];
                cevent.Observacao = (string)reader["observacao"];
                cevent.DataAgendamento = (DateTime)reader["data_agendamento"];
                cevent.DataAgendamentoFinal = (DateTime)reader["data_agendamento_final"];
                cevent.AlunoId = (int)reader["aluno_id"];
                cevent.OperadorId = (int)reader["operador_id"];
                events.Add(cevent);
            }
        }
        return events;
        //side note: if you want to show events only related to particular users,
        //if user id of that user is stored in session as Session["userid"]
        //the event table also contains a extra field named 'user_id' to mark the event for that particular user
        //then you can modify the SQL as:
        //SELECT event_id, description, title, event_start, event_end FROM event where user_id=@user_id AND event_start>=@start AND event_end<=@end
        //then add paramter as:cmd.Parameters.AddWithValue("@user_id", HttpContext.Current.Session["userid"]);
    }

	//this method updates the event title and description
    public static void updateEvent(int id, String title, String description)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("UPDATE event SET title=@title, description=@description WHERE event_id=@event_id", con);
        cmd.Parameters.AddWithValue("@title", title);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.Parameters.AddWithValue("@event_id", id);
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

	//this method updates the event start and end time
    public static void updateEventTime(int id, DateTime start, DateTime end)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("UPDATE event SET event_start=@event_start, event_end=@event_end WHERE event_id=@event_id", con);
        cmd.Parameters.AddWithValue("@event_start", start);
        cmd.Parameters.AddWithValue("@event_end", end);
        cmd.Parameters.AddWithValue("@event_id", id);
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

	//this mehtod deletes event with the id passed in.
    public static void deleteEvent(int id)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("update event set[status] = 'EX' WHERE (event_id = @event_id)", con);
        cmd.Parameters.AddWithValue("@event_id", id);
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

	//this method adds events to the database
    public static int addEvent(CalendarEvent cevent)
    {
        //add event to the database and return the primary key of the added event row

        //insert
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("EXEC [fitness].[stp_agenda_2gether_incluir] @id, @status, @auditoria, @aluno_id, @aluno, @observacao, @data_agendamento, @data_agendamento_final, @operador_id", con);
        cmd.Parameters.AddWithValue("@aluno", cevent.Aluno);
        cmd.Parameters.AddWithValue("@observacao", cevent.Observacao);
        cmd.Parameters.AddWithValue("@data_agendamento", cevent.DataAgendamento);
        cmd.Parameters.AddWithValue("@data_agendamento_final", cevent.DataAgendamentoFinal);
        cmd.Parameters.AddWithValue("@aluno_id", cevent.AlunoId);
        cmd.Parameters.AddWithValue("@operador_id", cevent.OperadorId);

        int key = 0;
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();

            //get primary key of inserted row
            cmd = new SqlCommand("SELECT max(event_id) FROM [fitness].[tbl_agenda_2gether] where aluno=@aluno AND observacao=@observacao AND data_agendamento=@data_agendamento AND data_agendamento_final=@data_agendamento_final AND aluno_id = @aluno_id", con);
            cmd.Parameters.AddWithValue("@aluno", cevent.Aluno);
            cmd.Parameters.AddWithValue("@observacao", cevent.Observacao);
            cmd.Parameters.AddWithValue("@data_agendamento", cevent.DataAgendamento);
            cmd.Parameters.AddWithValue("@data_agendamento_final", cevent.DataAgendamentoFinal);
            cmd.Parameters.AddWithValue("@aluno_id", cevent.AlunoId);

            key = (int)cmd.ExecuteScalar();
        }

        return key;

    }
}
