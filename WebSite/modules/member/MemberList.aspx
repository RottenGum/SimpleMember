﻿<%@ Page Title="会员管理" Language="C#" MasterPageFile="~/modules/ContentPage.master" AutoEventWireup="true" CodeFile="MemberList.aspx.cs" Inherits="modules_member_MemberList" %>
<%@ Register TagPrefix="cc1" Namespace="NPiculet.WebControls" Assembly="NPiculet.Pack" %>

<asp:Content runat="server" ContentPlaceHolderID="header">
	<script>
		$(document).ready(function() {
			$('.dropdown').dropdown({ transition: 'drop' });
		});
	</script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="toolbar" Runat="Server">
	<a href="MemberEdit.aspx">新增</a>
    	<asp:LinkButton ID="btnExport" runat="server" onclick="btnExport_Click" Visible="False" Text="导出"></asp:LinkButton>
	<%--<asp:LinkButton runat="server" ID="btnDel" Text="删除"></asp:LinkButton>--%>
	<%--<asp:LinkButton runat="server" ID="btnResetPass" Text="重设密码"></asp:LinkButton>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="searchbar" Runat="Server">
	<div class="searchbar-wrap">
        <asp:Label ID="MemberStatus" runat="server">会员姓名</asp:Label>
       <%-- <asp:DropDownList ID="ddlStatus" runat="server"  Width="200px">
			<asp:ListItem Text="全部" Selected="True" Value="全部"></asp:ListItem>
			<asp:ListItem Text="待验证" Value="待验证"></asp:ListItem>
            <asp:ListItem Text="已注册" Value="已注册"></asp:ListItem>
		</asp:DropDownList>--%>
        <asp:TextBox ID="txtKeywords" runat="server" Width="200px" placeholder="姓名"></asp:TextBox>
        <asp:TextBox ID="txtPhone" runat="server" Width="200px" placeholder="手机号"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" Text="搜索"></asp:Button>
	</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="content" Runat="Server">
	<asp:GridView ID="list" runat="server" Width="100%" AutoGenerateColumns="False" DataKeyNames="UserAccount"
		OnRowDeleting="list_RowDeleting" CssClass="admin-list-table">
		<PagerSettings Mode="NumericFirstLast" />
		<RowStyle HorizontalAlign="Center" />
		<Columns>
			<asp:BoundField DataField="UserAccount" HeaderText="姓名" >
				<HeaderStyle Width="160px" />
			</asp:BoundField>
			<asp:BoundField DataField="Mobile" HeaderText="手机" >
				<HeaderStyle Width="160px" />
			</asp:BoundField>
			<asp:BoundField DataField="MemberCard" HeaderText="卡号" />
			<asp:BoundField DataField="Memo" DataFormatString="{0:yyyy-MM-dd HH:mm:ss}" HeaderText="创建时间">
				<HeaderStyle Width="160px" />
			</asp:BoundField>
            <asp:BoundField DataField="Interest" HeaderText="办卡店铺" >
				<HeaderStyle Width="160px" />
			</asp:BoundField>
			<%--<asp:TemplateField HeaderText="启用">
				<HeaderStyle Width="60px" />
				<ItemTemplate><%# GetStatusString(Eval("IsEnabled").ToString()) %></ItemTemplate>
			</asp:TemplateField>--%>
			<asp:TemplateField HeaderText="操作">
				<HeaderStyle Width="140"></HeaderStyle>
				<ItemTemplate>
					<a href="MemberEdit.aspx?key=<%# Eval("UserId") %>" CssClass="btn btn-default" >编辑</a> |
					<asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('确定要删除吗？');">删除</asp:LinkButton>
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>
	<cc1:NPager ID="NPager1" runat="server" />
</asp:Content>
