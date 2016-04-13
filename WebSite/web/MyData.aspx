<%@ Page Title="云南亮剑-会员信息" Language="C#" MasterPageFile="ContentPage.master" AutoEventWireup="true" CodeFile="MyData.aspx.cs" Inherits="web_MyData" %>
<%@ Register Src="~/web/uc/MemberCenterMenu.ascx" TagName="MemberCenterMenu" TagPrefix="uc1" %>
<%@ Register Src="../modules/common/Prompt.ascx" TagName="Prompt" TagPrefix="uc2" %>
<%@ Register TagPrefix="uc1" TagName="prompt" Src="~/modules/common/Prompt.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
	<style type="text/css">
		.form-control { border:1px solid #dddddd;border-radius:3px;padding:5px;width:240px;height:26px;line-height:26px; }
		table td { padding:6px; }
		table .th { width:120px;text-align:right;font-weight:bold; }
		table .td { }
		input[type=text] { padding:0 4px !important; }
	</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
	<div class="member-center">
		<uc1:MemberCenterMenu ID="MemberCenterMenu1" runat="server" />
		<uc2:Prompt ID="promptControl" runat="server" />
		<div class="member-content">
			<h3>个人信息管理</h3>
			<form id="frm" runat="server">
				<table style="width:100%;">
					<tr>
						<td class="th">账号</td>
						<td class="td">
							<input type="text" class="form-control" id="UserAccount" readonly="readonly" disabled placeholder="账号" runat="server" />
						</td>
						<td class="th">昵称</td>
						<td class="td">
							<input type="text" class="form-control" id="Nickname" placeholder="昵称" runat="server" />
						</td>
					</tr>
					<tr>
						<td class="th">生日</td>
						<td class="td">
							<input type="text" class="form-control" id="Birthday" placeholder="生日" runat="server" />
						</td>
						<td class="th">性别</td>
						<td class="td">
							<input type="text" class="form-control" id="Sex" placeholder="性别" runat="server" />
						</td>
					</tr>
					<tr>
						<td class="th">邮箱</td>
						<td class="td">
							<input type="text" class="form-control" id="Email" readonly="readonly" placeholder="邮箱" runat="server" />
						</td>
						<td class="th">移动电话</td>
						<td class="td">
							<input type="text" class="form-control" id="Mobile" placeholder="移动电话" runat="server" />
						</td>
					</tr>
					<tr>
						<td class="th">会员卡号</td>
						<td class="td">
							<input type="text" class="form-control" id="MemberCard" readonly="readonly" placeholder="会员卡号" runat="server" />
						</td>
						<td class="th">身份证号</td>
						<td class="td">
							<input type="text" class="form-control" id="IdCard" readonly="readonly" placeholder="身份证号" runat="server" />
						</td>
					</tr>
					<tr>
						<td class="th">省份</td>
						<td class="td"><input type="text" class="form-control" id="Province" placeholder="所在省份" runat="server" /></td>
						<td class="th">学历</td>
						<td class="td">
							<input type="text" class="form-control" id="Education" placeholder="学历" runat="server" />
						</td>
					</tr>
					<tr>
						<td class="th">QQ</td>
						<td class="td">
							<input type="text" class="form-control" id="QQ" placeholder="QQ" runat="server" />
						</td>
						<td class="th">兴趣爱好</td>
						<td class="td">
							<input type="text" class="form-control" id="Interest" placeholder="兴趣爱好" runat="server" />
						</td>
					</tr>
					<tr>
						<td class="th"></td>
						<td class="td">
							<asp:Button runat="server" ID="btnSubmit" CssClass="ui primary button" Text="保存" OnClick="btnSubmit_Click" />
						</td>
					</tr>
				</table>
				<asp:HiddenField runat="server" ID="Id" />
			</form>
		</div>
	</div>
</asp:Content>

