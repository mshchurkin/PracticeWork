<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Routine>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Изменить параметры рутины
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Изменить параметры рутины</h2>
    <% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>рутины</legend>
        <%: Html.HiddenFor(model =>model.Id) %>
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
            <%: Html.EditorFor(model => model.Function) %>
            <%: Html.ValidationMessageFor(model => model.Function) %>
        </div>
        <p>
            <input type="submit" value="Изменить" />
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
