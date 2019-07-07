<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserCommentsUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserCommentsUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<div class="col-md-6">
    <div class="modal fade" id="modal-<%=this.ID %>" tabindex="-1" role="dialog" aria-labelledby="modal-form" aria-hidden="true">
    <div class="modal-dialog modal- modal-dialog-centered modal-sm" role="document">
        <div class="modal-content">
            <div class="modal-body p-0">
            <div class="card bg-secondary shadow border-0">
              <div class="card-header bg-black pb-5" style="text-align:center">
                <div class="text-muted text-center mb-3">
                </div>
                  <h2 style="color:black">Aluno: <%=this.Aluno %></h2>
              </div>
              <div class="card-body px-lg-5 py-lg-5">
                <usc:TableUsc runat="server" ID="tbl_comments" IsTmk="true"/>
                  <div class="form-group">

                      <usc:TextBoxUsc 
                          ID="txt_tel"
                          runat="server" 
                          Text="Telefone Não Encontrado"
                          TextMode="Phone"
                          IsLabel="true" 
                          Label="Telefone"
                          LabelSize="10"
                          ReadOnly="false"  
                          Icon="phone" 
                        />

                      <usc:TextBoxUsc 
                          ID="txt_email"
                          runat="server" 
                          Text="Email Não Encontrato" 
                          IsLabel="true" 
                          Label="E-mail"
                          LabelSize="10"
                          ReadOnly="true"  
                          Icon="email" 
                        />

                      <a target='_blank' href="<%=Href %>">
                            <usc:TextBoxUsc 
                                ID="txt_link"
                                runat="server" 
                                Text="Clique Aqui" 
                                IsLabel="true" 
                                Label="Whats App Link"
                                LabelSize="10"
                                ReadOnly="true"  
                                Icon="spaceship" 
                            />

                      </a>

                        <usc:TextBoxUsc 
                            ID="txt_comentario" 
                            runat="server"
                            Icon="ATOM"
                            IsLabel="true" 
                            Label="Comentarios"
                            LabelSize="10"
                            Placeholder="Comentario" 
                            TextMode="MultiLine"
                            TextRow="3"
                        />
                  </div>
                  <div class="text-center">
                      <br />
                      <usc:ButtonUsc ID="btn_salvar" runat="server" Text="Salvar"/>
                      <br />
                  </div>
                    <div style="padding-top: 10px; padding-bottom: 5px">
                        <small class="text-muted">Horario de Atendimento: <%=LoadTime()%></small>
                    </div>
                </div>
            </div>
            </div>
        </div>
        </div>
    </div>
</div>