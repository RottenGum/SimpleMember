﻿<%@ Page  Title="字典数据管理"Language="C#" MasterPageFile="~/modules/ContentPage.master"  AutoEventWireup="true" CodeFile="DictItemEdit.aspx.cs" Inherits="modules_system_DictItemEdit" %>
<%@ Register src="../common/Prompt.ascx" tagname="Prompt" tagprefix="uc1" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="header">
	<script src="../../scripts/colpick.js" type="text/javascript"></script>
	<script type="text/javascript">
//		$(document).ready(function () {
//			var colorPicker = $('#<%= this.Value.ClientID %>');
//			colorPicker.colpick({
//				layout: 'hex',
//				submit: 0,
//				onChange: function (hsb, hex, rgb, el, bySetColor) {
//					$(el).css('border-color', '#' + hex);
//					if (!bySetColor) $(el).val('#' + hex);
//				}
//			}).keyup(function () {
//				$(this).colpickSetColor(this.value.replace('#', ''));
//			}).click(function () {
//				$(this).colpickSetColor(this.value.replace('#', ''));
//			}).colpickSetColor(colorPicker.val().replace('#', ''));
//		});
	</script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="toolbar" Runat="Server">
	<a href="DictItemList.aspx?group=<%= Request.QueryString["group"] %>&fix=<%= Request.QueryString["fix"] %>&cols=<%= Request.QueryString["cols"] %>">返回</a>
	<asp:LinkButton ID="btnSave" runat="server" OnClick="btnSave_Click">保存</asp:LinkButton>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="content" Runat="Server">
    <uc1:Prompt ID="promptControl" runat="server" />
    <asp:PlaceHolder ID="container" runat="server">
		<table border="0" cellpadding="2" cellspacing="0" class="admin-edit-table">
			<tr>
				<td class="th"><asp:Literal runat="server" ID="txtGroupCode">字典组</asp:Literal></td>
				<td class="td">
					<asp:DropDownList runat="server" ID="GroupCode"/>
				</td>
			</tr>
			<tr>
				<td class="th"><asp:Literal runat="server" ID="txtName">字典项名称</asp:Literal></td>
				<td class="td"><asp:TextBox ID="Name" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
						ErrorMessage="必填" ForeColor="red" ControlToValidate="Name">
                    </asp:RequiredFieldValidator>
                </td>
			</tr>
			<tr>
				<td class="th"><asp:Literal runat="server" ID="txtCode">字典项编码</asp:Literal></td>
				<td class="td"><asp:TextBox ID="Code" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
						ErrorMessage="必填" ForeColor="red" ControlToValidate="Code"></asp:RequiredFieldValidator>
				</td>
			</tr>
           <tr>
				<td class="th"><asp:Literal runat="server" ID="txtValue">属性值</asp:Literal></td>
				<td class="td"><asp:TextBox ID="Value" runat="server" CssClass="textbox" Width="200px" MaxLength="255"></asp:TextBox></td>
			</tr>
            <tr>
				<td class="th"><asp:Literal runat="server" ID="txtMemo">备注</asp:Literal></td>
				<td class="td">
                    <asp:TextBox ID="Memo" runat="server" CssClass="textbox" Width="99%"></asp:TextBox>
                </td>
			</tr>
			<tr>
				<td class="th">是否启用</td>
				<td class="td">
					<asp:CheckBox runat="server" ID="IsEnabled" Checked="True"/>
                 </td>
			</tr>
           <tr>
				<td class="th">排序</td>
				<td class="td">
					<asp:TextBox ID="OrderBy" runat="server" CssClass="textbox" Width="200px" MaxLength="8" Text="0"></asp:TextBox>
					<asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="OrderBy" Display="Dynamic" ErrorMessage="必填" ForeColor="Red"></asp:RequiredFieldValidator>
					<asp:RegularExpressionValidator ID="re2" runat="server" ControlToValidate="OrderBy" Display="Dynamic" ErrorMessage="只能是英文及数字" ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>
					<div class="caption">（填写整数数字，数值越小显示越靠前）</div>
				</td>
			</tr>
		</table>
		<asp:HiddenField ID="Id" runat="server" />
	</asp:PlaceHolder>
</asp:Content>