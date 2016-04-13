using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;

public partial class modules_common_RoleDialog : NormalPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack) {
			BindRoleList();
		}
	}

	private void BindRoleList()
	{
		SysRoleInfoBus bus = new SysRoleInfoBus();

		string whereString = "IsDel=0 and IsEnabled=1";
		DataTable dt = bus.Query(whereString, "CreateDate DESC");

		this.list.DataSource = dt;
		this.list.DataBind();
	}

	protected void btnOk_Click(object sender, EventArgs e)
	{
		string result = "";

		if (!string.IsNullOrEmpty(result)) {
			this.JavaSrcipt("ok('" + result + "');");
		} else {
			this.Alert("您还没有选中任何数据！");
		}
	}
}