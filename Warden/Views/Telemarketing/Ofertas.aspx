<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ofertas.aspx.cs" Inherits="Warden.Views.Telemarketing.Ofertas" %>

<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Hi Fitness Group</title>
      <usc:CssUsc runat="server" IsCarousel="true"/>  

  </head>

  <body style="background-color:dimgray">

    <header>
      <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
        <a class="navbar-brand" href="#">Hi Fitness Group</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarCollapse">
          <ul class="navbar-nav mr-auto">
            <li class="nav-item active">
              <a class="nav-link" href="#">Ofertas <span class="sr-only">(current)</span></a>
            </li>
          </ul>
            
          <form class="form-inline mt-2 mt-md-0">
            <input class="form-control mr-sm-2" type="text" placeholder="CEP" aria-label="Search">
            <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Pesquisar</button>
          </form>
        </div>
      </nav>
    </header>

    <main role="main">

      <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
          <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
          <li data-target="#myCarousel" data-slide-to="1"></li>
          <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
          <div class="carousel-item active">
            <img class="first-slide" src="https://hiacademia.com.br/site/img/welcome-slider/home-welcome-img_5.jpg" alt="First slide">
            <div class="container">
              <div class="carousel-caption text-left">
                <h1 style="color:black"><b style="color:red">Hi</b> Fitness Group</h1>
                <p><b>Matricule-se agora na maior rede de academias do nordeste !</b></p>
                <p><a class="btn btn-lg btn-primary" href="#" role="button">Tenho interesse</a></p>
              </div>
            </div>
          </div>
          <div class="carousel-item">
            <img class="second-slide" src="https://hiacademia.com.br/site/img/welcome-slider/home-welcome-img_4.jpg" alt="Second slide">
            <div class="container">
              <div class="carousel-caption">
                <h1 style="color:black"><b style="color:red">Hi</b> Fitness Group</h1>
                <p><b>Focamos no seu resultado e na sua satisfação com profissionais altamente capacitados</b></p>
                <p><a class="btn btn-lg btn-primary" href="#" role="button">Tenho interesse</a></p>
              </div>
            </div>
          </div>
          <div class="carousel-item">
            <img class="third-slide" src="https://hiacademia.com.br/site/img/welcome-slider/home-welcome-img_2.jpg" alt="Third slide">
            <div class="container">
              <div class="carousel-caption text-right">
                <h1 style="color:black"><b style="color:red">Hi</b> Fitness Group</h1>
                <p><b> esperando o que para ter um corpo saudavel ? clique agora em "Tenho interesse" e venha conhecer nossa rede de academias</b></p>
                <p><a class="btn btn-lg btn-primary" href="#" role="button">Tenho interesse</a></p>
              </div>
            </div>
          </div>
        </div>
        <a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="sr-only">Anterior</span>
        </a>
        <a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="sr-only">Proximo</span>
        </a>
      </div>


      <!-- Marketing messaging and featurettes
      ================================================== -->
      <!-- Wrap the rest of the page in another container to center all the content. -->

      <div class="container marketing box-shadow" style="background-color:lightgray">

        <!-- Three columns of text below the carousel -->
          <h2 class="featurette-heading" style="text-align:center; padding-top:15px" >

              <usc:LabelUsc runat="server" Class="featurette-heading" FontSize="35" Text="Unidades"/>

          </h2>
          
          <br />
          <br />
          <form runat="server">
            <usc:FormLeadsUsc runat="server" />
         </form>
        <div class="row">
            
            <usc:RoundButtonUsc 
                runat="server" 
                BtnText="Quero Conhecer"
                Title="Hi Tamarineira"
                Text="Endereço: Estr. do Arraial, 2262 - Tamarineira, Recife - PE, 52051-380"
                UrlImg="https://lh5.googleusercontent.com/p/AF1QipN63hvrYF_AXDDDAslVXwWX5EmGNrkDK-7avLbt=w120-h160-k-no"
            />

            <usc:RoundButtonUsc 
                runat="server" 
                BtnText="Quero Conhecer"
                Title="Hi Espinheiro"
                Text="Endereço: R. Barão de Itamaracá, 54 - Espinheiro, Recife - PE, 52020-070"
                UrlImg="https://lh5.googleusercontent.com/p/AF1QipM4iA0MeEkUIX22iw1NxgzEYCeNZfbhG6b9fjGf=w120-h160-k-no"
            />

            <usc:RoundButtonUsc 
                runat="server" 
                BtnText="Quero Conhecer"
                Title="Hi Encruzilhada"
                Text="Endereço: Estr. de Belém, 600 - Encruzilhada, Recife - PE, 52030-000"
                UrlImg="https://lh5.googleusercontent.com/p/AF1QipN4YNlUIlXNFAC_FtgSLjWP_A95rh_7i3RsvrL5=w90-h160-k-no"
            />

            <usc:RoundButtonUsc 
                runat="server" 
                BtnText="Quero Conhecer"
                Title="Hix Arruda"
                Text="Endereço: R. Zeferino Agra, 519 - Arruda, Recife - PE, 52120-180"
                UrlImg="https://lh5.googleusercontent.com/p/AF1QipPkVnsmbWcib0rt_VfPWDsfycKFwvS1Zn1J-omX=w90-h160-k-no"
            />

        <!-- START THE FEATURETTES -->

        <hr class="featurette-divider">

        <div class="row featurette">
          <div class="col-md-7">
            <h2 class="featurette-heading">Hi Academia </h2>
              <h3><span class="text-muted"> Academias de alto porte</span></h3>
            <p class="lead">Academias com a melhor estrutura que você encontrara no nordeste, desde professores super capacitados a maquinarios impecaveis! ta esperando o q ?</p>
          </div>
          <div class="col-md-5">
            <img class="featurette-image img-fluid mx-auto" src="https://hiacademia.com.br/ofertas/img/HiCopaAmerica9490.png" alt="Generic placeholder image">
          </div>
        </div>

        <hr class="featurette-divider">

        <div class="row featurette">
          <div class="col-md-7 order-md-2">
            <h2 class="featurette-heading">Hix Academia</h2>
              <h3><span class="text-muted"> Academias que cabem no seu bolso</span></h3>
            <p class="lead">Academias que cabem no seu bolso e contam com uma gama de profissionais a seu dispor, além de um quadro de aula impecavel!, Vem logo !</p>
          </div>
          <div class="col-md-5 order-md-1">
            <img class="featurette-image img-fluid mx-auto" src="https://hixacademia.com.br/ofertas/img/HixCopaAmerica5490.png" alt="Generic placeholder image">
          </div>
        </div>

        <hr class="featurette-divider">

        <div class="row featurette">
          <div class="col-md-7">
            <h2 class="featurette-heading">Hi Gold </h2>
              <h3><span class="text-muted"> Quer mais ?</span></h3>
            <p class="lead">Ainda não se convenceu ? quer mais ? calma temos o que você quer, que tal malhar em qualquer academia da nossa rede, esse plano foi feito pra você! </p>
          </div>
          <div class="col-md-5">
            <img class="featurette-image img-fluid mx-auto" src="https://hiacademia.com.br/ofertas/img/HiCopaAmerica9490.png" alt="Generic placeholder image">
          </div>
        </div>

        <hr class="featurette-divider">

        <!-- /END THE FEATURETTES -->
        </div>
      </div><!-- /.container -->


      <!-- FOOTER -->
      <footer class="container" style="background-color:lightgray">
        <p class="float-right"><a href="#"> Back to top</a></p>
        <p>&copy; 2019 Hi Fitness Group &middot; <a href="#">Privacy</a> &middot; <a href="#">Terms</a></p>
      </footer>
    </main>

   <usc:JsUsc runat="server" />
  </body>
</html>
