<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUsc.ascx.cs" Inherits="Warden.Component.UserControls.Login.LoginUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<div class="col-md-4">
<button type="button" class="btn btn-block btn-default" data-toggle="modal" data-target="#modal-form">2Gether</button>
    
    <div class="modal fade" id="modal-form" tabindex="-1" role="dialog" aria-labelledby="modal-form" aria-hidden="true">
    <div class="modal-dialog modal- modal-dialog-centered modal-sm" role="document">
        <div class="modal-content">
            <div class="modal-body p-0">
            <div class="card bg-secondary shadow border-0">
              <div class="card-header bg-white pb-5">
                <div class="text-muted text-center mb-3">
                </div>
                  <div style="justify-content: center !important">
                    <img width="250" height="100" style="position:relative; left:15%; top:15%; justify-content: center !important" src="<%=Help.FormatUrl("/assets/img/logo/white.png")%>"/>
                  </div>
              </div>
              <div class="card-body px-lg-5 py-lg-5">
                <div class="text-center text-muted mb-4">
                  <small>Login</small>
                </div>
                <div role="form" runat="server">
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
                  </div>
                </div>
              </div>
            </div>
            <div class="row mt-3">
              <div class="col-6">
                <a href="#" class="text-light">
                  <small>Forgot password?</small>
                </a>
              </div>
              <div class="col-6 text-right">
                <a href="#" class="text-light">
                  <small>Create new account</small>
                </a>
              </div>
            </div>
            </div>
        </div>
        </div>
    </div>
</div>