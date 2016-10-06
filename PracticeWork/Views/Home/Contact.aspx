<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="contactTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Контактные данные
</asp:Content>

<asp:Content ID="contactContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>Контактные данные.</h1>
    </hgroup>

    <section class="contact">
         <header>
            <h3>Щуркин Михаил</h3>
        </header>
         <header>
            <h3>ПИ-14-1</h3>
        </header>
         <header>
            <h3>Phone:8-919-474-14-20</h3>
        </header>
        <header>
            <h3>Email: mhshchurkin@gmail.com</h3>
        </header>

    </section>
</asp:Content>