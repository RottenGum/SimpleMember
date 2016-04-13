using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Logic.Sys;
using NPiculet.Toolkit;

public partial class web_MyData : MemberPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        var user = LoginKit.GetCurrentMember();
        if (user == null)
        {
            this.Alert("无法获取用户信息！");
            return;
        }

        SysMemberDataBus bus = new SysMemberDataBus();

        var model = bus.QueryModel(" IsDel = 0 and UserId=" + user.Id);
        if (model != null)
        {
            BindKit.BindModelToContainer(this.frm, model);
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SysMemberDataBus bus = new SysMemberDataBus();
        SysMemberData smd = new SysMemberData();
        BindKit.FillModelFromContainer(this.frm, smd);
        try
        {
            if (!string.IsNullOrEmpty(this.Id.Value))
            {
                int id;
                int.TryParse(this.Id.Value, out id);
                bus.Update(smd, " IsDel = 0 and UserId=" + id);
                this.Alert("修改用户信息成功！");
            }
        }
        catch (Exception ex)
        {
            this.Alert("修改用户信息失败！原因:" + ex.ToString());
            return; ;
        }
    }
}