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
                        <a href="<%=Help.FormatUrl("/Views/Fitness/Etapas.aspx") %>" class="media d-flex align-items-center">
                        <div class="icon icon-shape bg-gradient-primary rounded-circle text-white">
                            <i class="ni ni-spaceship"></i>
                        </div>
                        <div class="media-body ml-3">
                            <h6 class="heading text-primary mb-md-1">Etapas</h6>
                            <p class="description d-none d-md-inline-block mb-0">Cadastre as informações do seu aluno aqui.</p>
                        </div>
                        </a>
                        <a href="<%=Help.FormatUrl("/Views/Fitness/Graficos.aspx") %>" class="media d-flex align-items-center">
                        <div class="icon icon-shape bg-gradient-success rounded-circle text-white">
                            <i class="ni ni-palette"></i>
                        </div>
                        <div class="media-body ml-3">
                            <h6 class="heading text-primary mb-md-1">Graficos</h6>
                            <p class="description d-none d-md-inline-block mb-0">Aqui você vera graficos relacionado a um determinado aluno</p>
                        </div>
                        </a>
                        <a href="<%=Help.FormatUrl("/Views/Telemarketing/ContactLeads.aspx") %>" class="media d-flex align-items-center">
                        <div class="icon icon-shape bg-gradient-warning rounded-circle text-white">
                            <i class="ni ni-ui-04"></i>
                        </div>
                        <div class="media-body ml-3">
                            <h5 class="heading text-warning mb-md-1">Leads</h5>
                            <p class="description d-none d-md-inline-block mb-0">....Leads</p>
                        </div>
                        </a>
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