<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    <%
        IList<MvcStudy.Model.Post> allPosts = ViewData["allPost"] as List<MvcStudy.Model.Post>;
         %>
         <ul>
         <%
             for (int i = 0; i < allPosts.Count; i++)
             {
                 %><li><%=allPosts[i].Title.ToString()%></li><% 
             }
              %>
         </ul>
</asp:Content>
