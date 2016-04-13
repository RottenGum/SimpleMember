﻿<%@ Page Title="" Language="C#" MasterPageFile="~/modules/ContentPage.master" AutoEventWireup="true" CodeFile="AdvEdit.aspx.cs" Inherits="system_Modules_AdvEdit" %>
<%@ Register src="../common/Prompt.ascx" tagname="Prompt" tagprefix="zx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="header" Runat="Server">
	<link href="<%= ResolveClientUrl("~/styles/default/magnific-popup.css") %>" rel="stylesheet" type="text/css" />
	<script src="<%= ResolveClientUrl("~/scripts/jquery.magnific-popup.min.js") %>" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="toolbar" Runat="Server">
	<div class="admin-menu">
		<a href="AdvList.aspx">返回</a>
	</div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="searchbar" Runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
	<zx:Prompt ID="promptControl" runat="server" />
	<asp:PlaceHolder ID="editor" runat="server">
		<table border="0" cellpadding="2" cellspacing="0" class="admin-edit-table">
			<tr>
				<td class="th">类型</td>
				<td class="td"><asp:DropDownList ID="Type" runat="server">
					<asp:ListItem>大屏广告</asp:ListItem>
					<asp:ListItem>推荐广告</asp:ListItem>
				</asp:DropDownList></td>
			</tr>
			<tr>
				<td class="th">描述</td>
				<td class="td">
					<asp:TextBox ID="Description" runat="server" CssClass="textbox" Width="500px" MaxLength="512"></asp:TextBox>
					<asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="Description" Display="Dynamic" ErrorMessage="必填" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="th">链接</td>
				<td class="td"><asp:TextBox ID="Url" runat="server" CssClass="textbox" Width="500px" MaxLength="512"></asp:TextBox></td>
			</tr>
			<tr>
				<td class="th">图片</td>
				<td class="td">
					<table cellpadding="0" cellspacing="0" style="border:0;">
						<tr>
							<td>
								<asp:FileUpload ID="AdvImage" runat="server" Width="400px" />
								<div class="caption">注：支持 .jpg .png .bmp .gif 格式的图片，图片大于1024会自动压缩。</div>
							</td>
							<td style="padding:4px">
								<asp:HyperLink ID="ImageHyperLink" runat="server" CssClass="thumb-link">
									<asp:Image ID="PreviewImage" runat="server" Width="40px" Height="40px" Visible="false" CssClass="thumb-image" />
								</asp:HyperLink>
							</td>
						</tr>
					</table>
				</td>
			</tr>
			<tr>
				<td class="th"></td>
				<td class="td"><asp:LinkButton ID="btnSave" runat="server" OnClick="btnSave_Click" CssClass="link-btn">保存</asp:LinkButton>
					<asp:HiddenField ID="Id" runat="server" />
				</td>
			</tr>
		</table>
	</asp:PlaceHolder>
	<script type="text/javascript">
		$(document).ready(function () {
			$('.thumb-link').magnificPopup({
				type: 'image',
				closeOnContentClick: true,
				image: {
					verticalFit: true
				}
			});
		});
	</script>
</asp:Content>

