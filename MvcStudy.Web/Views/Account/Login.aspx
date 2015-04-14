<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	<title>登陆界面</title>
    <script src="../../Scripts/JScript.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Login</h2>
    用户名：<input type="text" id="name"/><br /><br />
    密码：<input type="text" id="password"/><br /><br />
    确认密码：<input type="text" id="password2"/><br /><br />
    <image id="vimg" src="/Common/Image" onclick="changeCode();"/>
    <input type="button" value="登录" onclick="Login();"/>
    <script>
        function changeCode() {
            var imgNode = document.getElementById("vimg");
            imgNode.src="<%=Url.Content("~/Common/image/") %>"+(new Date()).valueOf();//加这个时间参数是为了防止浏览器缓存问题
        }
    
    </script>
</asp:Content>
