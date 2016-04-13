using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Cells;
using NPiculet.Logic;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Toolkit;

public partial class modules_system_DictItemList : AdminPage
{
    protected void Page_Load(object sender, EventArgs e) {
		//修改表头
		BindTableHeader();
		//绑定数据
		if (!Page.IsPostBack) {
	        BindDictGroup();

			//获取字典分组
			string group = WebParmKit.GetQuery("group", "");
			string fix = WebParmKit.GetQuery("fix", "");
			if (!string.IsNullOrEmpty(group)) {
				this.ddlDictGroup.SelectedIndex = this.ddlDictGroup.Items.IndexOf(this.ddlDictGroup.Items.FindByValue(group));
			}
			if (fix == "true") {
				this.ddlDictGroup.Enabled = false;
				this.ddlDictGroup.Visible = false;
			}
			//绑定数据
			BindData();
		}
		//分页事件
		this.NPager1.PageClick += (o, args) => {
			BindData();
		};
    }

	private void BindTableHeader() {
		string colnumNames = WebParmKit.GetQuery("cols", "");
		if (!string.IsNullOrEmpty(colnumNames)) {
			string[] cols = colnumNames.Split(',');
			for (int i = 0; i < cols.Length; i++) {
				this.list.Columns[i].HeaderText = cols[i];
			}
		}
	}

    private readonly DictItemBus _bus = new DictItemBus();

	private void BindDictGroup()
	{
		DictGroupBus gbus = new DictGroupBus();
		this.ddlDictGroup.DataSource = gbus.Query("IsDel=0", null);
		this.ddlDictGroup.DataTextField = "Name";
		this.ddlDictGroup.DataValueField = "Code";
		this.ddlDictGroup.DataBind();
		this.ddlDictGroup.Items.Insert(0, new ListItem("全部", ""));
	}

    private void BindData()
    {
		string whereString = "";
		string key = this.txtKeywords.Text.FormatSqlParm();

		if (!string.IsNullOrEmpty(this.ddlDictGroup.SelectedValue)) whereString = string.Format("`GroupCode`='{0}'", this.ddlDictGroup.SelectedValue);
		if (!string.IsNullOrEmpty(key)) {
			if (!string.IsNullOrEmpty(whereString)) whereString += " AND ";
			whereString += string.Format("(Name LIKE '%{0}%' OR Code LIKE '%{0}%')", key);
		}

	    int count = _bus.RecordCount(whereString);

	    this.NPager1.PageSize = 10;
	    this.NPager1.RecordCount = count;

		this.list.DataSource = _bus.GetDictItemData(this.NPager1.CurrentPage, this.NPager1.PageSize, this.ddlDictGroup.SelectedValue, this.txtKeywords.Text);
        this.list.DataBind();

        BindKit.BindOnClientClick(this.list, "Delete", "return confirm('确定要删除吗？');");
    }

    protected void list_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            if (this.list.DataKeys.Count > e.RowIndex){
                string id = this.list.DataKeys[e.RowIndex]["Id"].ToString();
                _bus.Delete("Id=" + id);
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
	    BindData();
    }

	protected void btnUserImport_Click(object sender, EventArgs e) {
		string fileName = this.fileXls.FileName;

		if (string.IsNullOrEmpty(fileName) || this.fileXls.PostedFile.ContentLength == 0) {
			this.Alert("请选择导入的文件！");
			return;
		}

		//将文件流读取到内存
		var hpf = this.fileXls.PostedFile;
		Workbook workbook = new Workbook(hpf.InputStream);

		DictItemBus dbus = new DictItemBus();

		Cells cells = workbook.Worksheets[0].Cells;
		for (int i = 1; i <= cells.MaxDataRow; i++) { //行
			DictItem item = new DictItem();
			for (int j = 1; j <= cells.MaxDataColumn; j++) { //单元格
				//获取单元格的值
				switch (j) {
					case 1: item.Name = cells[i, j].StringValue.Trim(); break;
					case 2: item.Code = cells[i, j].StringValue.Trim(); break;
					case 3: item.Value = cells[i, j].StringValue.Trim(); break;
					case 4: item.Memo = cells[i, j].StringValue.Trim(); break;
					//case 5: item.OrderBy = cells[i, j].IntValue; break;
				}
				if (string.IsNullOrEmpty(item.Value)) {
					item.Value = item.Name;
				}
			}
			item.CreateDate = DateTime.Now;
			item.GroupCode = this.ddlDictGroup.SelectedValue;
			item.Creator = this.CurrentUserName;
			item.IsEnabled = 1;
			if (!string.IsNullOrEmpty(item.Name) && !string.IsNullOrEmpty(item.Code) && !string.IsNullOrEmpty(item.Value)) {
				if (!dbus.Update(item, "Name='" + item.Name + "'"))
					dbus.Insert(item);
			}
		}
		this.Alert("导入成功！");
		BindData();
	}

}