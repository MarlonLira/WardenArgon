<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserFormUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserFormUsc" %>

<asp:Panel ID="pnl_control" runat="server" enabled="false">
    
    <form class="card shadow" >
        <div class="card-body" style="text-align: left !important">
            <usc:LabelUsc ID="LabelUsc" runat="server" Text="Informações do Aluno"/>            
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                  <usc:TextBoxUsc ID="txt_nome" runat="server" Icon="user" Placeholder="Nome"/>
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="txt_email" runat="server" Icon="email" Placeholder="E-mail" />
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="txt_tel" runat="server" Icon="phone" Placeholder="Telefone"/>
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <div class="input-group mb-4">
                  <usc:TextBoxUsc ID="txt_idade" runat="server" Icon="wave" Placeholder="Idade" />
                </div>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="txt_sexo" runat="server" Icon="gender" Placeholder="Sexo" />
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="txt_data" runat="server" Icon="date" Placeholder="Data"/>
              </div>
            </div>
              <usc:ButtonUsc ID="btn_confirmar" runat="server" Text="Salvar"/>
              
          </div>
        </div>
    </form>
</asp:Panel>