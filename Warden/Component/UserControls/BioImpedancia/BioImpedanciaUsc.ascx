<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BioImpedanciaUsc.ascx.cs" Inherits="Warden.Component.UserControls.BioImpedancia.BioImpedanciaUsc" %>

<asp:Panel ID="pnl_control" runat="server">
    <form>
      <div class="row">
        <div class="col-md-6">
          <div class="form-group">
              <usc:TextBoxUsc ID="txt_email" runat="server" Icon="user" Placeholder="IMC"/>
          </div>
        </div>
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="TextBoxUsc1" runat="server" Icon="collection" Placeholder="% Gordura"/>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="TextBoxUsc2" runat="server" Icon="run" Placeholder="% Massa Muscular"/>
          </div>
        </div>
        <div class="col-md-6">
          <div class="form-group">
            <div class="input-group mb-4">
              <usc:TextBoxUsc ID="TextBoxUsc3" runat="server" Icon="wave" Placeholder="Metabolismo Basal"/>
            </div>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="TextBoxUsc4" runat="server" Icon="atom" Placeholder="Idade Biológica"/>
          </div>
        </div>
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="TextBoxUsc5" runat="server" Icon="support" Placeholder="Gordura Visceral"/>
          </div>
        </div>
          <usc:ButtonUsc ID="btn_confirmar" runat="server" Text="Salvar"/>
      </div>
    </form>
</asp:Panel>