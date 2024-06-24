<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Visual.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Aca va el contenido de la web</h1>

    <%-- Carrusel de imagenes --%>
    <div id="carousel" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
<%--                <img src="C:\Users\Jesus Moreno\Downloads\1.PNG" class="d-block w-50" alt="...">--%>
                <asp:Image ID="imgBanner1" CssClass="d-block w-75" runat="server" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>First slide label</h5>
                    <p>Some representative placeholder content for the first slide.</p>
                </div>
            </div>
            <div class="carousel-item">
<%--                <img src="C:\Users\Jesus Moreno\Downloads\2.PNG" class="d-block w-50" alt="...">--%>
                <asp:Image ID="imgBanner2" CssClass="d-block w-75" runat="server" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>First slide label</h5>
                    <p>Some representative placeholder content for the first slide.</p>
                </div>
            </div>
            <div class="carousel-item">
<%--                <img src="C:\Users\Jesus Moreno\Downloads\3.PNG" class="d-block w-50" alt="...">--%>
                <asp:Image ID="imgBanner3" CssClass="d-block w-75" runat="server" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>First slide label</h5>
                    <p>Some representative placeholder content for the first slide.</p>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
