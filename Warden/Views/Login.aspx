<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Warden.Views.Login" %>
<%@ Import Namespace="Warden.Helper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Warden</title>
    <!-- Favicon -->
  <link href="<%=Help.FormatUrl("/assets/img/brand/favicon.png") %>" rel="icon" type="image/png"/>
  <!-- Fonts -->
  <link type="text/css" href="<%=Help.FormatUrl("/assets/css/opensans.css") %> rel="stylesheet"/>
  <!-- Icons -->
  <link href="<%=Help.FormatUrl("/assets/vendor/nucleo/css/nucleo.css") %>" rel="stylesheet"/>
  <link href=" <%=Help.FormatUrl("/assets/vendor/font-awesome/css/font-awesome.min.css") %>" rel="stylesheet"/>
  <!-- Argon CSS -->
  <link type="text/css" href="<%=Help.FormatUrl("/assets/css/argon.css?v=1.0.1") %>"  rel="stylesheet"/>
  <!-- Docs CSS -->
  
</head>
<body style=" justify-content:center">
    <main >
    <section class="section section-shaped section-lg">
      <div class="shape shape-style-1" style="background-color: black">
      </div>
      <div class="container pt-lg-md">
        <div class="row justify-content-center">
          <div class="col-lg-5">
            <div class="card bg-secondary shadow border-0">
              <div class="card-header bg-white pb-5">
                <div class="text-muted text-center mb-3">
                </div>
                  <div style="justify-content: center !important">
                    <img width="250" height="100" style="position:relative; left:15%; top:15%; justify-content: center !important" src="<%=Help.FormatUrl("/assets/img/logo/white.png")%>"/>
                  </div>
              </div>
              <div class="card-body px-lg-5 py-lg-5">
                <div class="text-center text-muted mb-4">
                  <small>Login</small>
                </div>
                <form role="form" runat="server">
                  <div class="form-group mb-3">
                    <usc:TextBoxUsc ID="txt_email" runat="server" Icon="email" Placeholder="CPF"/>
                  </div>
                  <div class="form-group">
                    <usc:TextBoxUsc ID="txt_password" runat="server" Icon="password" Placeholder="Senha" TextMode="Password"/>
                  </div>
                  <div class="custom-control custom-control-alternative custom-checkbox">
                    <input class="custom-control-input" id=" customCheckLogin" type="checkbox">
                    <label class="custom-control-label" for=" customCheckLogin">
                      <span>Remember me</span>
                    </label>
                  </div>
                  <div class="text-center">
                      <br />
                      <usc:ButtonUsc ID="ButtonUsc" runat="server" Text="Confirmar"/>
                  </div>
                </form>
              </div>
            </div>
            <div class="row mt-3">
              <div class="col-6">
                <a href="#" class="text-light">
                  <small>Forgot password?</small>
                </a>
              </div>
              <div class="col-6 text-right">
                <a href="#" class="text-light">
                  <small>Create new account</small>
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  </main>
    <!-- Core -->
      <script src="<%=Help.FormatUrl("/assets/vendor/jquery/jquery.min.js") %>"></script>
      <script src="<%=Help.FormatUrl("/assets/vendor/popper/popper.min.js") %>"></script>
      <script src="<%=Help.FormatUrl("/assets/vendor/bootstrap/bootstrap.min.js") %>"></script>
      <script src="<%=Help.FormatUrl("/assets/vendor/headroom/headroom.min.js") %>"></script>
    <!-- Argon JS -->
      <script src="<%=Help.FormatUrl("/assets/js/argon.js?v=1.0.1") %>></script>
</body>
</html>
