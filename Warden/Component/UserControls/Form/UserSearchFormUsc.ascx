<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserSearchFormUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserSearchFormUsc" %>

<asp:Panel ID="pnl_control" runat="server">
                        
<usc:CardInitUsc runat="server" ID="cardInit_control" />

    <div class="row">
        <div class="col-md-24">
            <form class="card shadow">
                <div class="card-body" >
                    <div class="card-header" style="text-align: center">
                        <usc:LabelUsc Class="card-title" FontSize="16" ID="lbl_title_control" runat="server" Text="Pesquisa de Alunos" />
                        <usc:LabelUsc Class="card-category" FontSize="12" ID="lbl_category_control" runat="server" Text="Pesquise pelo nome e copie a matricula" />
                    </div>
                    <div class="row" style="justify-content:center">
                        <usc:TableUsc ID="tbl_control" runat="server" />
                    </div>
                    <br />
                        <div class="card-header">
                              <div class="row" style="justify-content:center">
                                <div class="col-md-6 px-5">
                                  <div class="form-group">
                                      <usc:TextBoxUsc ID="txt_nome" runat="server" Icon="user" Placeholder="Nome" IsLabel="true" Label="Nome"/>
                                  </div>
                                </div>
                                <div class="col-md-6 px-5">
                                  <div class="form-group">
                                    <usc:TextBoxUsc ID="txt_matricula" runat="server" Icon="badge" Placeholder="Matricula" IsLabel="true" Label="Matricula"/>
                                  </div>
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


</asp:Panel>