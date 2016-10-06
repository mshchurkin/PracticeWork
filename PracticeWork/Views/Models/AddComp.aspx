<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Computer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Добавить компьютер
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Добавить компьютер</h2>
    <% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Модели</legend>


        <div class="editor-label">
            <%: Html.Label("Введите новое название")%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Name) %>
            <%: Html.ValidationMessageFor(model => model.Name) %>
        </div>

        <div class="editor-label">
            <%: Html.Label("Введите новое описание процессора") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Processor) %>
            <%: Html.ValidationMessageFor(model => model.Processor) %>
        </div>
                <div class="editor-label">
            <%: Html.Label("Введите новоый объем оперативной памяти") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.RAM) %>
            <%: Html.ValidationMessageFor(model => model.RAM) %>
        </div>
                <div class="editor-label">
            <%: Html.Label("Введите новый объем хранилища") %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Memory) %>
            <%: Html.ValidationMessageFor(model => model.Memory) %>
        </div>
                <div class="editor-label">
            <%: Html.Label("Введите новую скорость подключения") %>
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
