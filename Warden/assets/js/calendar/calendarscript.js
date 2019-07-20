var currentUpdateEvent;
var addStartDate;
var addEndDate;
var globalAllDay;
var AutoWidth = screen.width / 4;

if (AutoWidth < 300) {
    AutoWidth = 300;
}

function updateEvent(event, element) {
    alert(event.Aluno + "UpdateEvent");

    if ($(this).data("qtip")) $(this).qtip("destroy");

    currentUpdateEvent = event;

    $('#updatedialog').dialog('open');

    $("#eventName").val(event.Aluno);
    $("#eventDesc").val(event.Observacao);
    $("#eventId").val(event.Id);
    $("#eventStart").text("" + event.DataAgendamento.toLocaleString());

    if (event.DataAgendamentoFinal === null) {
        $("#eventEnd").text("");
    }
    else {
        $("#eventEnd").text("" + event.DataAgendamentoFinal.toLocaleString());
    }
    alert(currentUpdateEvent.Aluno + "currentUpdateEvent");
}

function updateSuccess(updateResult) {
    //alert(updateResult);
}

function deleteSuccess(deleteResult) {
    //alert(deleteResult);
}

function addSuccess(addResult) {
// if addresult is -1, means event was not added
//    alert("added key: " + addResult);

    if (addResult != -1) {
        var PushEvent = {
            Aluno: $("#addEventName").val(),
            DataAgendamento: addStartDate,
            DataAgendamentoFinal: addEndDate,
            Id: addResult,
            Observacao: $("#addEventDesc").val(),
            AlunoId: $("#addEventAlunoId").val(),
            OperadorId: $("#addEventOperadorId").val(),
            allDay: globalAllDay
        }

        $('#calendar').fullCalendar('renderEvent', PushEvent, true);
        alert(PushEvent.Aluno + "currentUpdateEvent");

        $('#calendar').fullCalendar('unselect');
    }

}

function UpdateTimeSuccess(updateResult) {
    //alert(updateResult);
}


function selectDate(start, end, allDay) {

    $('#addDialog').dialog('open');
    $("#addEventStartDate").text("" + start.toLocaleString());
    $("#addEventEndDate").text("" + end.toLocaleString());

    addStartDate = start;
    addEndDate = end;
    globalAllDay = allDay;
    alert(allDay + " selectDate");

}

function updateEventOnDropResize(event, allDay) {

    alert("allday: " + allDay);
    var eventToUpdate = {
        Id: event.Id,
        DataAgendamento: event.DataAgendamento

    };

    if (allDay) {
        eventToUpdate.DataAgendamento.setHours(0, 0, 0);

    }

    if (event.DataAgendamentoFinal === null) {
        eventToUpdate.DataAgendamentoFinal = eventToUpdate.DataAgendamento;

    }
    else {
        eventToUpdate.DataAgendamentoFinal = event.DataAgendamentoFinal;
        if (allDay) {
            eventToUpdate.DataAgendamentoFinal.setHours(0, 0, 0);
        }
    }

    eventToUpdate.DataAgendamento = eventToUpdate.DataAgendamento.format("dd-MM-yyyy hh:mm:ss tt");
    eventToUpdate.DataAgendamentoFinal = eventToUpdate.DataAgendamentoFinal.format("dd-MM-yyyy hh:mm:ss tt");
    alert(eventToUpdate.DataAgendamento + eventToUpdate.DataAgendamentoFinal + "updateEventOnDropResize");
    PageMethods.UpdateEventTime(eventToUpdate, UpdateTimeSuccess);

}

function eventDropped(event, dayDelta, minuteDelta, allDay, revertFunc) {

    if ($(this).data("qtip")) $(this).qtip("destroy");

    updateEventOnDropResize(event, allDay);
}

function eventResized(event, dayDelta, minuteDelta, revertFunc) {

    if ($(this).data("qtip")) $(this).qtip("destroy");

    updateEventOnDropResize(event);

}

function checkForSpecialChars(stringToCheck) {
    var pattern = /[^A-Za-z0-9 ]/;
    return pattern.test(stringToCheck); 
}

