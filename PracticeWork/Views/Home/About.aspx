<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About - My ASP.NET MVC Application
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>О приложении.</h1>
    </hgroup>

    <article>
        <p>
            Репозиторий имитационных моделей
        </p>

        <p>
            Практическая работа
        </p>

        <p>
            2 курс
        </p>
    </article>
</asp:Content>