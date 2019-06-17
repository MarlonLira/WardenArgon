<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserFormUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserFormUsc" %>

<asp:Panel ID="pnl_control" runat="server">
    
    <form class="card shadow" >
        <div class="card-body" style="text-align: left !important">
            <usc:LabelUsc ID="LabelUsc" runat="server" Text="Informações do Aluno"/>            
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                  <usc:TextBoxUsc ID="txt_email" runat="server" Icon="user" Placeholder="Nome"/>
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="TextBoxUsc1" runat="server" Icon="email" Placeholder="E-mail"/>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="TextBoxUsc2" runat="server" Icon="phone" Placeholder="Telefone"/>
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <div class="input-group mb-4">
                  <usc:TextBoxUsc ID="TextBoxUsc3" runat="server" Icon="wave" Placeholder="Idade"/>
                </div>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="TextBoxUsc4" runat="server" Icon="gender" Placeholder="Sexo"/>
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="TextBoxUsc5" runat="server" Icon="date" Placeholder="Data"/>
              </div>
            </div>
              <usc:ButtonUsc ID="btn_confirmar" runat="server" Text="Salvar"/>
              
          </div>
        </div>
    </form>
</asp:Panel>