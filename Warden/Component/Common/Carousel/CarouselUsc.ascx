<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CarouselUsc.ascx.cs" Inherits="Warden.Component.Common.Carousel.CarouselUsc" %>
<%@ Import Namespace="Warden.Helper" %>
<%@ Import Namespace="System.Data" %>


<div id="myCarousel" class="carousel slide" data-ride="carousel">
    <ol class="carousel-indicators">
    <% 
        Int32 Count = 0;
        String Type = "";
        while (Count <= Itens.Length) {

            if (Count == 0) {
                Type = "active";
            } else {
                Type = "";
            }

    %>
            <li data-target="#myCarousel<%=Count %>" data-slide-to="<%=Count %>" class="<%=Type %>"></li>
    <%

            Count++;
        } %>
        
    </ol>
    <div class="carousel-inner">

        <%
            foreach (Image Img in Itens) {
                
                %>
        <div class="carousel-item active">
            <img class="first-slide" src="<%=Img.Url %>" alt="First slide">
            <div class="container">
                <div class="carousel-caption text-left">
                <h1><%=Img.Title %></h1>
                <p><%=Img.Text %></p>
                <p><a class="btn btn-lg btn-primary" href="#" role="button">Tenho interesse</a></p>
                </div>
            </div>
        </div>
        <%} %>
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