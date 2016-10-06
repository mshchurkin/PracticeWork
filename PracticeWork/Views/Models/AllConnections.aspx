<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="PracticeWork" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Соединения
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>Соединения</h2>
    <%: Html.ActionLink("Добавить", "AddConnection")%> 
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Описание</b></td>
            <td><b>Устройство 1</b></td>
            <td><b>Устройство 2</b></td>
        </tr>
        <% foreach(Connection c in(IEnumerable<Connection>)ViewData["AllConnections"]) 
          {%>
             <tr>
                 <td><%= c.Id %></td>
                 <td><%= c.Name %></td>
                 <td><%= c.Description %></td>
                 <td><%= c.D1 %></td>
                 <td><%= c.D2 %></td>
                 <td><%: Html.ActionLink("Удалить", "DeleteConnection", new { _id = c.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "EditConnection", new { _id = c.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
        </table>
         <div>
    <%: Html.ActionLink("Экспортировать результаты в Excel", "ExcelCon")%>
    </div>
     <div>
    <%: Html.ActionLink("Назад", "Modelback") %>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
