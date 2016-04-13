<%@ Page Title="会员信息" Language="C#" MasterPageFile="~/modules/ContentPage.master"
    AutoEventWireup="true" CodeFile="MemberEdit.aspx.cs" Inherits="modules_member_MemberEdit" %>

<%@ Register Src="../common/Prompt.ascx" TagName="Prompt" TagPrefix="uc1" %>
<%@ Register TagPrefix="cc1" Namespace="NPiculet.WebControls" Assembly="NPiculet.Pack" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="header">
    <link href="../../styles/default/bootstrap-switch.min.css" rel="stylesheet" type="text/css" />
    <script src="../../scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="../../scripts/bootstrap-switch.min.js" type="text/javascript"></script>
    <style type="text/css">
        .org-list table
        {
            width: 100%;
        }
        .org-list table td
        {
            width: 20%;
        }
        .role-list table
        {
            width: 100%;
        }
        .role-list table td
        {
            width: 20%;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".chkbox-switch>input").bootstrapSwitch({ onText: '是', offText: '否', offColor: 'danger', size: 'normal' });
        });
        function addOrg() {
            OpenModel("../common/OrgDialog.aspx", 400, 500, function (result) {
                if (result && result.length > 0)
                    __doPostBack('addOrg', result);
            });
        }
        function addRole() {
            OpenModel("../common/RoleDialog.aspx", 400, 500, function (result) {
                if (result && result.length > 0)
                    __doPostBack('addRole', result);
            });
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="toolbar" runat="Server">
    <a href="MemberList.aspx">返回</a>
    <asp:LinkButton ID="btnSave" runat="server" OnClick="btnSave_Click">保存</asp:LinkButton>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="searchbar" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="Server">
    <uc1:Prompt ID="promptControl" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder ID="editor" runat="server">
                <%--<table border="0" cellpadding="2" cellspacing="0" class="admin-edit-table">
                    <tr>
                        <th colspan="4">
                            基本信息
                        </th>
                    </tr>
                    <tr>
                        <td class="th">
                            帐号
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Account" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
                                ErrorMessage="必填" ForeColor="red" ControlToValidate="Account"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Account"
                                Display="Dynamic" ErrorMessage="应输入英文或数字，最长32位" ValidationExpression="\w+" ForeColor="red"></asp:RegularExpressionValidator>
                        </td>
                        <td class="th">
                            密码
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Password" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
                                ErrorMessage="必填" ForeColor="red" ControlToValidate="Password"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Password"
                                Display="Dynamic" ErrorMessage="应输入英文或数字，最长32位" ValidationExpression="\w+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="th">
                            姓名
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Name" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
                                ErrorMessage="必填" ForeColor="red" ControlToValidate="Name"></asp:RequiredFieldValidator>
                        </td>
                        <td class="th">
                        </td>
                        <td class="td">
                        </td>
                    </tr>
                </table>--%>
                <table border="0" cellpadding="2" cellspacing="0" class="admin-edit-table">
                    <tr>
                        <th colspan="6">
                            用户资料
                        </th>
                    </tr>
                    <tr>
                        <td class="th">
                            姓名
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Account" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
                                ErrorMessage="必填" ForeColor="red" ControlToValidate="Account"></asp:RequiredFieldValidator>
                        </td>
                        <td class="th">
                            性别
                        </td>
                        <td class="td">
                            <asp:RadioButtonList runat="server" ID="Sex" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td class="th">
                            手机
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Mobile" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
                                ErrorMessage="必填" ForeColor="red" ControlToValidate="Mobile"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="th">
                           卡号：
                        </td>
                        <td class="td">
                           <asp:TextBox ID="MemberCard" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
                        </td>
                          <td class="th">
                            开卡商铺
                        </td>
                        <td class="td">
                           <asp:DropDownList ID="Partner" runat="server" Width="200px">
                        <%--<asp:ListItem Selected="True" Text="商品分类" Value="0"></asp:ListItem>--%>
                    </asp:DropDownList>
                        </td>
                        <td class="th">
                            是否启用
                        </td>
                        <td class="td">
                            <asp:CheckBox runat="server" ID="IsEnabled" Checked="True" CssClass="chkbox-switch" />
                        </td>
                    </tr>
                    <tr>
                        <td class="th">
                            住址
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Address" runat="server" CssClass="textbox" Width="200px" MaxLength="255"></asp:TextBox>
                        </td>
                        <td class="th">
                            生日
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Birthday" runat="server" CssClass="easyui-datebox" Width="200px"
                                MaxLength="32"></asp:TextBox>
                        </td>
                        <td class="th">
                            邮箱
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Email" runat="server" CssClass="textbox" Width="200px" MaxLength="32"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="格式不正确"
                                ControlToValidate="Email" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="th">
                            QQ
                        </td>
                        <td class="td">
                            <asp:TextBox ID="QQ" runat="server" CssClass="textbox" Width="200px" MaxLength="16"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="QQ"
                                Display="Dynamic" ErrorMessage="格式不正确" ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                        </td>
                        <%-- <td class="th">
                            教育程度
                        </td>
                        <td class="td">
                            <asp:TextBox ID="Education" runat="server" CssClass="textbox" Width="200px" MaxLength="64"></asp:TextBox>
                        </td>--%>
                       
                       
                    </tr>
                    
                </table>
                <asp:HiddenField ID="Id" runat="server" />
            </asp:PlaceHolder>
            <%--<cc1:NPager ID="NPager1" runat="server" />--%>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
