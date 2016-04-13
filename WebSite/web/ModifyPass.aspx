<%@ Page Title="云南亮剑-用户中心" Language="C#" MasterPageFile="ContentPage.master" AutoEventWireup="true" CodeFile="ModifyPass.aspx.cs" Inherits="web_ModifyPass" %>
<%@ Register TagPrefix="uc1" TagName="MemberCenterMenu" Src="~/web/uc/MemberCenterMenu.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
	<div class="member-center">
		<uc1:MemberCenterMenu runat="server" />
		<div class="member-content">
			<h3>修改密码</h3>
			<form id="frm" runat="server" style="width:300px;margin:0 auto;">
			<div class="field">
				<label>当前密码</label>
				<div class="ui icon input">
					<i class="lock icon"></i>
					<asp:TextBox runat="server" ID="txtOldPassword" placeholder="当前的密码" required="true" TextMode="Password" autofocus="true" TabIndex="1"></asp:TextBox>
				</div>
			</div>
			<div>&nbsp;</div>
			<div class="field">
				<label>新的密码</label>
				<div class="ui icon input">
					<i class="lock icon"></i>
					<asp:TextBox runat="server" ID="txtNewPassword" placeholder="新的密码" required="true" TextMode="Password" TabIndex="2"></asp:TextBox>
				</div>
			</div>
			<div>&nbsp;</div>
			<div class="field">
				<label>确认密码</label>
				<div class="ui icon input">
					<i class="lock icon"></i>
					<asp:TextBox runat="server" ID="txtConfirmPassword" placeholder="确认密码" required="true" TextMode="Password" TabIndex="3"></asp:TextBox>
				</div>
			</div>
			<div>&nbsp;</div>
			<div style="text-align:center;">
				<asp:LinkButton runat="server" ID="btnModify" CssClass="ui red button" OnClick="btnModify_Click" TabIndex="4">
					<i class="arrow right icon"></i>
					&nbsp;&nbsp;&nbsp;&nbsp;修&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;改&nbsp;&nbsp;&nbsp;&nbsp;
				</asp:LinkButton>
			</div>
			</form>
		</div>
	</div>
</asp:Content>

