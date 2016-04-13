<%@ Page Title="字典数据管理" Language="C#" MasterPageFile="~/modules/ContentPage.master" CodeFile="DictItemList.aspx.cs" Inherits="modules_system_DictItemList" %>
<%@ Register TagPrefix="cc1" Namespace="NPiculet.WebControls" Assembly="NPiculet.Pack" %>

<asp:Content runat="server" ContentPlaceHolderID="header">
	<script type="text/javascript">
		$(document).ready(function () {
			$('.dropdown').dropdown({ transition: 'drop' });
		});

		function showUpload() {
			$('.modal').modal('show');
			setTimeout(function () {
				var mw = $('.modals').remove();
				$('form').append(mw);
			}, 30);
		}
	</script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="toolbar" Runat="Server">
    <a href="DictItemEdit.aspx?group=<%= Request.QueryString["group"] %>&fix=<%= Request.QueryString["fix"] %>&cols=<%= Request.QueryString["cols"] %>">新增</a>
	<%--<a href="#" onclick="showUpload()">导入数据</a>
	<a href="../template/机场字典模板.xls">下载“机场字典模板”</a>
	<a href="../template/目的地字典模板.xls">下载“目的地字典模板”</a>
	<a href="../template/供应商字典模板.xls">下载“供应商字典模板”</a>
	<a href="../template/通用字典模板.xls">下载“通用字典模板”</a>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="searchbar" Runat="Server">
	<div class="searchbar-wrap">
		<asp:DropDownList runat="server" ID="ddlDictGroup"/>
		<asp:TextBox ID="txtKeywords" runat="server" placeholder="搜索名称或编码"></asp:TextBox>
		<asp:Button ID="btnSearch" runat="server" Text="搜索" onclick="btnSearch_Click"/>
	</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="content" Runat="Server">
	<asp:GridView ID="list" runat="server" Width="100%" AutoGenerateColumns="False" DataKeyNames="Id" OnRowDeleting="list_RowDeleting"  CssClass="admin-list-table">
		<RowStyle HorizontalAlign="Center" />
		<Columns>
			<asp:BoundField DataField="GroupName" HeaderText="字典组">
				<HeaderStyle Width="160px" />
			</asp:BoundField>
			<asp:BoundField DataField="Name" HeaderText="字典项名称">
				<HeaderStyle Width="160px" />
            </asp:BoundField>
			<asp:BoundField DataField="Code" HeaderText="字典项编码">
				<HeaderStyle Width="160px" />
			</asp:BoundField>
            <asp:BoundField DataField="Value" HeaderText="属性值">
			</asp:BoundField>
            <asp:BoundField DataField="Memo" HeaderText="备注">
                <HeaderStyle Width="60px" />
			</asp:BoundField>
			<asp:BoundField DataField="OrderBy" HeaderText="排序">
				<HeaderStyle Width="100px" />
			</asp:BoundField>
			<asp:BoundField DataField="CreateDate" DataFormatString="{0:D}" HeaderText="创建时间">
		        <HeaderStyle Width="140px" />
            </asp:BoundField>
			<asp:TemplateField HeaderText="启用">
				<HeaderStyle Width="60px" />
				<ItemTemplate><%# GetStatusString(Eval("IsEnabled").ToString()) %></ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="操作">
				<HeaderStyle Width="100px" />
				<ItemTemplate>
					<a href="DictItemEdit.aspx?key=<%# Eval("Id") %>&group=<%= Request.QueryString["group"] %>&fix=<%= Request.QueryString["fix"] %>&cols=<%= Request.QueryString["cols"] %>">编辑</a> |
					<asp:LinkButton ID="btnDel" runat="server" CommandName="Delete" OnClientClick="return confirm('确定要删除吗？');">删除</asp:LinkButton>
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>
	<cc1:NPager ID="NPager1" runat="server" />

	<div class="ui modal">
		<i class="close icon"></i>
		<div class="header">上传名单</div>
		<div class="content">
			<div class="description">
				<asp:FileUpload runat="server" ID="fileXls"/>
				<p style="padding-top:10px;color:#999;">根据固定模板，导入 Excel 电子表格文档</p>
			</div>
		</div>
		<div class="actions">
			<asp:LinkButton runat="server" ID="btnUserImport" OnClick="btnUserImport_Click" class="ui positive left labeled icon button"><i class="checkmark icon"></i>导入</asp:LinkButton>
			<div class="ui black button">取消</div>
		</div>
	</div>
</asp:Content>
