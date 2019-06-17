<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TableUsc.ascx.cs" Inherits="Warden.Component.Common.Table.TableUsc" %>

<div class="col-md-12">
    <div class="card card-plain">
        <div class="card-header">
        <h4 class="card-title"> Pesquisa de Alunos</h4>
        <p class="card-category"> Pesquise pelo nome e copie a matricula</p>
        </div>
        <div class="card-body">
        <div class="table-responsive">
            <asp:Table ID="tbl_control" runat="server" class="table" Font-Bold="true"> 
                <asp:TableHeaderRow CssClass=" text-primary">
                    <asp:TableCell Text="Nome"></asp:TableCell>
                    <asp:TableCell Text="Matricula"></asp:TableCell>
                    <asp:TableCell Text="Email"></asp:TableCell>
                </asp:TableHeaderRow>
                <asp:TableRow Font-Bold="false">
                    
                </asp:TableRow>
            </asp:Table>
        </div>
        </div>
    </div>
</div>