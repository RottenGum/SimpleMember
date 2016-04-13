<%@ Page Language="C#" MasterPageFile="~/web/ContentPage.master" AutoEventWireup="true"
    CodeFile="Register.aspx.cs" Inherits="Register" %>

<%@ Register Src="~/modules/common/Prompt.ascx" TagName="Prompt" TagPrefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        small
        {
            color: #ff9a9a;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.ui.form').form({
                account: {
                    identifier: 'account',
                    rules: [
						{
						    type: 'empty',
						    prompt: '请输入帐号！'
						}
					]
                },
                pass: {
                    identifier: 'password',
                    rules: [
						{
						    type: 'empty',
						    prompt: '请输入登录密码！'
						}
					]
                },
                passconfirm: {
                    identifier: 'pass-confirm',
                    rules: [
						{
						    type: 'empty',
						    prompt: '请输入确认密码！'
						}
					]
                },
                realname: {
                    identifier: 'realname',
                    rules: [
						{
						    type: 'empty',
						    prompt: '请输入真实姓名！'
						}
					]
                },
                email: {
                    identifier: 'email',
                    rules: [
						{
						    type: 'email',
						    prompt: '邮箱地址输入不正确！'
						}
					]
                }
            }, {
                on: 'submit'
            });
        });
    </script>
    <script language="javascript" type="text/javascript">
        /**
        * Check email format
        */
        function emailCheck(obj, labelName) {
            var objName = eval("document.all." + obj);
            var pattern = /^([\.a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-])+/;
            if (!pattern.test(objName.value)) {
                alert("请输入正确的邮箱地址。");
                objName.focus();
                return false;
            }
            return true;
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="content">
    <div style="padding: 20px;">
        <uc1:Prompt ID="promptControl" runat="server" />
        <h2 class="ui header">
            用户注册</h2>
        <form id="frm" method="POST" runat="server" class="ui form raised segment">
        <a class="ui teal ribbon label">填写用户基本信息</a>
        <div class="ui positive message">
            <i class="info icon"></i>请填写真实信息，不会外泄您的信息。</div>
        <div class="ui divided grid">
            <div class="row">
                <div class="three wide column reg-th">
                    登录帐号</div>
                <div class="nine wide column">
                    <input type="text" id="account" name="account" placeholder="请输入登录帐号（只能4-32位的英文、数字或下划线组合）"
                        maxlength="32" />
                </div>
            </div>
            <div class="row">
                <div class="three wide column reg-th">
                    登录密码</div>
                <div class="nine wide column">
                    <input id="password" name="password" placeholder="请输入登录密码（只能4-32位的英文、数字或下划线组合）" type="password"
                        maxlength="32" />
                </div>
            </div>
            <div class="row">
                <div class="three wide column reg-th">
                    确认密码</div>
                <div class="nine wide column">
                    <input id="pass-confirm" name="pass-confirm" placeholder="请输入确认密码" type="password"
                        maxlength="32" />
                </div>
            </div>
            <div class="row">
                <div class="three wide column reg-th">
                    真实姓名</div>
                <div class="nine wide column">
                    <input id="realname" name="realname" placeholder="请输入真实姓名" type="text" maxlength="32" />
                </div>
                <div class="ui pointing left red label">
                    必填</div>
            </div>
            <div class="row">
                <div class="three wide column reg-th">
                    手机号码</div>
                <div class="nine wide column">
                    <input id="mobile" name="mobile" placeholder="请输入手机号码" type="text" maxlength="32" />
                </div>
                <div class="ui pointing left red label">
                    必填</div>
            </div>
            <div class="row">
                <div class="three wide column reg-th">
                    性别</div>
                <div class="nine wide column">
                    <select id="sex" name="sex">
                        <option value="保密">保密</option>
                        <option value="男">男</option>
                        <option value="女">女</option>
                    </select>
                </div>
            </div>
            <div class="row">
                <div class="three wide column reg-th">
                    电子邮箱</div>
                <div class="nine wide column">
                    <input id="email" name="email" placeholder="请输入电子邮箱" type="text" maxlength="126"
                        onblur="return emailCheck('email', 'email')" />
                </div>
            </div>
        </div>
        <a class="ui teal ribbon label">填写律师基本信息</a>
        <div class="ui divided grid">
             <div class="row">
                <div class="three wide column reg-th">
                    用户身份</div>
                <div class="nine wide column">
                    <select id="lawyerType" name="lawyerType">
                        <option value="律师">律师</option>
                        <option value="行政">行政</option>
                        <option value="实习律师">实习律师</option>
                    </select>
                </div>
            </div>
              <div class="row">
                <div class="three wide column reg-th">
                    律师证号</div>
                <div class="nine wide column">
                    <input id="txtCertificateID" name="certificateID" placeholder="请输入真实的律师证编号" type="text" maxlength="32" />
                </div>
                <div class="ui pointing left red label">
                    必填</div>
            </div>
              <div class="row">
                <div class="three wide column reg-th">
                    法律职业资格证编号</div>
                <div class="nine wide column">
                    <input id="txtQualificationID" name="qualificationID" placeholder="请输入真实的法律职业资格证编号" type="text" maxlength="32" />
                </div>
                <div class="ui pointing left red label">
                    必填</div>
            </div>
              <div class="row">
                <div class="three wide column reg-th">
                    身份证扫描件</div>
                <div class="nine wide column">
                   <asp:FileUpload ID="cardIDThumb" runat="server"  placeholder="缩略图" />
					<div class="caption">
						注：支持 .jpg .png .bmp .gif 格式的图片，图片大于1024会自动压缩。</div>
					<asp:HyperLink ID="ThumbHyperLink" runat="server" CssClass="thumb-link">
						<asp:Image ID="PreviewCardIDThumb" runat="server" Width="40px" Height="40px" Visible="False" CssClass="thumb-image" />
					</asp:HyperLink>
                </div>
            </div> 
            <div class="row">
                <div class="three wide column reg-th">
                    律师证扫描件</div>
                <div class="nine wide column">
                   <asp:FileUpload ID="certificateIDThumb" runat="server"  placeholder="缩略图" />
					<div class="caption">
						注：支持 .jpg .png .bmp .gif 格式的图片，图片大于1024会自动压缩。</div>
					<asp:HyperLink ID="HyperLink1" runat="server" CssClass="thumb-link">
						<asp:Image ID="PreviewCertificateID" runat="server" Width="40px" Height="40px" Visible="False" CssClass="thumb-image" />
					</asp:HyperLink>
                </div>
            </div>
            <div class="row">
                <div class="three wide column reg-th">
                    司法考试证件扫描件</div>
                <div class="nine wide column">
                   <asp:FileUpload ID="qualificationIDThumb" runat="server"  placeholder="缩略图" />
					<div class="caption">
						注：支持 .jpg .png .bmp .gif 格式的图片，图片大于1024会自动压缩。</div>
					<asp:HyperLink ID="HyperLink2" runat="server" CssClass="thumb-link">
						<asp:Image ID="PreviewQualificationID" runat="server" Width="40px" Height="40px" Visible="False" CssClass="thumb-image" />
					</asp:HyperLink>
                </div>
            </div>  
        </div>
        <div class="row">
            <div class="column">
                <div class="ui error message">
                </div>
                <div style="text-align: center">
                    <input id="Button1" type="button" runat="server" onserverclick="btnRegister_Click"
                        class="ui red submit button" value="     注  册     " />
                </div>
            </div>
        </div>
        </form>
    </div>
</asp:Content>
