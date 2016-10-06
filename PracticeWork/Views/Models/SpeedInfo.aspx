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
            <td><b>Название</b></td>
            <td><b>Скорость соединения</b></td>
        </tr>
    <% foreach(var x in @ViewBag.dr as Dictionary<string,int>) 
          {%>
             <tr>
                 <%if ((x.Key[x.Key.Length - 1] >= '0') && (x.Key[x.Key.Length - 1] <= '9'))
                   {%>
                        <td><%= @x.Key.Remove(x.Key.Length-2)%></td>
                   <%}%>
                 <%else
                   {%>
                        <td><%= @x.Key%></td>
                 <% }%>
                 <td><%= @x.Value %></td>
                </tr>
        <% }%>
        </table>
    <% } %>
     <div>
    <%: Html.ActionLink("Экспортировать результаты в Excel", "Excel")%>
    </div>
     <div>
    <%: Html.ActionLink("Назад", "Modelback") %>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
