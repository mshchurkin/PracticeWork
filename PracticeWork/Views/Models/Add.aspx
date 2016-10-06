<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Model>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Добавить модель
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Добавить новую модель</h2>
    <% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Модели</legend>

        <div class="editor-label">
            <%: Html.Label("Введите название")%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Name) %>
            <%: Html.ValidationMessageFor(model => model.Name) %>
        </div>

        <div class="editor-label">
            <%: Html.Label("Введите описание") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Description) %>
            <%: Html.ValidationMessageFor(model => model.Description) %>
        </div>
        <p>
            <input type="submit" value="Создать" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Назад", "ModelsCollection") %>
</div>


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
     <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
