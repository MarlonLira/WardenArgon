<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormLeadsUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.FormLeadsUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<div class="col-md-6">
    <div class="modal fade" id="modal-leads" tabindex="-1" role="dialog" aria-labelledby="modal-form" aria-hidden="true">
    <div class="modal-dialog modal- modal-dialog-centered modal-sm" role="document">
        <div class="modal-content">
            <div class="modal-body p-0">
            <div class="card bg-secondary shadow border-0">
              <div class="card-header bg-black pb-5" style="text-align:center">
                <div class="text-muted text-center mb-3">
                </div>
                  <h2 style="color:black"><b style="color:red">Hi</b> Fitness Group</h2>
              </div>
              <div class="card-body px-lg-5 py-lg-5">
                <div class="text-center text-muted mb-4">
                  <small>Formulario</small>
                </div>
                <div role="form" runat="server">
                   <div class="form-group mb-3">
                        <usc:TextBoxUsc ID="txt_nome" runat="server" Icon="user" Placeholder="Nome"/>
                   </div>
                  <div class="form-group mb-3">
                        <usc:TextBoxUsc ID="txt_email" runat="server" Icon="email" Placeholder="Email"/>
                  </div>
                  <div class="form-group">
                        <usc:TextBoxUsc ID="txt_numero" runat="server" Icon="phone" Placeholder="(81) 9 8888-7777" TextMode="Phone"/>
                  </div>
                  <div class="form-group">
                        <usc:TextBoxUsc ID="txt_duvida" runat="server" Icon="ATOM" Placeholder="Tem alguma duvida ou sugestão ?" TextMode="MultiLine"/>
                  </div>
                  <div class="text-center">
                      <br />
                      <usc:ButtonUsc ID="ButtonUsc" runat="server" Text="Confirmar"/>
                      <br />
                  </div>
                </div>
              </div>
            </div>
            </div>
        </div>
        </div>
    </div>
</div>