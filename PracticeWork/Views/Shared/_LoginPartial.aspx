<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<% if (Request.IsAuthenticated) { %>
    Hello, <%: Html.ActionLink(User.Identity.Name, "Manage", "Account", routeValues: null, htmlAttributes: new { @class = "username", title = "Manage" }) %>!
    <% using (Html.BeginForm("Выход", "Account", FormMethod.Post, new { id = "logoutForm" })) { %>
        <%: Html.AntiForgeryToken() %>
        <a href="javascript:document.getElementById('logoutForm').submit()">Выход</a>
    <% } %>
<% } else { %>
    <ul>
        <li><%: Html.ActionLink("Регистрация", "Register", "Account", routeValues: null, htmlAttributes: new { id = "registerLink" })%></li>
        <li><%: Html.ActionLink("Вход", "Login", "Account", routeValues: null, htmlAttributes: new { id = "loginLink" })%></li>
    </ul>
<% } %>