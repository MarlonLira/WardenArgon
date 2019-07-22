<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginTesteUsc.ascx.cs" Inherits="Warden.Component.UserControls.Login.LoginTesteUsc" %>




    <div class="card-body px-lg-5 py-lg-5">
                <div class="text-center text-muted mb-4">
                  <small>Login</small>
                </div>
                <form role="form" runat="server">
                  <div class="form-group mb-3">
                    <usc:TextBoxUsc ID="txt_email" runat="server" Icon="email" Placeholder="CPF"/>
                  </div>
                  <div class="form-group">
                    <usc:TextBoxUsc ID="txt_password" runat="server" Icon="password" Placeholder="Senha" TextMode="Password"/>
                  </div>
                  <div class="custom-control custom-control-alternative custom-checkbox">
                    <input class="custom-control-input" id=" customCheckLogin" type="checkbox">
                    <label class="custom-control-label" for=" customCheckLogin">
                      <span>Remember me</span>
                    </label>
                  </div>
                  <div class="text-center">
                      <br />
                      <usc:ButtonUsc ID="ButtonUsc" runat="server" Text="Confirmar"/>
                      <br />
                      <usc:LabelUsc runat="server" Bold="true" FontSize="10" Color="red" ID="lbl_erro"/>
                      <usc:SquareButtonUsc BtnText="teste" Category="teste2" IsButton="true" runat="server" Title="teste3" idSquareButtonUsc1 />
                  </div>
                </form>
              </div>