$(document).ready(function() {

    // update Dialog
    $('#updatedialog').dialog({
        autoOpen: false,
        width: AutoWidth,
        buttons: {
            "Atualizar": function() {
                //alert(currentUpdateEvent.title);
                var eventToUpdate = {
                    Id: currentUpdateEvent.Id,
                    Aluno: $("#eventName").val(),
                    Observacao: $("#eventDesc").val(),
                    AlunoId: $("#alunoId").val(),
                    OperadorId: $("#operadorId").val()
                    
                };

                if (checkForSpecialChars(eventToUpdate.Aluno) || checkForSpecialChars(eventToUpdate.Observacao)) {
                    alert("please enter characters: A to Z, a to z, 0 to 9, spaces");
                }
                else {
                    PageMethods.UpdateEvent(eventToUpdate, updateSuccess);
                    $(this).dialog("close");

                    currentUpdateEvent.Aluno = $("#eventName").val();
                    currentUpdateEvent.Observacao = $("#eventDesc").val();
                    $('#calendar').fullCalendar('updateEvent', currentUpdateEvent);
                }

            },
            "Deletar": function() {

                if (confirm("do you really want to delete this event?")) {

                    PageMethods.deleteEvent($("#eventId").val(), deleteSuccess);
                    $(this).dialog("close");
                    $('#calendar').fullCalendar('removeEvents', $("#eventId").val());
                }

            }

        }
    });

    //add dialog
    $('#addDialog').dialog({
        autoOpen: false,
        width: AutoWidth,
        buttons: {
            "Salvar": function() {
                //alert("aqui");
                //alert("sent:" + addStartDate.format("dd-MM-yyyy hh:mm:ss tt") + "==" + addStartDate.toLocaleString());
                var eventToAdd = {
                    Aluno: $("#addEventName").val(),
                    Observacao: $("#addEventDesc").val(),
                    DataAgendamento: addStartDate.format("dd-MM-yyyy hh:mm:ss tt"),
                    DataAgendamentoFinal: addEndDate.format("dd-MM-yyyy hh:mm:ss tt"),
                    //alunoId: $("#addEventAlunoId").val()
                    AlunoId: document.getElementById("addEventAlunoId").innerText,
                    OperadorId: document.getElementById("addEventOperadorId").innerText

                };
                //alert("Aluno: " + eventToAdd.Aluno + " - AlunoId: " + eventToAdd.AlunoId + " - OperadorId: " + eventToAdd.OperadorId);
                if (checkForSpecialChars(eventToAdd.Aluno) || checkForSpecialChars(eventToAdd.Observacao)) {
                    alert("please enter characters: A to Z, a to z, 0 to 9, spaces");
                }
                else {
                    //alert("Aluno: " + eventToAdd.Aluno + " - AlunoId: " + eventToAdd.AlunoId + " - OperadorId: " + eventToAdd.OperadorId);
                    PageMethods.addEvent(eventToAdd, addSuccess);
                    $(this).dialog("close");
                }

            }

        }
    });


    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getFullYear();

    //formatação do Url
    var host = window.location.hostname;
    var protocol = window.location.protocol;
    var port = window.location.port;
    var FormatUrl;

    if (!port) {
        FormatUrl = protocol + "//" + host + "/2gether/JsonResponse.ashx";
    } else {
        FormatUrl = protocol + "//" + host + ":" + port + "/JsonResponse.ashx";
    }

    var calendar = $('#calendar').fullCalendar({
        theme: true,
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        eventClick: updateEvent,
        selectable: true,
        selectHelper: true,
        select: selectDate,
        editable: true,
        events: FormatUrl,
        eventDrop: eventDropped,
        eventResize: eventResized,
        eventRender: function (event, element) {
            //alert(event.Aluno);
            element.qtip({
                content: event.Observacao,
                position: { corner: { tooltip: 'bottomLeft', target: 'topRight'} },
                style: {
                    border: {
                        width: 1,
                        radius: 3,
                        color: '#2779AA'

                    },
                    padding: 10,
                    textAlign: 'center',
                    tip: true, // Give it a speech bubble tip with automatic corner detection
                    name: 'cream' // Style it according to the preset 'cream' style
                }

            });
        }

    });
});