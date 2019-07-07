<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CardUsc.ascx.cs" Inherits="Warden.Component.Common.Card.CardUsc" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Warden.Component.Common.Table" %>


<div class="col-md-4">
    <%
        String[] MatriculaPart = Matricula.Replace(" ", ""). Split(':');
        DataTable AlunoTable = ComentariosAluno(MatriculaPart[1], Convert.ToString(this.EmpresaId));

        TableColumns = new List<TableUsc.TableColumnUsc>();
        TableColumns.Add(new TableUsc.TableColumnUsc() { ColumText = "Ult. Comentarios", ColumName = "codigo" });
        

        this.ID = MatriculaPart[1];
        modal_control.AlunoEdit = this.AlunoEdit;
        modal_control.CarregarAluno();
        modal_control.ID = MatriculaPart[1];
        modal_control.Aluno = Aluno;
        modal_control.LoadTable(AlunoTable, TableColumns);

        if (IsModal == true) {
        %>
            <usc:UserCommentsUsc runat="server" ID="modal_control"/>
    <%  } %>
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
            <button type="button" class="btn btn-sm btn-outline-secondary" data-toggle="modal" data-target="#modal-<%=MatriculaPart[1] %>">

            <usc:LabelUsc 
                Class="description" 
                runat="server" 
                ID="btn1" 
                Text="Comentarios" 
                FontSize="8" 
             />

            </button>
            <button type="button" class="btn btn-sm btn-outline-secondary">Edit</button>
        </div>
        <small class="text-muted"><%=LoadTime()%></small>
        </div>
    </div>
    </div>
</div>

