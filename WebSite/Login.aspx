<%@ Page Language="C#" Title="云南亮剑-用户登陆" MasterPageFile="~/web/ContentPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head"></asp:Content>


<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="content">
<div style="padding:20px;">

	<div class="ui grid">
		<div class="ten wide column">
			<img  style="width: 683px;height: 411px;" src="styles/ticket/images/login-bg.jpg" />
		</div>
		<div class="four wide column">

			<form id="frm" method="POST" class="ui form raised segment" runat="server">

				<div class="ui dividing header tc"><img src="styles/ticket/images/login-person.png" /></div>
				<div class="field">
					<label>登录帐号</label>
					<div class="ui icon input">
						<i class="user icon"></i>
						<asp:TextBox runat="server" ID="txtAccount"  placeholder="帐号" required="true" autofocus="true" TabIndex="1"></asp:TextBox>
					</div>
				</div>

				<div class="field">
					<label>登录密码</label>
					<div class="ui icon input">
						<i class="lock icon"></i>
						<asp:TextBox runat="server" ID="txtPassword" placeholder="密码" required="true" TextMode="Password" TabIndex="2"></asp:TextBox>
					</div>
				</div>

				<div class="ui error message"><div class="header">发生了错误</div></div>
				<asp:LinkButton runat="server" ID="btnLogin" CssClass="ui red submit button login-btn" onclick="btnLogin_Click" TabIndex="3">
					<i class="arrow right icon"></i>
					&nbsp;&nbsp;&nbsp;&nbsp;登&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;录&nbsp;&nbsp;&nbsp;&nbsp;
				</asp:LinkButton>

				<div>&nbsp;</div>

				<div class="ui two column grid">
					<div class="column">
						<span style="color:#999;">还不是我们的会员？</span>
					</div>
					<div class="column tr">
						<a href="Register.aspx" >免费注册</a>
					</div>
				</div>
				
				<div>&nbsp;</div>

			</form>

		</div>
	</div>

</div>
</asp:Content>