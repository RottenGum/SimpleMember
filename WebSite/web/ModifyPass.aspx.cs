using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Toolkit;

public partial class web_ModifyPass : MemberPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnModify_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.txtOldPassword.Text))
        {
            this.Alert("请输入当前的密码！");
            this.txtOldPassword.Focus();
            return;
        }
        if (string.IsNullOrEmpty(this.txtNewPassword.Text))
        {
            this.Alert("请输入新的密码！");
            this.txtNewPassword.Focus();
            return;
        }
        if (string.IsNullOrEmpty(this.txtConfirmPassword.Text))
        {
            this.Alert("请确认新的密码！");
            this.txtConfirmPassword.Focus();
            return;
        }

        SysMemberInfoBus userBus = new SysMemberInfoBus();
        string oldPass = this.txtOldPassword.Text.ToSqlParm();
        string newPass = this.txtNewPassword.Text.ToSqlParm();
        string confirmPass = this.txtConfirmPassword.Text.ToSqlParm();
        if (userBus.MemberExist(this.CurrentUserAccount, oldPass))
        {
            if (newPass != confirmPass || newPass.Length < 3)
            {
                this.Alert("新的密码输入错误，请检查输入！");
                return;
            }
            else
            {
                userBus.ChangePassword(this.CurrentUserAccount, newPass);
                this.Alert("修改密码成功，您的新密码[" + newPass + "]！");
            }
        }
        else
        {
            this.Alert("当前密码输入错误！");
        }
    }
}