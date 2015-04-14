<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Publish
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<form action="/Post/DoPublish/" method="post">
    标题：<input type="text" id="title" name="title"/><br /><br />
    内容：<input type="text" id="content" name="content"/><br /><br />
   
    <input type="submit" value="发布" onclick="Publish();"/>
    </form>
</asp:Content>
