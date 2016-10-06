<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="PracticeWork" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Модели
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Модели</h2><br/><br/>

    <%:Html.ActionLink("Добавить","Add") %><br/><br/>

    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Описание</b></td>
        </tr>
        <%foreach(Model m in(IEnumerable<Model>)ViewData["ModelsCollection"])
          {%>
             <tr>
                 <td><%= m.Id %></td>
                 <td><%= m.Name %></td>
                 <td><%= m.Description %></td>
                 <td><%:  Html.ActionLink("Открыть", "Models", new { _id = m.Id, _name = m.Name })%></td>
                 <td><%: Html.ActionLink("Удалить", "Delete", new { _id = m.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "Edit", new { _id = m.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
    </table>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
