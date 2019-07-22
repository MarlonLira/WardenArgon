<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="Warden.Views.Fitness.Colaborador.Calendar" %>

<!DOCTYPE html">
<html lang="pt-br">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Language" content="pt-br">
    <title>Calendario</title>
    <usc:CssUsc runat="server" ID="css_control" />
    <usc:CalendarCssUsc runat="server" />
</head>
<body style="background-color:darkgrey">
    
    <form id="frm_calendar" runat="server" class="wrapper" >
        <usc:HeaderUsc runat="server" />
        <asp:ScriptManager ID="spt_calendar" runat="server" EnablePageMethods="true">
        </asp:ScriptManager>
        
<div class="main-panel">
    
    <div class="position-relative">
        <section class="section section-lg section-hero section-shaped" style="padding-top:15px">
            <div class="container shape-container d-flex align-items-center py-lg">
                <div class="col px-0" >
                <div class="row align-items-center justify-content-center" >

                    <div class="col-lg-30 text-center" >
                        <usc:UserFormUsc runat="server" />
                <div id="calendar" style="padding-top:15px">
                </div>
                        
                <div id="updatedialog" title="Atualizar ou Apagar Evento" style="text-align:left">
                    <div class="style1">
                        <input type="hidden" id="operadorId"/>
                        <input  type="hidden" id="alunoId"/>
                        <usc:TextBoxUsc runat="server" ID="TextBoxUsc1" ComponentId="eventName" Title="Aluno" IsHtml="true"/>
                        <usc:TextBoxUsc runat="server" ID="TextBoxUsc6" ComponentId="eventDesc" Title="Descrição" IsHtml="true" IsTextArea="true"/>
                        <label class="alignRight" title="Inicio: "> Inicio: <span class="alignLeft" id="eventStart"></span></label>
                        <label class="alignRight" title="Final: ">Final: <span class="alignLeft" id="eventEnd"></span></label>
                        <input type="hidden" id="eventId"/>
                    </div>
                </div>
                
                <div id="addDialog" title="Adicionar Evento" style="text-align:left">
                    <div class="style1">
                        <%  
                            String[] NamePart = this.SelectedAluno.Nome.Split(' ');
                            this.txt_aluno.Value = NamePart[0] + " " + NamePart[1];
                            this.txt_aluno.ReadOnly = false;
                            %>
                        <label hidden="true" class="alignRight"> FuncionarioId:<label class="alignRight" id="addEventOperadorId"><%=this.GlobalFuncionario.Id %></label></label>
                        <label hidden="true" class="alignRight" title="Inicio: "> Id: <label id="addEventAlunoId"><%=this.SelectedAluno.Id%></label></label>
                        <usc:TextBoxUsc runat="server" ReadOnly="false" ID="txt_aluno" ComponentId="addEventName" Title="Aluno" IsHtml="true"/>
                        <usc:TextBoxUsc runat="server" ID="txt_descricao" ComponentId="addEventDesc" Title="Descrição" IsTextArea="true" IsHtml="true"/>
                        <label class="alignRight" title="Inicio: "> Inicio: <span class="alignLeft" id="addEventStartDate"></span></label>
                        <label class="alignRight" title="Final: ">Final: <span class="alignLeft" id="addEventEndDate"></span></label>
                    </div>
                </div>
                <div runat="server" id="jsonDiv" />
                <input type="hidden" id="hdClient" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </form>
    <usc:JsUsc runat="server" ID="js_control" />
    <usc:CalendarJsUsc runat="server" />
</body>
</html>