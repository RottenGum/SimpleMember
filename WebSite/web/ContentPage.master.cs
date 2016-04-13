using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Sys;
using NPiculet.Logic.Business;
using System.Data;

public partial class web_ContentPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btn_Search(object sender, EventArgs e)
    {
        //string cids = Request.Params["cart-item-id"].ToString();
        //string amounts = Request.Params["cart-item-amount"].ToString();
        //Response.Redirect("~/web/OrderConfirm.aspx?c=" + cids + "&a=" + amounts);
    }

    protected string GetLoginStatus()
    {
        var member = LoginKit.GetCurrentMember();
        if (member != null)
        {
            string html = member.Name + "，您好，欢迎光叁毛与荷西！";
            html += " | <a href=\"" + ResolveClientUrl("~/Logout.aspx") + "\">退出登录</a>";
            return html;
        }
        else
        {
            return "请 " + "<a href=\"" + ResolveClientUrl("~/Login.aspx") + "\">登录</a> 或 <a href=\"" +
                   ResolveClientUrl("~/Register.aspx") + "\">免费注册</a>";
        }

    }

    public string GetDomain()
    {
        return new ConfigManager().GetWebConfig("DomainName");
    }
}
