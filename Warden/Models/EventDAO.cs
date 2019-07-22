using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Brasdat.Gestor.Library.Core.Classes.Helpers;
using Warden.Helper;

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
    private static string connectionString = CryptoHlp.Decrypt("+82kjar9seJikiHEK4mH+UowXzFkVQlXzYeyZSRUKcJSKDuKaHeS2Ua6HAV0u4PY1VjADjvckGF/nkQO4U0ZXU0mKs4JiGG3xWVANW6hVBi8Frubo1f6NRKWryxk4uNMtgJRTuSHrfnPH8JWR5jpcR6yQ7NUXo2Fy7CtGCyT/iw=");
    //private static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=gestor2;Persist Security Info=True;User ID=sa;Password=Root1526";

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
                cevent.Id = Convert.ToInt32(reader["id"]);
                cevent.Aluno = (string)reader["aluno"];
                cevent.Observacao = (string)reader["observacao"];
                cevent.DataAgendamento = (DateTime)reader["data_agendamento"];
                cevent.DataAgendamentoFinal = (DateTime)reader["data_agendamento_final"];
                cevent.AlunoId = Convert.ToInt32(reader["aluno_id"]);
                cevent.OperadorId = Convert.ToInt32(reader["operador_id"]);
                events.Add(cevent);
            }
        }
        return events;
    }

    public static CalendarEvent getEvents(Int32 AlunoId) {

        CalendarEvent cevent = new CalendarEvent();
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("EXEC [fitness].[stp_agenda_2gether_pesquisar] @start, @end, @aluno_id ", con);
        cmd.Parameters.AddWithValue("@start", DBNull.Value);
        cmd.Parameters.AddWithValue("@end", DBNull.Value);
        cmd.Parameters.AddWithValue("@aluno_id", AlunoId);

        using (con) {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {

                cevent.Id = Convert.ToInt32(reader["id"]);
                cevent.Aluno = Convert.ToString(reader["aluno"]);
                cevent.Observacao = Convert.ToString(reader["observacao"]);
                cevent.DataAgendamento = Convert.ToDateTime(reader["data_agendamento"]);
                cevent.DataAgendamentoFinal = Convert.ToDateTime(reader["data_agendamento_final"]);
                cevent.OperadorId = Convert.ToInt32(reader["operador_id"]);
                cevent.OperadorNome = Convert.ToString(reader["operador_nome"]);
                if (reader["aluno_id"] != DBNull.Value && reader["aluno_id"] != null) {
                    cevent.AlunoId = Convert.ToInt32(reader["aluno_id"]);
                }

                if (reader["etapa"] != DBNull.Value && reader["etapa"] != null) {
                    cevent.Etapa = Convert.ToInt32(reader["etapa"]);
                } else {
                    cevent.Etapa = 0;
                }
            }
        }
        return cevent;
    }

    public static void updateEvent(int Id, String Aluno, String Observacao)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("UPDATE [fitness].[tbl_agenda_2gether] SET aluno=@aluno, observacao=@observacao WHERE id=@id", con);
        cmd.Parameters.AddWithValue("@aluno", Aluno);
        cmd.Parameters.AddWithValue("@observacao", Observacao);
        cmd.Parameters.AddWithValue("@id", Id);
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

	//this method updates the event start and end time
    public static void updateEventTime(Int32 Id, DateTime DataAgendamento, DateTime DataAgendamentoFinal)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("UPDATE [fitness].[tbl_agenda_2gether] SET data_agendamento=@data_agendamento, data_agendamento_final=@data_agendamento_final WHERE id=@id", con);
        cmd.Parameters.AddWithValue("@data_agendamento", DataAgendamento);
        cmd.Parameters.AddWithValue("@data_agendamento_final", DataAgendamentoFinal);
        cmd.Parameters.AddWithValue("@id", Id);
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

	//this mehtod deletes event with the id passed in.
    public static void deleteEvent(Int32 Id)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("update [fitness].[tbl_agenda_2gether] set[status] = 'EX' WHERE (id = @id)", con);
        cmd.Parameters.AddWithValue("@id", Id);
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

	//this method adds events to the database
    public static object addEvent(CalendarEvent cevent)
    {
        object Result;
        try {
            //add event to the database and return the primary key of the added event row

            //insert
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("EXEC [fitness].[stp_agenda_2gether_incluir] @id OUTPUT, @status, @auditoria, @aluno_id, @aluno, @observacao, @data_agendamento, @data_agendamento_final, @operador_id", con);
            cmd.Parameters.AddWithValue("@aluno", cevent.Aluno);
            cmd.Parameters.AddWithValue("@status", cevent.Status);
            cmd.Parameters.AddWithValue("@auditoria", cevent.Auditoria);
            cmd.Parameters.AddWithValue("@observacao", cevent.Observacao);
            cmd.Parameters.AddWithValue("@data_agendamento", cevent.DataAgendamento);
            cmd.Parameters.AddWithValue("@data_agendamento_final", cevent.DataAgendamentoFinal);
            cmd.Parameters.AddWithValue("@aluno_id", cevent.AlunoId);
            cmd.Parameters.AddWithValue("@operador_id", cevent.OperadorId);
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int);
            
            using (con) {
                con.Open();
                Result = cmd.ExecuteScalar();
            }
        } catch (Exception Err) {
            throw new Exception(Err.Message);
        }

        return Result;

    }
}
