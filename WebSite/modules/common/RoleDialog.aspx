<%@ Page Title="选择角色" Language="C#" MasterPageFile="~/modules/common/Dialog.master" AutoEventWireup="true" CodeFile="RoleDialog.aspx.cs" Inherits="modules_common_RoleDialog" %>
<%@ Register TagPrefix="cc1" Namespace="NPiculet.WebControls" Assembly="NPiculet.Pack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
	<script type="text/javascript">
		function ok(val) {
			$('.ui.modal').modal('hide');
			__doPostBack('addRole', val);
		}
		function cancel() {
			$('.ui.modal').modal('hide');
		}
	</script>
	<base target="_self"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="toolbar" Runat="Server">
	<%--<asp:LinkButton runat="server" ID="btnOk" onclick="btnOk_Click">确定</asp:LinkButton>--%>
	<a href="#" onclick="cancel();">取消</a>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="content" Runat="Server">
	<table class="ui celled striped table">
		<thead>
		<tr>
			<th>角色名称</th>
			<th>说明</th>
		</tr>
		</thead>
		<tbody>
<asp:Repeater runat="server" ID="list">
	<ItemTemplate>
		<tr>
			<th><a href="#" onclick="ok('<%# Eval("Id") %>');"><%# Eval("RoleName") %></a></th>
			<th><%# Eval("Comment") %></th>
		</tr>
	</ItemTemplate>
</asp:Repeater>
		</tbody>
	</table>
</asp:Content>
