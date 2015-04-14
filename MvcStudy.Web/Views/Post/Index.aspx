<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<%
    MvcStudy.Model.Post postModel = ViewData["article"] as MvcStudy.Model.Post;
     %>
   <h2><%=postModel.Title%></h2>
    <h2><%=postModel.Content%></h2>
     <h2><%=postModel.AddTime%></h2>
</asp:Content>
