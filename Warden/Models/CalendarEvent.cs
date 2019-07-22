using Brasdat.Gestor.Library.Business.Classes.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CalendarEvent
/// </summary>
public class CalendarEvent
{
    public Int32 Id { get; set; }
    public String Status { get; set; }
    public String Auditoria { get; set; }
    public Int32 AlunoId { get; set; }
    public String Aluno { get; set; }
    public String Observacao { get; set; }
    public DateTime DataAgendamento { get; set; }
    public DateTime DataAgendamentoFinal { get; set; }
    public Int32 OperadorId { get; set; }
    public String OperadorNome { get; set; }
    public Int32 Etapa { get; set; }

}
