<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FilterUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.FilterUsc" %>

   
<asp:Panel ID="pnl_control" runat="server">
    
        <div class="col-md-30">
            <form class="card shadow"  >
                <div class="card-body">
                    <div class="card-header" style="text-align: center; background-color:lightgray">
                        <usc:LabelUsc Class="card-title" FontSize="16" ID="lbl_title_control" runat="server" Text="Filtros de Pesquisa" />
                        <usc:LabelUsc Class="card-category" FontSize="12" ID="lbl_category_control" runat="server" Text="Pesquise pelo nome e copie a matricula" />
                    </div>
                    <br />
                        <div class="card-header"  style="background-color:lightgray">
                              <div class="row" style="justify-content:center">
                                  <div class="col-md-6 px-5">
                                  <div class="form-group">
                                    <usc:TextBoxUsc ID="txt_data" runat="server" Icon="calendar" TextMode="Date" />
                                  </div>
                                </div>
                                <div class="col-md-6 px-5">
                                  <div class="form-group">
                                    <usc:DropdownUsc ID="dd_estado" runat="server"/>
                                  </div>
                                </div>
                                  <div class="col-md-6 px-5">
                                      <div class="form-group">
                                        <usc:DropdownUsc ID="dd_tipo" runat="server"/>
                                      </div>
                                  </div>
                                  <div class="col-md-6 px-5">
                                      <div class="form-group">
                                        <usc:DropdownUsc ID="dd_empresa" runat="server"/>
                                      </div>
                                  </div>
                                  <div style="position:relative; float:left">
                                    <usc:ButtonUsc ID="btn_pesquisar" runat="server" Text="Pesquisar"/>
                                 </div>
                              </div>
                        </div>
                        
                    <div>
                      
                    </div>
                  </div>
            </form>
        </div>
  

</asp:Panel>
