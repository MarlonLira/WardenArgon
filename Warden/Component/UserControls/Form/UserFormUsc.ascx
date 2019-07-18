<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserFormUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserFormUsc" %>

<asp:Panel ID="pnl_control" runat="server" enabled="false">
    
    <form class="card shadow">
        <div class="card-body" style="text-align: left; background-color:lightgray !important">
            <usc:LabelUsc ID="LabelUsc" runat="server" Text="Informações do Aluno"/>            
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                  <usc:TextBoxUsc
                      ID="txt_nome" 
                      runat="server" 
                      Icon="user" 
                      Placeholder="Nome"
                      IsLabel="true"
                      Label="Nome"
                      LabelSize="9"
                    />
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc 
                    ID="txt_email" 
                    runat="server" 
                    Icon="email" 
                    Placeholder="E-mail"
                    IsLabel="true"
                    Label="E-mail"
                    LabelSize="9"
                />
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc 
                    ID="txt_tel"
                    runat="server"
                    Icon="phone" 
                    Placeholder="Telefone"
                    IsLabel="true"
                    Label="Telefone"
                    LabelSize="9"
                />
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                  <usc:TextBoxUsc 
                      ID="txt_idade" 
                      runat="server" 
                      Icon="wave" 
                      Placeholder="Idade"
                      IsLabel="true"
                      Label="Idade"
                      LabelSize="9"
                    />
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc 
                    ID="txt_sexo" 
                    runat="server" 
                    Icon="gender" 
                    Placeholder="Sexo"
                    IsLabel="true"
                    Label="Sexo"
                    LabelSize="9"
                />
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc 
                    ID="txt_data" 
                    runat="server" 
                    Icon="date" 
                    Placeholder="Data"
                    IsLabel="true"
                    Label="Data"
                    LabelSize="9"
                />
              </div>
            </div>
              <usc:ButtonUsc ID="btn_confirmar" runat="server" Text="Salvar"/>
              
          </div>
        </div>
    </form>
</asp:Panel>