<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AttendanceDateUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.AttendanceDateUsc" %>


<div class="col-md-20">
    <!--div class="modal fade" id="modal-attendance" tabindex="-1" role="dialog" aria-labelledby="modal-form" aria-hidden="true"-->
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
                  <small>Marcar Atendimento</small>
                </div>
                <div role="form" runat="server">   
                    <div class="row" style="justify-content:center">
                        <div style="padding-right:15px; padding-bottom:15px">
                            <usc:CalendarUsc runat="server" ID="calendar_control" />
                        </div>
                        <div style="padding-bottom:15px">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Text="Horarios Disponiveis" Selected="True"></asp:ListItem>
                                <asp:ListItem Text="13:00"></asp:ListItem>
                                <asp:ListItem Text="14:30"></asp:ListItem>
                                <asp:ListItem Text="16:00"></asp:ListItem>
                                <asp:ListItem Text="17:00"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem Text="Professores Disponiveis" Selected="True"></asp:ListItem>
                                <asp:ListItem Text="Zé"></asp:ListItem>
                                <asp:ListItem Text="Zimba"></asp:ListItem>
                                <asp:ListItem Text="Zoro"></asp:ListItem>
                                <asp:ListItem Text="Zize"></asp:ListItem>
                            </asp:DropDownList>
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
        <!--</div> -->
    </div>
</div> 