<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BioImpedanciaUsc.ascx.cs" Inherits="Warden.Component.UserControls.BioImpedancia.BioImpedanciaUsc" %>

<asp:Panel ID="pnl_control" runat="server">
    
      <div class="row">
        <div class="col-md-6">
          <div class="form-group">
              <usc:TextBoxUsc ID="txt_imc" runat="server" Icon="user" Placeholder="IMC"/>
          </div>
        </div>
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="txt_gordura" runat="server" Icon="collection" Placeholder="% Gordura"/>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="txt_massa" runat="server" Icon="run" Placeholder="% Massa Muscular"/>
          </div>
        </div>
        <div class="col-md-6">
          <div class="form-group">
            <div class="input-group mb-4">
              <usc:TextBoxUsc ID="txt_metabolismo" runat="server" Icon="wave" Placeholder="Metabolismo Basal"/>
            </div>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="txt_bioIdade" runat="server" Icon="atom" Placeholder="Idade Biológica"/>
          </div>
        </div>
        <div class="col-md-6">
          <div class="form-group">
            <usc:TextBoxUsc ID="txt_visceral" runat="server" Icon="support" Placeholder="Gordura Visceral"/>
          </div>
        </div>
      </div>
    
    <usc:ButtonUsc ID="btn_confirmar" runat="server" Text="Salvar"/>
</asp:Panel>