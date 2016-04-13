using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.WebControls;

public partial class modules_common_OrgDialog : NormalPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (!Page.IsPostBack) {
			_html = string.Empty;
			BindOrgTree();
	    }
    }

	private DataView _dv = null;
	private string _html;

	private void BindOrgTree()
	{
		SysOrgInfoBus bus = new SysOrgInfoBus();
		DataTable dt = bus.Query();
		if (dt != null) {
			_dv = dt.DefaultView;
		}
		BuildTree(0);
		this.tree.Text = _html;
	}

	private void BuildTree(int parentId)
	{
		_dv.RowFilter = "ParentId=" + parentId;
		_html += "<ul>";
		foreach (DataRowView dr in _dv) {
			_html += "<li data-id=\"" + dr["Id"] + "\">" + dr["OrgName"] + "</li>";
			//if (nodes == null) nodes = this.tree.Nodes;
			//TreeNode tn = new TreeNode(dr["OrgName"].ToString(), dr["Id"].ToString());
			//nodes.Add(tn);
			//BuildTree(tn.ChildNodes, (int)dr["Id"]);
			BuildTree((int)dr["Id"]);
		}
		_html += "</ul>";
	}

	string result = "";

	protected void btnOk_Click(object sender, EventArgs e)
	{
		//GetSelectedNodes(this.tree.Nodes);
		//if (!string.IsNullOrEmpty(result)) {
		//	this.JavaSrcipt("ok('" + result + "');");
		//} else {
		//	this.Alert("您还没有选中任何数据！");
		//}
	}

	private void GetSelectedNodes(TreeNodeCollection nodes)
	{
		//foreach (TreeNode node in nodes) {
		//	if (node.Checked) {
		//		if (!string.IsNullOrEmpty(result)) result += ",";
		//		result += node.Value;
		//	}
		//	GetSelectedNodes(node.ChildNodes);
		//}
	}
}