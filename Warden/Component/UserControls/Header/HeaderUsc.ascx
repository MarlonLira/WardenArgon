<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderUsc.ascx.cs" Inherits="Warden.Component.UserControls.Header.HeaderUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<% if(Session["User"] != null)
    if ((Boolean)Session["User"] == true) {%>
<header class="header-global" style="background-color:black !important">
    <nav id="navbar-main" class="navbar navbar-main navbar-expand-lg navbar-transparent navbar-light headroom">
        <div class="container">
        <a class="navbar-brand mr-lg-5" href=" <%=Help.FormatUrl("/Views/Default.aspx") %>">
            <img src="<%=Help.FormatUrl("/assets/img/logo/white6.png") %>" style="width: 120px; height: 50px">
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbar_global" aria-controls="navbar_global" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="navbar-collapse collapse" id="navbar_global">
                <div class="navbar-collapse-header">
                <div class="row">
                    <div class="col-6 collapse-brand" >
                    <a href="<%=Help.FormatUrl("Views/Default.aspx") %>">
                        <img src="<%=Help.FormatUrl("/assets/img/logo/white.png") %>">
                    </a>
                    </div>
                    <div class="col-6 collapse-close">
                    <button type="button" class="navbar-toggler" data-toggle="collapse" data-target="#navbar_global" aria-controls="navbar_global" aria-expanded="false" aria-label="Toggle navigation">
                        <span></span>
                        <span></span>
                    </button>
                    </div>
                </div>
                </div>
                <ul class="navbar-nav navbar-nav-hover align-items-lg-center">
                <li class="nav-item dropdown">
                    <a href="#" class="nav-link" data-toggle="dropdown" href="#" role="button">
                    <i class="ni ni-ui-04 d-lg-none"></i>
                    <span class="nav-link-inner--text">Acompanhamento</span>
                    </a>
                    <div class="dropdown-menu dropdown-menu-xl">
                    <div class="dropdown-menu-inner">

                        <usc:MenuButtonUsc 
                            ID="atendimento_control" 
                            runat="server" 
                            Type="1"
                            Icon="phone" 
                            Title="Atendimentos" 
                            Description="Todos seus alunos marcados para hoje" 
                            Url="/Views/Fitness/Colaborador/Atendimento.aspx" 
                        />

                        <usc:MenuButtonUsc 
                            ID="etapas_control" 
                            runat="server"
                            Type="2"
                            Icon="spaceship" 
                            Title="Etapas" 
                            Description="Etapas dos alunos..." 
                            Url="/Views/Fitness/Etapas.aspx" 
                        />

                        <usc:MenuButtonUsc 
                            ID="graficos_control" 
                            runat="server"
                            Type="3"
                            Icon="palette" 
                            Title="Graficos" 
                            Description="Aqui você vera graficos relacionado a um determinado aluno" 
                            Url="/Views/Fitness/Graficos.aspx" 
                        />

                        <usc:MenuButtonUsc 
                            ID="leads_control" 
                            runat="server" 
                            Icon="date" 
                            Title="Calendario"
                            Description="Aqui Você marca o dia do atendimento com o aluno" 
                            Url="/Views/Fitness/Colaborador/Calendar.aspx" 
                        />

                        <usc:MenuButtonUsc 
                            ID="MenuButtonUsc1" 
                            runat="server" 
                            Icon="ui" 
                            Title="Ofertas"
                            Description="Ofertas" 
                            Url="/Views/Telemarketing/Ofertas.aspx" 
                        />
                        
                    </div>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="nav-link" data-toggle="dropdown" href="#" role="button">
                    <i class="ni ni-collection d-lg-none"></i>
                    <span class="nav-link-inner--text">Configurações</span>
                    </a>
                    <div class="dropdown-menu">
                    <a href="#" class="dropdown-item">Perfil</a>
                    <a href="#" class="dropdown-item">Login</a>
                    <a href="#" class="dropdown-item">Registro</a>
                    </div>
                </li>
                </ul>
            </div>
        </div>
    </nav>
</header>
<%  } %>