<%@ Page Title="选择组织机构" Language="C#" MasterPageFile="~/modules/common/Dialog.master" AutoEventWireup="true" CodeFile="OrgDialog.aspx.cs" Inherits="modules_common_OrgDialog" %>
<%@ Register TagPrefix="cc1" Namespace="NPiculet.WebControls" Assembly="NPiculet.Pack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
	<script type="text/javascript">
		function ok() {
			$('.ui.modal').modal('hide');
		}
		function cancel() {
			$('.ui.modal').modal('hide');
		}
	</script>
	<base target="_self"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="toolbar" Runat="Server">
	<a href="#" onclick="ok();">确定</a>
	<a href="#" onclick="cancel();">取消</a>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="content" Runat="Server">

	<asp:Literal runat="server" ID="tree"></asp:Literal>

</asp:Content>
