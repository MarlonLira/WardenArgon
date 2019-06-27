<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserProfileUsc.ascx.cs" Inherits="Warden.Component.UserControls.Form.UserProfileUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<asp:Panel ID="pnl_control" runat="server" >
     <div class="content">
        <div class="row">
            <div class="col-md-4">
            <div class="card card-user" style="background-color:lightgray">
                <div class="image">
                
                </div>
                <div class="card-body">
                <div class="author">
                    <a href="#">
                    <img class="avatar border-gray" style="width: 150px; height:150px" src="<%=Help.FormatUrl("/assets/img/default-avatar.png") %>" alt="...">

                    <usc:LabelUsc 
                        ID="lbl_aluno" 
                        runat="server" 
                        Text="Aluno" 
                        FontSize="10" 
                        Bold="true"
                    />  
                        
                    </a>

                    <usc:LabelUsc
                        Class="description text-center" 
                        runat="server" 
                        ID="lbl_limite_acesso"
                        Text="Dt.limite Acesso:"
                        FontSize="9"
                    />
                    
                </div>
                    
                    <usc:LabelUsc 
                        Class="description" 
                        runat="server" 
                        ID="lbl_plano" 
                        Text="Plano:" 
                        FontSize="8" 
                    />
                
                </div>
            </div>
        
            </div>
            <div class="col-md-8">
            <div class="card card-user">
                <div class="card-header" style="background-color:gray">
                    <h5 class="card-title"><b>Perfil</b></h5>
                </div>
                <div class="card-body" style="background-color:lightgray">
                <form style="justify-content:center">
                    <div class="row">
                    <div class="col-md-6 px-1">
                        <div class="form-group" style="text-align:left !important">
                            <usc:TextBoxUsc ID="txt_empresa" runat="server" Icon="company" Placeholder="Empresa" IsLabel="true" Label="Empresa"/>
                        </div>
                    </div>
                    <div class="col-md-6 px-1">
                        <div class="form-group">
                            <usc:TextBoxUsc ID="txt_matricula" runat="server" Icon="badge" Placeholder="Matricula" IsLabel="true" Label="Matricula"/>                       
                        </div>
                    </div>
                    </div>
                    <div class="row">
                    <div class="col-md-6 px-1">
                        <div class="form-group">
                            <usc:TextBoxUsc ID="txt_nome" runat="server" Icon="user" Placeholder="Aluno" IsLabel="true" Label="Aluno"/>  
                        </div>
                    </div>
                    <div class="col-md-6 px-1">
                        <div class="form-group">
                            <usc:TextBoxUsc ID="txt_email" runat="server" Icon="email" Placeholder="Email" IsLabel="true" Label="E-mail"/>   
                        </div>
                    </div>
                    </div>
                    <div class="row">
                    <div class="col-md-6 px-1">
                        <div class="form-group">
                            <usc:TextBoxUsc ID="txt_endereco" runat="server" Icon="adress" Placeholder="Endereço" IsLabel="true" Label="Endereço"/>   
                        </div>
                    </div>
                    <div class="col-md-6 px-1">
                        <div class="form-group">
                            <usc:TextBoxUsc ID="txt_cep" runat="server" Icon="cep" Placeholder="CEP" IsLabel="true" Label="CEP"/> 
                        </div>
                    </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 px-1">
                            <div class="form-group">
                                <usc:TextBoxUsc ID="txt_etapa" runat="server" Icon="city" Placeholder="Etapa" IsLabel="true" Label="Etapa"/>  
                            </div>
                        </div>
                        <div class="col-md-4 px-1">
                            <div class="form-group">
                                <usc:TextBoxUsc ID="txt_data" runat="server" Icon="world" Placeholder="dd/MM/YYYY" IsLabel="true" Label="Data"/>
                            </div>
                        </div>
                        <div class="col-md-4 px-1">
                            <div class="form-group">
                                <usc:TextBoxUsc ID="txt_professor" runat="server" Icon="cep" Placeholder="Professor" IsLabel="true" Label="Professor"/>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                    <div class="col-md-12 px-1">
                        <div class="form-group">
                        <usc:TextBoxUsc ID="txt_observacao" runat="server" Icon="SATISFIED" Placeholder="Observação" TextMode="MultiLine" IsLabel="true" Label="Observação"/>
                        </div>
                    </div>
                    </div>
                </form>
                </div>
            </div>
            </div>
        </div>
    </div>
</asp:Panel>