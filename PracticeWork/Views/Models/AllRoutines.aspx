<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="PracticeWork" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Все рутины
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<h2>Все рутины</h2>
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Описание функции</b></td>
            <td><b>Название очереди</b></td>
        </tr>
        <% foreach(Routine c in(IEnumerable<Routine>)ViewData["AllRoutines"]) 
          {%>
             <tr>
                 <td><%= c.Id %></td>
                 <td><%= c.Name %></td>
                 <td><%= c.Function %></td>
                 <td><%= c.Queue.Name %></td> 
                 <td></td>
                </tr>
        <% }%>
    </table>
    <div>
    <%: Html.ActionLink("Экспортировать результаты в Excel", "ExcelRout")%>
    </div>
     <div>
    <%: Html.ActionLink("Назад", "Modelback") %>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">

</asp:Content>
