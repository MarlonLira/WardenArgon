using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Do not use this object, it is used just as a go between between javascript and asp.net
public class ImproperCalendarEvent
{
    public Int32 Id { get; set; }
    public String Status { get; set; }
    public String Auditoria { get; set; }
    public Int32 AlunoId { get; set; }
    public String Aluno { get; set; }
    public String Observacao { get; set; }
    public String DataAgendamento { get; set; }
    public String DataAgendamentoFinal { get; set; }
    public Int32 OperadorId { get; set; }

}
