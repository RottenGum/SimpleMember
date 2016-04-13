using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Cells;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Toolkit;

public partial class modules_member_MemberList : AdminPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack) {
			BindData();
		}

		this.NPager1.PageClick += (o, args) => {
			BindData();
		};
	}

    
	private readonly SysMemberInfoBus _bus = new SysMemberInfoBus();
    private readonly SysMemberDataBus _dbus = new SysMemberDataBus();

	private void BindData()
	{
	    if (!this.CurrentUserInfo.Account.Contains("dmin"))
	    {
            return;
	    }

	    if (this.CurrentUserInfo.Sn == "319ccd97-9af5-4eaf-9316-8ef9af273915" ||
	        this.CurrentUserInfo.Sn == "5105d065-40a8-482a-baa2-5c9829cbe93f")
	    {
	        this.btnExport.Visible = true;
	    }
	    string whereString = "IsDel=0";
		string key = this.txtKeywords.Text.FormatSqlParm();
		if (!string.IsNullOrEmpty(key))
            whereString += string.Format(" and (UserAccount LIKE '%{0}%' or Nickname LIKE '%{0}%')", key);

        if (!string.IsNullOrEmpty(this.txtPhone.Text))
            whereString += string.Format(" and Mobile LIKE '%{0}%'", this.txtPhone.Text);

        int count = _dbus.RecordCount(whereString);
		this.NPager1.PageSize = 15;
		this.NPager1.RecordCount = count;

        DataTable dt = _dbus.Query(this.NPager1.CurrentPage, this.NPager1.PageSize, whereString, "Memo DESC");

		this.list.DataSource = dt.DefaultView;
		this.list.DataBind();
	}

	protected void list_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
        if (!this.CurrentUserInfo.Account.Contains("dmin"))
        {
            this.Alert("您的权限不足，不能删除用户！如需删除，请联系管理员。");
            return;
        }
		if (e.RowIndex > -1) {
			if (this.list.DataKeys.Count > e.RowIndex) {
                string id = this.list.DataKeys[e.RowIndex]["UserAccount"].ToString();
                _bus.Update(new SysMemberInfo() { IsDel = 1 }, "Account='" + id+"'");
                new SysMemberDataBus().Update(new SysMemberData() { IsDel = 1 }, "UserAccount='" + id + "'");
			}
			BindData();
		}
	}

	protected string GetStatusString(string enabled)
	{
		return enabled == "1" ? "启用" : "停用";
	}

	protected void btnSearch_Click(object sender, EventArgs e)
	{
		BindData2();
	}

    private void BindData2()
    {
        if (string.IsNullOrEmpty(this.txtKeywords.Text) && string.IsNullOrEmpty(this.txtPhone.Text))
        {
            this.Alert("请输入查询条件！");
            return;
        }
        if (!string.IsNullOrEmpty(this.txtPhone.Text))
        {
        if (this.txtPhone.Text.Length < 4)
        {
            this.Alert("电话号码至少大于四位！");
            return;
        }
        }
        string whereString = "IsDel=0";
        string key = this.txtKeywords.Text.FormatSqlParm();
        if (!string.IsNullOrEmpty(key))
            whereString += string.Format(" and (UserAccount LIKE '%{0}%' or Nickname LIKE '%{0}%')", key);

        if (!string.IsNullOrEmpty(this.txtPhone.Text))
            whereString += string.Format(" and Mobile LIKE '%{0}%'", this.txtPhone.Text);

        int count = _dbus.RecordCount(whereString);
        this.NPager1.PageSize = 15;
        this.NPager1.RecordCount = count;

        DataTable dt = _dbus.Query(this.NPager1.CurrentPage, this.NPager1.PageSize, whereString, "Memo DESC");

        this.list.DataSource = dt.DefaultView;
        this.list.DataBind();
    }

    protected void btnExport_Click(object sender, EventArgs e)
	{
        string whereString = "IsDel=0";
        string key = this.txtKeywords.Text.FormatSqlParm();
        if (!string.IsNullOrEmpty(key))
            whereString += string.Format(" and (UserAccount LIKE '%{0}%' or Nickname LIKE '%{0}%')", key);

        if (!string.IsNullOrEmpty(this.txtPhone.Text))
            whereString += string.Format(" and Mobile LIKE '%{0}%'", this.txtPhone.Text);

		DataTable dt = _bus.GetMemberList(1, int.MaxValue, whereString, "CreateDate DESC");
		this.Export(dt);
	}

	private void Export(DataTable data)
	{
		Workbook workbook = new Workbook();
		Worksheet sheet = workbook.Worksheets[0];
		Cells cells = sheet.Cells;

		Dictionary<string, string> fields = new Dictionary<string, string>();
		fields.Add("Account", "帐号");
		fields.Add("Name", "姓名");
        fields.Add("Sex", "性别");
        fields.Add("Mobile", "电话");
        fields.Add("MemberCard", "会员卡号");
        fields.Add("Interest", "开卡店铺");
		fields.Add("CreateDate", "创建时间");
		fields.Add("IsEnabled", "启用");

		int rowIndex = 0, colIndex;
		//表头
		if (data.Rows.Count > 0) {
			colIndex = 0;
			foreach (string key in fields.Keys) {
				var name = fields[key];
				var cell = cells[rowIndex, colIndex];
				cell.PutValue(name);
				colIndex++;
			}
			rowIndex++;
		}
		//内容
		for (int i = 0; i < data.Rows.Count; i++) {
			colIndex = 0;
			DataRow dr = data.Rows[i];
			foreach (string key in fields.Keys) {
				var value = Convert.ToString(dr[key]);
				var cell = cells[rowIndex, colIndex];
				cell.PutValue(value);
				colIndex++;
			}
			rowIndex++;
		}
		//设置格式
		//sheet.AutoFitColumns();

		using (MemoryStream ms = new MemoryStream()) {
			workbook.Save(ms, SaveFormat.Excel97To2003);
			ms.Flush();

			Response.Clear();
			Response.Buffer = true;
			Response.Charset = "utf-8";
			string filename = HttpUtility.UrlPathEncode("会员列表.xls");
			Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename);
			Response.ContentEncoding = System.Text.Encoding.UTF8;
			Response.ContentType = "application/ms-excel";
			Response.BinaryWrite(ms.ToArray());
			Response.End();
		}
	}
}
