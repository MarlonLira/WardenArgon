<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CardUsc.ascx.cs" Inherits="Warden.Component.Common.Card.CardUsc" %>

<div class="col-md-4">
    <div class="card mb-4 box-shadow">
    <a href="<%=LoadRef() %>"><img class="<%=LoadClass() %>" src="<%=LoadImg() %>"  alt="Card image cap"></a>
    <div class="card-body">
        <p class="card-text">
            <usc:LabelUsc 
                ID="lbl_aluno" 
                runat="server" 
                Text="Aluno" 
                FontSize="10" 
                Bold="true"
            />  

            <usc:LabelUsc
                Class="description text-center" 
                runat="server" 
                ID="lbl_data"
                Text="Dt.Avaliação:"
                FontSize="9"
            /> 
                    
            <usc:LabelUsc 
                Class="description" 
                runat="server" 
                ID="lbl_matricula" 
                Text="Matricula:" 
                FontSize="8" 
            />



        </p>
        <div class="d-flex justify-content-between align-items-center">
        <div class="btn-group">
            <button type="button" class="btn btn-sm btn-outline-secondary">View</button>
            <button type="button" class="btn btn-sm btn-outline-secondary">Edit</button>
        </div>
        <small class="text-muted"><%=LoadTime()%></small>
        </div>
    </div>
    </div>
</div>

