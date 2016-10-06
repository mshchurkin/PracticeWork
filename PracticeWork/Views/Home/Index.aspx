<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Репозиторий имитационных моделей
</asp:Content>

<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Домашняя страница</h1>
            </hgroup>
            <p>
                <%if (HttpContext.Current.User.Identity.IsAuthenticated==false){ %>
                Войдите или зарегестрируйтесь, чтобы начать работать с БД
                <% }%>
                   <%else{%>
                Перейдите по вкладке Модели, чтобы начать работать с базой данных
                 <% } %>
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
