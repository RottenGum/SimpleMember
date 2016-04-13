<%@ Page Title="系统日志" Language="C#" MasterPageFile="~/modules/ContentPage.master" AutoEventWireup="true" CodeFile="SystemLogList.aspx.cs" Inherits="modules_system_SystemLogList" %>
<%@ Register TagPrefix="cc1" Namespace="NPiculet.WebControls" Assembly="NPiculet.Pack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="toolbar" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="searchbar" Runat="Server">
	<div class="searchbar-wrap">
		<asp:DropDownList runat="server" ID="ddlActionType" AutoPostBack="True" OnSelectedIndexChanged="ddlActionType_OnSelectedIndexChanged">
			<asp:ListItem Value="">全部</asp:ListItem>
			<asp:ListItem Value="CommodityModify">商品修改 (CommodityModify)</asp:ListItem>
			<asp:ListItem Value="OrderFlow">订单审核 (OrderFlow)</asp:ListItem>
			<asp:ListItem Value="Login">后台登陆 (Login)</asp:ListItem>
			<asp:ListItem Value="Logout">后台登陆 (Logout)</asp:ListItem>
		</asp:DropDownList>
		操作人：<asp:TextBox ID="txtKeywords" runat="server"></asp:TextBox>
		<asp:Button ID="btnSearch" runat="server" Text="搜索" onclick="btnSearch_Click"/>
	</div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="content" Runat="Server">
	
	<asp:GridView runat="server" ID="logs" Width="100%" AutoGenerateColumns="False" CssClass="admin-list-table">
		<Columns>
			<asp:TemplateField HeaderText="序号">
				<HeaderStyle Width="50px" />
				<ItemStyle HorizontalAlign="Center"></ItemStyle>
				<ItemTemplate><%# Container.DisplayIndex + 1 %></ItemTemplate>
			</asp:TemplateField>
			<asp:BoundField DataField="ActionType" HeaderText="类型">
				<HeaderStyle Width="120px" />
			</asp:BoundField>
			<asp:BoundField DataField="ActionAccount" HeaderText="帐号">
				<HeaderStyle Width="120px" />
			</asp:BoundField>
			<asp:BoundField DataField="TargetCode" HeaderText="目标码">
				<HeaderStyle Width="160px" />
			</asp:BoundField>
			<asp:BoundField DataField="TargetId" HeaderText="目标值">
				<HeaderStyle Width="100px" />
			</asp:BoundField>
			<asp:BoundField DataField="Comment" HeaderText="说明" HtmlEncode="False"></asp:BoundField>
			<asp:BoundField DataField="Date" DataFormatString="{0:yyyy-MM-dd HH:mm:ss}" HeaderText="记录时间">
				<HeaderStyle Width="160px" />
			</asp:BoundField>
		</Columns>
	</asp:GridView>
	<cc1:NPager ID="NPager1" runat="server" />

</asp:Content>

