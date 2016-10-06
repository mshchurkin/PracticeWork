<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Queue>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Добавить очередь исполнения
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Добавить очередь исполнения</h2>
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
            <%: Html.EditorFor(model => model.ConnectionSpeed) %>
            <%: Html.ValidationMessageFor(model => model.ConnectionSpeed) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Device) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("Device") %>
            <%: Html.ValidationMessageFor(model => model.Device) %>
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
