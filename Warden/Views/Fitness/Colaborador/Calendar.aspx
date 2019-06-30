<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="Warden.Views.Fitness.Colaborador.Calendar" %>
<%@ Import Namespace="Warden.Helper" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>2 Gether Calendario</title>
    <link href="<%=Help.FormatUrl("/assets/css/calendar/jquery-ui.min.css") %>" rel="stylesheet" />
    <link href="<%=Help.FormatUrl("/assets/css/calendar/fullcalendar.min.css") %>" rel="stylesheet" />
    <link href="<%=Help.FormatUrl("/assets/css/calendar/jquery.qtip.min.css") %>" rel="stylesheet" />
    <link href="<%=Help.FormatUrl("/assets/css/calendar/calendars.css") %>" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    
    <div id="calendar">
    </div>
    <div id="updatedialog" style="font: 70% 'Trebuchet MS', sans-serif; margin: 50px;display: none;"
        title="Update or Delete Event">
        <table class="style1">
            <tr>
                <td class="alignRight">
                    Nome:</td>
                <td class="alignLeft">
                    <input id="eventName" type="text" size="33" /><br /></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Descrição:</td>
                <td class="alignLeft">
                    <textarea id="eventDesc" cols="30" rows="3" ></textarea></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Inicio:</td>
                <td class="alignLeft">
                    <span id="eventStart"></span></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Fim: </td>
                <td class="alignLeft">
                    <span id="eventEnd"></span><input type="hidden" id="eventId" /></td>
            </tr>
        </table>
    </div>
    <div id="addDialog" style="font: 70% 'Trebuchet MS', sans-serif; margin: 50px;" title="Adicionar Evento">
    <table class="style1">
            <tr>
                <td class="alignRight">
                    Nome:</td>
                <td class="alignLeft">
                    <input id="addEventName" type="text" size="33" /><br /></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Descrição:</td>
                <td class="alignLeft">
                    <textarea id="addEventDesc" cols="30" rows="3" ></textarea></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Inicio:</td>
                <td class="alignLeft">
                    <span id="addEventStartDate" ></span></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Fim:</td>
                <td class="alignLeft">
                    <span id="addEventEndDate" ></span></td>
            </tr>
        </table>
        
    </div>
    <div runat="server" id="jsonDiv" />
    <input type="hidden" id="hdClient" runat="server" />
    </form>

    <script src="<%=Help.FormatUrl("/assets/js/calendar/moment.min.js") %>"></script>
    <script src="<%=Help.FormatUrl("/assets/js/calendar/jquery.min.js") %>"></script>
    <script src="<%=Help.FormatUrl("/assets/js/calendar/jquery-ui.min.js") %>"></script>
    <script src="<%=Help.FormatUrl("/assets/js/calendar/jquery.qtip.min.js") %>"></script>
    <script src="<%=Help.FormatUrl("/assets/js/calendar/fullcalendar.min.js") %>"></script>
    <script src="<%=Help.FormatUrl("/assets/js/calendar/calendarscript.js") %>" type="text/javascript"></script>
</body>
</html>