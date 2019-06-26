<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserSearchFormUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserSearchFormUsc" %>

<asp:Panel ID="pnl_control" runat="server">
    <div class="content">
    <div class="row">
<div class="col-md-12">
    <form class="card shadow" >
        <div class="card-body">
            <div class="card-header" style="text-align: center">
                <h4 class="card-title"> Pesquisa de Alunos</h4>
                <p class="card-category"> Pesquise pelo nome e copie a matricula</p>
            </div>
            <div class="row" style="justify-content:center">
                <usc:TableUsc ID="tbl_control" runat="server" />
            </div>
            <br />
          <div class="row" style="justify-content:center">
            <div class="col-md-5 px-1">
              <div class="form-group">
                  <usc:TextBoxUsc ID="txt_nome" runat="server" Icon="user" Placeholder="Nome" IsLabel="true" Label="Nome"/>
              </div>
            </div>
            <div class="col-md-5 px-1">
              <div class="form-group">
                <usc:TextBoxUsc ID="txt_matricula" runat="server" Icon="badge" Placeholder="Matricula" IsLabel="true" Label="Matricula"/>
              </div>
            </div>
          </div>
            <div>
              <usc:ButtonUsc ID="btn_pesquisar" runat="server" Text="Pesquisar"/>
            </div>
          </div>
    </form>
</div>
</div>
</div>
</asp:Panel>