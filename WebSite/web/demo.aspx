<%@ Page Title="" Language="C#" MasterPageFile="~/web/ContentPage.master" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="web_demo" %>

<asp:Content runat="server" ContentPlaceHolderID="content">
	页面内容
	<script>
		$.ajax({
			type: "get",
			url: "../api/jsonp-demo",
			dataType: "jsonp",
			success: function (data) {
				alert(JSON.stringify(data));
			}
		});
	</script>
</asp:Content>

