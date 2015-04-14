<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Session["name"] != null)
    {
        MvcStudy.Model.User userModel = Session["name"] as MvcStudy.Model.User;
%>
      
        欢迎您：<b><%:userModel.Name%></b>
       
         [ <%: Html.ActionLink("发表", "Publish", "Post") %> ]
         [ <%: Html.ActionLink("退出", "LogOn", "Account") %> ]
<%
    }
    else {
%> 
        
         [ <%: Html.ActionLink("登录", "Login", "Account") %> ]
        [ <%: Html.ActionLink("注册", "Register", "Account") %> ]
<%
    }
%>
