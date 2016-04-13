using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Toolkit;

public partial class modules_member_MemberEdit : AdminPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack) {
			BindData();
			//BindLog();
		}
        //this.NPager1.PageClick += (o, args) => {
        //    BindLog();
        //};
	}

	private readonly SysMemberInfoBus _userBus = new SysMemberInfoBus();
	private readonly SysMemberDataBus _dataBus = new SysMemberDataBus();
    private readonly DictItemBus _dibbus = new DictItemBus();

	private void BindData()
	{
		var userId = WebParmKit.GetRequestString("key", 0);
		if (userId > 0) {
			var model = _userBus.QueryModel("Id=" + userId);
			if (model != null) {
				BindKit.BindModelToContainer(this.editor, model);

				//this.Account.ReadOnly = true;

				var data = _dataBus.QueryModel("UserAccount='" + model.Account + "'");
				if (data != null) {
					BindKit.BindModelToContainer(this.editor, data);

					this.Id.Value = model.Id.ToString();
				}
			}
		}

        BindKit.BindToListControl(this.Partner, _dibbus.Query(" GroupCode ='partner' and IsEnabled =1"), "Name", "Name");
	}

	protected void btnSave_Click(object sender, EventArgs e)
	{
		if (Page.IsValid) {
			var model = _userBus.CreateModel();

			BindKit.FillModelFromContainer(this.editor, model);

			//保存用户信息
			if (this.Id.Value == "") {
                //if (_userBus.MemberExist(this.Account.Text)) {
                //    this.promptControl.ShowError("用户账号已存在，请重新输入！");
                //    return;
                //}
                int phonecount = _dataBus.RecordCount(" IsDel = 0 and Mobile = '" + this.Mobile.Text + "'");
                if (phonecount > 0)
                {
                    this.promptControl.ShowError("会员电话号码已存在，请重新输入！");
                    return;
                }

				//获取最大排序
				model.UserSn = Guid.NewGuid().ToString().ToLower();
				model.IsEnabled = 1;
				model.IsDel = 0;
				model.Creator = this.CurrentUserName;
				model.CreateDate = DateTime.Now;
			    model.Password = "123";
			    model.Name = this.Account.Text;
				model.Id = _userBus.InsertIdentity(model);
			} else {
				_userBus.Update(model, null);
			}

			var data = _dataBus.QueryModel("UserID='" + model.Id + "'");
			if (data == null) {
				data = _dataBus.CreateModel();
				BindKit.FillModelFromContainer(this.editor, data);
				data.UserId = model.Id;
				data.UserAccount = model.Account;
				data.IsDel = 0;
			    data.Nickname = this.Account.Text;
			    data.Memo = DateTime.Now.ToString();
			    data.Interest = this.Partner.SelectedValue;
				_dataBus.Insert(data);
			} else {
				BindKit.FillModelFromContainer(this.editor, data);
                data.UserAccount = model.Account;
                data.Interest = this.Partner.SelectedValue;
                _dataBus.Update(data, "UserID='" + data.UserId + "'");
			}
			this.Id.Value = model.Id.ToString();

			this.promptControl.ShowSuccess("保存成功！");
		}
	}

    //private void BindLog()
    //{
    //    SysActionLogBus bus = new SysActionLogBus();

    //    string whereString = "ActionAccount='" + this.Account.Text + "'";

    //    int count = bus.RecordCount(whereString);
    //    this.NPager1.PageSize = 10;
    //    this.NPager1.RecordCount = count;

    //    var dt = bus.Query(this.NPager1.CurrentPage, this.NPager1.PageSize, whereString, "Date DESC");

    //    this.details.DataSource = dt;
    //    this.details.DataBind();
    //}


    //protected string GetLawyerCertificateImage()
    //{
    //    var  tbus = new TCertificateinfoBus();
    //    var thumb = tbus.QueryModel("User_ID ="+this.Id.Value);
    //    if (thumb != null)
    //    {
    //        return string.IsNullOrEmpty(thumb.F_LawyerCertificateImage) ? "../../styles/ticket/images/nopic.jpg" : ResolveClientUrl(thumb.F_LawyerCertificateImage);
    //    }
    //    else
    //    {
    //        return "../../styles/ticket/images/nopic.jpg";
    //    }
    //}
    //protected string GetJusticeImage()
    //{
    //    var tbus = new TCertificateinfoBus();
    //    var thumb = tbus.QueryModel("User_ID =" + this.Id.Value);
    //    if (thumb != null)
    //    {
    //        return string.IsNullOrEmpty(thumb.F_JusticeImage) ? "../../styles/ticket/images/nopic.jpg" : ResolveClientUrl(thumb.F_JusticeImage);
    //    }
    //    else
    //    {
    //        return "../../styles/ticket/images/nopic.jpg";
    //    }
    //}

    //protected string GetCardIDImage()
    //{
    //    var tbus = new TCertificateinfoBus();
    //    var thumb = tbus.QueryModel("User_ID =" + this.Id.Value);
    //    if (thumb != null)
    //    {
    //        return string.IsNullOrEmpty(thumb.F_CardIDImage) ? "../../styles/ticket/images/nopic.jpg" : ResolveClientUrl(thumb.F_CardIDImage);
    //    }
    //    else
    //    {
    //        return "../../styles/ticket/images/nopic.jpg";
    //    }
    //}


}