<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserSearchFormUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserSearchFormUsc" %>

<asp:Panel ID="pnl_control" runat="server">
    <form class="card shadow" >
        <div class="card-body" style="text-align: left !important">        
            <usc:TableUsc ID="tbl_control" runat="server" />
            <br />
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
                  <usc:TextBoxUsc ID="txt_nome" runat="server" Icon="user" Placeholder="Nome"/>
              </div>
            </div>
            <div class="col-md-6">
              <div class="form-group">
                <usc:TextBoxUsc ID="txt_matricula" runat="server" Icon="badge" Placeholder="Matricula"/>
              </div>
            </div>
          </div>       
              <usc:ButtonUsc ID="btn_pesquisar" runat="server" Text="Pesquisar" OnClick="BtnPesquisar_Click"/>
          </div>
    </form>
</asp:Panel>