<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Device>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Результаты выборки
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Выборка карт с пропускной способностью выше заданной</h2>
    <% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Модели</legend>


        <div class="editor-label">
            <%: Html.Label("Введите скорость соединения")%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model =>model.ConnectionSpeed) %>
            <%: Html.ValidationMessageFor(model => model.ConnectionSpeed) %>
        </div>
        <p>
            <input type="submit" value="Выбрать" />
        </p>
        </fieldset>
<% } %>
     <div>
    <%: Html.ActionLink("Отмена", "Modelback") %>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
