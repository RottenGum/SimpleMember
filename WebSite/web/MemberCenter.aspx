<%@ Page Title="云南亮剑-会员中心" Language="C#" MasterPageFile="ContentPage.master" AutoEventWireup="true" CodeFile="MemberCenter.aspx.cs" Inherits="web_MemberCenter" %>
<%@ Register Src="~/web/uc/MemberCenterMenu.ascx" TagName="MemberCenterMenu" TagPrefix="uc1" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="Server">
	<div class="member-center">
		<uc1:MemberCenterMenu runat="server" />
		<div class="member-content">
			<div class="panel">
				<div class="panel-heading">
					<h3>我的案件</h3>
				</div>
				<div class="panel-body">
					<table cellpadding="0" cellspacing="0" style="width:100%;border:0;border-collapse:collapse;">
						<%= GetMyOrder() %>
					</table>
				</div>
			</div>
		</div>
	</div>
</asp:Content>

