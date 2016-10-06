<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PracticeWork.Model>" %>
<%@ Import Namespace="PracticeWork" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Информация о модели
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Компьютеры</h2>
    <%: Html.ActionLink("Добавить", "AddComp")%> 
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Процессор</b></td>
            <td><b>Объем оперативной памяти</b></td>
            <td><b>Объем хранилища</b></td>
            <td><b>Скорость соединения</b></td>
        </tr>
        <% foreach(Computer c in(IEnumerable<Computer>)ViewData["ComputersCollection"]) 
          {%>
             <tr>
                 <td><%= c.Id %></td>
                 <td><%= c.Name %></td>
                 <td><%= c.Processor %></td>
                 <td><%= c.RAM %></td>
                 <td><%= c.Memory %></td>
                 <td><%= c.ConnectionSpeed %></td>
                 <td><%: Html.ActionLink("Удалить", "DeleteComp", new { _id = c.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "EditComp", new { _id = c.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
    </table>
        <h2>Серверы</h2>
    <%: Html.ActionLink("Добавить", "AddServer")%> 
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
                 <td><%: Html.ActionLink("Удалить", "DeleteServer", new { _id = s.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "EditServer", new { _id = s.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
    </table>

    <h2>Устройства исполнения</h2>
    <%: Html.ActionLink("Добавить", "AddDevice")%> 
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Описание</b></td>
            <td><b>Объем оперативной памяти</b></td>
            <td><b>Объем хранилища</b></td>
            <td><b>Объем видеопамяти</b></td>
            <td><b>Скорость соединения</b></td>
            <td><b>Имеет ли очередь</b></td>
        </tr>
        <% foreach(Device d in(IEnumerable<Device>)ViewData["DevicesCollection"]) 
          {%>
             <tr>
                 <td><%= d.Id %></td>
                 <td><%= d.Name %></td>
                 <td><%= d.Description %></td>
                 <td><%= d.RAM %></td>
                 <td><%= d.Memory %></td>
                 <td><%= d.VideoMemory %></td>
                 <td><%= d.ConnectionSpeed %></td>
                 <td><%= d.HaveQueue %></td>
                 <td><%: Html.ActionLink("Удалить", "DeleteDevice", new { _id = d.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "EditDevice", new { _id = d.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
    </table>

 <h2>Маршрутизаторы</h2>
    <%: Html.ActionLink("Добавить", "AddRouter")%> 
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Скорость соединения</b></td>
        </tr>
        <% foreach(Router r in(IEnumerable<Router>)ViewData["RoutersCollection"]) 
          {%>
             <tr>
                 <td><%= r.Id %></td>
                 <td><%= r.Name %></td>
                 <td><%= r.ConnectionSpeed %></td>
                 <td><%:  Html.ActionLink("Открыть", "Connections", new { _idr = r.Id, _name = r.Name })%></td>
                 <td><%: Html.ActionLink("Удалить", "DeleteRouter", new { _id = r.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "EditRouter", new { _id = r.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
    </table>

     <h2>Очереди исполнения</h2>
    <%: Html.ActionLink("Добавить", "AddQueue")%> 
    <table>
        <tr>
            <td><b>ID</b></td>
            <td><b>Название</b></td>
            <td><b>Скорость соединения</b></td>
            <td><b>Количество операций в очереди</b></td>
            <td><b>Подключенное устройство</b></td>
        </tr>
        <% foreach(PracticeWork.Queue q in(IEnumerable<PracticeWork.Queue>)ViewData["QueuesCollection"]) 
          {%>
             <tr>
                 <td><%= q.Id %></td>
                 <td><%= q.Name %></td>
                 <td><%= q.ConnectionSpeed %></td>
                 <td><%= q.NumberInQueue %></td>
                 <td><%= q.Device.Name %></td>
                 <td><%: Html.ActionLink("Открыть", "Routines", new { _idq = q.Id, _name = q.Name })%></td>
                 <td><%: Html.ActionLink("Удалить", "DeleteQueue", new { _id = q.Id }, new {onclick = "return confirm('Вы уверены?');" })%> </td>
                 <td><%: Html.ActionLink("Редактировать", "EditQueue", new { _id = q.Id })%> </td>
                 <td></td>
                </tr>
        <% }%>
    </table>
    <table>
             <tr>
                 <td><%: Html.ActionLink("Выборка серверов", "ServerSelector")%></td>
                 <td><%: Html.ActionLink("Выборка сетевых карт", "SpeedSelector")%></td>
                 <td><%: Html.ActionLink("Все функции", "AllRoutines")%></td>
                 <td><%: Html.ActionLink("Все соединения", "AllConnections")%></td>
            </tr>
    </table>
    </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
         <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
