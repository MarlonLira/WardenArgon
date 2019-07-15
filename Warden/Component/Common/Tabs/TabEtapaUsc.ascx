<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TabEtapaUsc.ascx.cs" Inherits="Warden.Component.Common.Tabs.TabEtapaUsc" %>


<asp:Panel ID="pnl_control" runat="server">

    <div class="nav-wrapper">
        <ul class="nav nav-pills nav-fill flex-column flex-md-row" id="tabs-icons-text" role="tablist">
            <li class="nav-item">
                <a class="nav-link mb-sm-3 mb-md-0 active" id="tabs-icons-text-1-tab" data-toggle="tab" href="#tabs-icons-text-1" role="tab" aria-controls="tabs-icons-text-1" aria-selected="true"><i class="ni ni-single-copy-04 mr-2"></i>Anamnese</a>
            </li>
            <li class="nav-item">
                <a class="nav-link mb-sm-3 mb-md-0" id="tabs-icons-text-2-tab" data-toggle="tab" href="#tabs-icons-text-2" role="tab" aria-controls="tabs-icons-text-2" aria-selected="false"><i class="ni ni-favourite-28 mr-2"></i>Bioimpedância</a>
            </li>
            <li class="nav-item">
                <a class="nav-link mb-sm-3 mb-md-0" id="tabs-icons-text-3-tab" data-toggle="tab" href="#tabs-icons-text-3" role="tab" aria-controls="tabs-icons-text-3" aria-selected="false"><i class="ni ni-calendar-grid-58 mr-2"></i>Etapa 3</a>
            </li>
        </ul>
    </div>
    <div class="card shadow">
        <div class="card-body">
            <div class="tab-content" id="myTabContent">
                <div class="tab-pane fade show active" id="tabs-icons-text-1" role="tabpanel" aria-labelledby="tabs-icons-text-1-tab" style="text-align: left !important">
                    <usc:LabelUsc runat="server" ID="lbl_title_control" Text ="Questionário de Prontidão para Atividade Física(PAR-Q):"/>
                    <br />
                    <asp:Panel ID="pnl_question" runat="server">
                        <usc:RadioButtonUsc runat="server" ID="Question1"/>
                        <usc:RadioButtonUsc runat="server" ID="Question2"/>
                        <usc:RadioButtonUsc runat="server" ID="Question3"/>
                        <usc:RadioButtonUsc runat="server" ID="Question4"/>
                        <usc:RadioButtonUsc runat="server" ID="Question5"/>
                        <usc:RadioButtonUsc runat="server" ID="Question6"/>
                        <usc:RadioButtonUsc runat="server" ID="Question7"/>
                        <usc:RadioButtonUsc runat="server" ID="Question8"/>
                        <usc:RadioButtonUsc runat="server" ID="Question9"/>
                        <usc:RadioButtonUsc runat="server" ID="Question10"/>
                    </asp:Panel>
                    <usc:ButtonUsc runat="server" ID="btn_anamnese_salvar" Text="Salvar"/>
                </div>
                <div class="tab-pane fade" id="tabs-icons-text-2" role="tabpanel" aria-labelledby="tabs-icons-text-2-tab">
                    <usc:BioImpedanciaUsc runat="server" ID="BioImpedanciaUsc"/>
                </div>
                <div class="tab-pane fade" id="tabs-icons-text-3" role="tabpanel" aria-labelledby="tabs-icons-text-3-tab">
                     <usc:LabelUsc Runat="server" Text="Proxima Medição" FontSize="15"/>
                            
                        <usc:TextBoxUsc runat="server" Icon="Date" TextMode="Date" Mode="larger" Size="6" IsModified="true"/>
                    <usc:CalendarUsc runat="server" ID="calendar_control" />
                    
                    <div class="rows" >
                        <div class="col-md-6">
                            <div class="form-group">
                                <usc:TextBoxUsc runat="server" Icon="Date" TextMode="Search" Placeholder="Professor"/>
                            </div>
                        </div>
                    </div>
                    <usc:ButtonUsc runat="server" Text="Salvar"/>
                </div>
            </div>
        </div>
        
    </div>
</asp:Panel>
