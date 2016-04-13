using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Sys;
using NPiculet.Toolkit;
using NPiculet.Logic.Business;

public partial class Login : NormalPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Redirect("modules/Login.aspx" );
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var user = LoginKit.MemberExist(this.txtAccount.Text.ToSqlParm(), this.txtPassword.Text.ToSqlParm());
        if (user != null)
        {
            LoginKit.MemberLogin(user);
            string url = WebParmKit.GetQuery("url", "");
            Response.Redirect(string.IsNullOrEmpty(url) ? "~/Default.aspx" : url);
        }
        else
        {
            this.Alert("用户名或密码错误！");
        }
    }
}