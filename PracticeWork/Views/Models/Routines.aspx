<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Queue>" %>
<%@ Import Namespace="PracticeWork" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Рутины
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Рутины</h2>
    <%: Html.ActionLink("Добавить", "AddRoutine")%> 
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Описание функции</b></td>
        </tr>
        <% foreach(Routine c in(IEnumerable<Routine>)ViewData["RoutinesCollection"]) 
          {%>
             <tr>
                 <td><%= c.Id %></td>
                 <td><%= c.Name %></td>
                 <td><%= c.Function %></td>
                 <td><%: Html.ActionLink("Удалить", "DeleteRoutine", new { _id = c.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "EditRoutine", new { _id = c.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
    </table>
     <div>
    <%: Html.ActionLink("Назад", "Modelback") %>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
