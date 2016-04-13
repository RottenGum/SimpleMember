<%@ Page Title="云南亮剑" Language="C#" MasterPageFile="~/web/ContentPage.master" AutoEventWireup="true" CodeFile="Help.aspx.cs" Inherits="web_Help" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
	<div class="help">
		<%= GetInfoContent() %>
	</div>
</asp:Content>
