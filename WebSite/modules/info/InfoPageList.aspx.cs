﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Toolkit;

public partial class modules_info_InfoPageList : System.Web.UI.Page
{
	[Category("业务参数"), Browsable(true), Description("栏目编码")]
	public string GroupCode { get { return WebParmKit.GetRequestString("code", ""); } }

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack) {
			this.NPager1.PageSize = 13;

			BindData(1);
		}

		this.NPager1.PageClick += (o, args) => {
			BindData(args.PageIndex);
		};
	}

	private readonly InfoContentPageBus _bus = new InfoContentPageBus();

	private void BindData(int pageIndex)
	{
		string whereString = "GroupCode='" + GroupCode + "'";

		int count = _bus.RecordCount(whereString);
		this.NPager1.RecordCount = count;

		DataTable dt = _bus.Query(pageIndex, this.NPager1.PageSize, whereString, "CreateDate DESC");

		this.list.DataSource = dt.DefaultView;
		this.list.DataBind();
	}

	protected void list_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
		if (e.RowIndex > -1) {
			if (this.list.DataKeys.Count > e.RowIndex) {
				string dataId = this.list.DataKeys[e.RowIndex]["Id"].ToString();
				_bus.Delete("Id=" + dataId);
			}
			BindData(this.NPager1.CurrentPage);
		}
	}
}