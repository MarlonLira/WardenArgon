<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUsc.ascx.cs" Inherits="Warden.Component.UserControls.Login.LoginUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<div class="col-md-6">
    <div class="modal fade" id="modal-portal" tabindex="-1" role="dialog" aria-labelledby="modal-form" aria-hidden="true">
    <div class="modal-dialog modal- modal-dialog-centered modal-sm" role="document">
        <div class="modal-content">
            <div class="modal-body p-0">
            <div class="card bg-secondary shadow border-0">
              <div class="card-header bg-white pb-5">
                <div class="text-muted text-center mb-3">
                </div>
                  <div style="justify-content: center !important">
                    <img  style="position:relative; justify-content: center !important" src="<%=Help.FormatUrl("/assets/img/bg/1.png")%>"/>
                  </div>
              </div>
              <div class="card-body px-lg-5 py-lg-5">
                  <div class="text-center">
                      <br />
                      <div class="row">
                          <usc:ButtonUsc ID="btn_hi" runat="server" Text="Hi Academia" Type="default"/>
                      
                          <usc:ButtonUsc ID="btn_hix" runat="server" Text="Hix Academia" Type="default"/>
                      </div>
                      <br />
                      <usc:LabelUsc runat="server" Bold="true" FontSize="10" Color="red" ID="lbl_erro"/>
                  </div>
                </div>
              
            </div>
            </div>
        </div>
        </div>
    </div>
</div>