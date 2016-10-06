<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Connection>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Добавить соединение
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Добавить соединение</h2>
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
            <%: Html.Label("Введите скорость подключения") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Description) %>
            <%: Html.ValidationMessageFor(model => model.Description) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.D1) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("D1") %>
            <%: Html.ValidationMessageFor(model => model.D1) %>
        </div>
                <div class="editor-label">
            <%: Html.LabelFor(model => model.D2) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("D2") %>
            <%: Html.ValidationMessageFor(model => model.D2) %>
        </div>
        <p>
            <input type="submit" value="Добавить" />
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
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
