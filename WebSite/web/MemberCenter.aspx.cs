using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Logic.Sys;

public partial class web_MemberCenter : MemberPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
	    if (!Page.IsPostBack) { 
		    this.Title = new ConfigManager().GetWebConfig("WebSiteName") + " - " + this.Title;
	    }
    }

	protected string GetMyOrder()
	{
		
		return "<tr><td>没有订单</td></tr>";
	}

	protected string GetServiceStatus()
	{
		int status = Convert.ToInt32(Eval("Status"));
		switch (status) {
			case 0: return "等待处理";
			case 1: return "已支付";
			case 2: return "已发货";
            case 3: return "已成交";
            case 4: return "已关闭";
			default: return "处理中";
		}
	}
}