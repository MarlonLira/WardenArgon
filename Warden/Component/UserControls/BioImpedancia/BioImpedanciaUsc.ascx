<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BioImpedanciaUsc.ascx.cs" Inherits="Warden.Component.UserControls.BioImpedancia.BioImpedanciaUsc" %>


<div class="form-element-area">
    <div class="container">
        <div class="row">
            <div class="col-lg-10 col-md-10 col-sm-10 col-xs-10">
                <div class="form-element-list mg-t-30">
                    <div class="cmp-tb-hd">
                        <h4>Informações da Bioimpedância</h4>
                    </div>
                    <div class="row">
                        <usc:TextBoxUsc runat="server" ID="txt_imc" Placeholder="IMC"  />

                        <usc:TextBoxUsc runat="server" ID="txt_gordura" Placeholder="% Gordura" />

                        <usc:TextBoxUsc runat="server" ID="txt_massa" Placeholder="% Massa Muscular"/>
                    </div>

                    <div class="row">

                        <usc:TextBoxUsc runat="server" ID="txt_metabolismo" Placeholder="Metabolismo Basal"/>

                        <usc:TextBoxUsc runat="server" ID="txt_biologica" Placeholder="Idade Biológica"/>

                        <usc:TextBoxUsc runat="server" ID="txt_visceral" Placeholder="Gordura Visceral"/>

                    </div>

                    <div class="row">
                        <usc:TextBoxUsc runat="server" ID="txt_peso" Placeholder="Peso" />

                        <usc:TextBoxUsc runat="server" ID="txt_altura" Placeholder="Altura"/>
                        
                    </div>
                    <usc:ButtonUsc runat="server" ID="btn_confirmar" Text="Salvar" OnClick="btnConfirmar_Click"/>
                </div>
            </div>
        </div>
    </div>
</div>