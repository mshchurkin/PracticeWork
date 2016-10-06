<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="PracticeWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Результаты выборки
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Результаты выборки</h2>
      <% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    
    <%: Html.ValidationSummary(true) %>
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Объем оперативной памяти</b></td>
            <td><b>Объем хранилища</b></td>
            <td><b>Скорость соединения</b></td>
        </tr>
        <% foreach(Server s in(IEnumerable<Server>)ViewData["ServersCollection"]) 
          {%>
             <tr>
                 <td><%= s.Id %></td>
                 <td><%= s.Name %></td>
                 <td><%= s.RAM %></td>
                 <td><%= s.Memory %></td>
                 <td><%= s.ConnectionSpeed %></td>
                 <td></td>
                </tr>
        <% }%>
<% }%>
    </table>
     <div>
    <%: Html.ActionLink("Экспортировать результаты в Excel", "ExcelServ")%>
    </div>
     <div>
    <%: Html.ActionLink("Назад", "Modelback") %>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
