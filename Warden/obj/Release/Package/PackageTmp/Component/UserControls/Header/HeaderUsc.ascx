<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderUsc.ascx.cs" Inherits="Warden.Component.UserControls.Header.HeaderUsc" %>
<%@ Import Namespace="Warden.Helper" %>

<% if(Session["User"] != null)
        if ((Boolean)Session["User"] == true) {
            String LogoUrl = "";
            String DefaultUrl = "";
            String LogoMobileUrl = "";
            String CurrentSessionApp = "";

            if (Session["App"] != null) {
                CurrentSessionApp = Convert.ToString(Session["App"]);
            }

            switch (CurrentSessionApp.ToUpper()) {
                case "2GETHER": {
                        DefaultUrl = Help.FormatUrl("/Views/Default.aspx");
                        LogoUrl = Help.FormatUrl("/assets/img/logo/white6.png");
                        LogoMobileUrl = Help.FormatUrl("/assets/img/logo/white.png");
                        ofertas_control.Visible = false;
                        atendimento_control.Url = "/Views/Fitness/Colaborador/Atendimento.aspx";
                        graficos_control.Visible = false;
                        calendar_control.Visible = false;
                        etapas_control.Visible = false;
                        break;
                    }
                case "ARGON": {
                        DefaultUrl = Help.FormatUrl("/Views/Telemarketing/Colaborador/Atendimento.aspx");
                        LogoUrl = Help.FormatUrl("/assets/img/brand/white.png");
                        LogoMobileUrl = Help.FormatUrl("/assets/img/brand/blue.png");
                        atendimento_control.Url = "/Views/Telemarketing/Colaborador/Atendimento.aspx";
                        etapas_control.Visible = false;
                        graficos_control.Visible = false;
                        calendar_control.Visible = false;
                        break;
                    }
                default: {
                        DefaultUrl = Help.FormatUrl("/Views/Default.aspx");
                        LogoUrl = Help.FormatUrl("/assets/img/logo/white6.png");
                        LogoMobileUrl = Help.FormatUrl("/assets/img/logo/white.png");
                        break;
                    }
            }

            %>
<header class="header-global" style="background-color:black !important">
    <nav id="navbar-main" class="navbar navbar-main navbar-expand-lg navbar-transparent navbar-light headroom">
        <div class="container">
        <a class="navbar-brand mr-lg-5" href=" <%=DefaultUrl %>">
            <img src="<%=LogoUrl %>" style="width: 120px; height: 50px">
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbar_global" aria-controls="navbar_global" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="navbar-collapse collapse" id="navbar_global">
                <div class="navbar-collapse-header">
                <div class="row">
                    <div class="col-6 collapse-brand" >
                    <a href="<%=DefaultUrl %>">
                        <img src="<%=LogoMobileUrl %>">
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
                            ID="calendar_control" 
                            runat="server" 
                            Icon="date" 
                            Title="Calendario"
                            Description="Aqui Você marca o dia do atendimento com o aluno" 
                            Url="/Views/Fitness/Colaborador/Calendar.aspx" 
                        />

                        <usc:MenuButtonUsc 
                            ID="ofertas_control" 
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
                        <a href="#" class="dropdown-item">
                            <usc:ButtonUsc 
                                ID="btn_sair" 
                                runat="server" 
                                Text="Sair"
                            />
                        </a>
                    </div>
                </li>
                </ul>
            </div>
        </div>
    </nav>
</header>
<%  } %>