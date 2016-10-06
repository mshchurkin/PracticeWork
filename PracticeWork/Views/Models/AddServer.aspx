<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Server>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Добавить сервер
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Добавить сервер</h2>
    <% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Модели</legend>

         <%: Html.HiddenFor(model =>model.Id) %>

        <div class="editor-label">
            <%: Html.Label("Введите название")%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Name) %>
            <%: Html.ValidationMessageFor(model => model.Name) %>
        </div>
        <div class="editor-label">
            <%: Html.Label("Введите объем оперативной памяти") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.RAM) %>
            <%: Html.ValidationMessageFor(model => model.RAM) %>
        </div>
                <div class="editor-label">
            <%: Html.Label("Введите объем хранилища") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Memory) %>
            <%: Html.ValidationMessageFor(model => model.Memory) %>
        </div>
                <div class="editor-label">
            <%: Html.Label("Введите скорость подключения") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ConnectionSpeed) %>
            <%: Html.ValidationMessageFor(model => model.ConnectionSpeed) %>
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
</asp:Content>
