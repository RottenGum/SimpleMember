using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Log;
using NPiculet.Logic.Business;
using NPiculet.Toolkit;

public partial class web_Help : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected string GetInfoContent()
	{
		try {
			InfoContentPageBus bus = new InfoContentPageBus();
			var model = bus.QueryModel("GroupCode='" + WebParmKit.GetRequestString("code", "") + "'");
            this.Title ="云南亮剑"+model.Title;
			return model.Content;
		} catch (Exception ex) {
			Logger.Error("读取 InfoContentPage 内容报错", ex);
		}
		return string.Empty;
	}
}