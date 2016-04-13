<%@ Page Title="注册成功" Language="C#" MasterPageFile="~/web/ContentPage.master" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="frm" runat="server">
        <div class="product-list">
			<div style="padding: 50px 0;text-align: center">
			     <p style="font-size: 25px;">恭喜你注册成功，请记住你的用户名密码！</p>
                 <p style="font-size: 20px"><span id="second" style="color: red "></span> 秒后自动跳转到登录页</p>
			     <p style="font-size: 20px"><a href="<%= ResolveClientUrl("~/Login.aspx") %>">点此立即登录</a></p>
			</div>
		</div>
    </form>
       <script type="text/javascript">
           //设定倒数秒数  
           var t = 10;
           //显示倒数秒数  
           function showTime() {
               t -= 1;
               document.getElementById('second').innerHTML = t;
               if (t == 0) {
                   location.href = 'Login.aspx';
               }
               //每秒执行一次,showTime()  
               setTimeout("showTime()", 1000);
           }


           //执行showTime()  
           showTime();  
</script> 
</asp:Content>

