using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Data;
using NPiculet.Toolkit;

public partial class _default : System.Web.UI.Page
{
	public List<SysUserInfo> list = new List<SysUserInfo>();

	public void print(object msg)
	{
		Response.Write(msg + "<br />");
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		print(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        Response.Redirect("~/Login.aspx");
		DateTime date = DateTime.Now;

		print(date.AddTicks(-new DateTime(2015, 5, 17, 8, 0, 0).ToFileTime()).ToFileTime());
		print(date.AddTicks(-new DateTime(1970, 1, 1, 8, 0, 0).ToFileTime()).ToFileTime());
		print(date.ToFileTimeUtc());
	}
}