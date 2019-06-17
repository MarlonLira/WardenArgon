<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TableUsc.ascx.cs" Inherits="Warden.Component.Common.Table.TableUsc" %>

<div class="col-md-12">
    <div class="card card-plain">
        <div class="card-header">
        <h4 class="card-title"> Pesquisa de Alunos</h4>
        <p class="card-category"> Pesquise pelo nome e copie a matricula</p>
        </div>
        <div class="card-body">
        <div class="table-responsive">
            <asp:Table ID="tbl_control" runat="server" class="table"> 
                <asp:TableHeaderRow CssClass=" text-primary" ID="tbh_control">
                </asp:TableHeaderRow>
                <asp:TableRow ID="tbr_control">
                </asp:TableRow>
            </asp:Table>
        </div>
        </div>
    </div>
</div>