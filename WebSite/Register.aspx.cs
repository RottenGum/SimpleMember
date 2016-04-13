using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Toolkit;
using NPiculet.Logic.Sys;
public partial class Register : NormalPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            SysMemberInfoBus _userBus = new SysMemberInfoBus();
            SysMemberDataBus _dataBus = new SysMemberDataBus();
           // TCertificateinfoBus cerBus = new TCertificateinfoBus();
            var account = Request.Form["account"].ToString().FormatSqlParm();
            var password = Request.Form["password"].ToString().FormatSqlParm();
            var confirmPass = Request.Form["pass-confirm"].ToString().FormatSqlParm();
            var realName = Request.Form["realname"].ToString().FormatSqlParm();
            var mobile = Request.Form["mobile"].ToString().FormatSqlParm();
            var sex = Request.Form["sex"].ToString().FormatSqlParm();
            var email = Request.Form["email"].ToString().FormatSqlParm();

            var certificateID = Request.Form["certificateID"].ToString().FormatSqlParm(); //律师证号
            var qualificationID = Request.Form["qualificationID"].ToString().FormatSqlParm(); //法律职业资格证编号
            var lawyerType = Request.Form["lawyerType"].ToString().FormatSqlParm(); //用户身份


            var existAccount = _userBus.RecordCount("Account = '" + account + "'");

            if (string.IsNullOrEmpty(email))
            {
                this.Alert("Email地址不能为空!");
                return;
            }
            Regex regemail = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            if (!regemail.IsMatch(email))
            {
                //匹配失败
                this.Alert("请填写正确的Email地址!");
                return;
            }

            if (string.IsNullOrEmpty(mobile))
            {
                this.Alert("电话号码不能为空!");
                return;
            }
            //电信手机号码正则        
            string dianxin = @"^1[3578][01379]\d{8}$";
            Regex dReg = new Regex(dianxin);
            //联通手机号正则        
            string liantong = @"^1[34578][01256]\d{8}$";
            Regex tReg = new Regex(liantong);
            //移动手机号正则        
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            Regex yReg = new Regex(yidong);

            if (dReg.IsMatch(mobile) || tReg.IsMatch(mobile) || yReg.IsMatch(mobile))
            {
                //匹配成功

            }
            else
            {
                this.Alert("请填写正确的手机号码！");
                return;
            }

            if (string.IsNullOrEmpty(certificateID))
            {
                this.Alert("律师证号不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(qualificationID))
            {
                this.Alert("法律职业资格证编号！");
                return;
            }

            if (existAccount > 0)
            {
                this.Alert("帐号已存在，请重新输入！");
                return;
            }

            SysMemberInfo member = new SysMemberInfo();
            member.UserSn = Guid.NewGuid().ToString();
            member.Account = account;
            member.Password = password;
            member.Name = realName;
            member.MemberLevel = "普通会员";
            member.CreateDate = DateTime.Now;
            member.IsEnabled = 1;
            member.IsDel = 0;

            int userId = _userBus.CreateDao().InsertIdentity(member);

            SysMemberData data = new SysMemberData();
            data.UserId = userId;
            data.UserAccount = member.Account;
            data.Email = email;
            data.Sex = sex;
            data.Mobile = mobile;
            data.IsDel = 0;

            _dataBus.Insert(data);

            //TCertificateinfo cer = new TCertificateinfo();
            //cer.F_SN = Guid.NewGuid().ToString();
            //cer.User_ID = userId;
            //cer.User_Name = member.Name;
            //cer.F_IsDel = 0;
            //cer.F_CreateDate = DateTime.Now;
            //cer.F_Creator = member.Account;
            //cer.F_LawyerCertificateID = certificateID;
            //cer.F_QualificationID = qualificationID;
            //cer.F_LawyerType = lawyerType;

            ////身份证扫描件
            ////检查上传的图片
            //if (!string.IsNullOrEmpty(this.cardIDThumb.FileName))
            //{
            //    //清理老图像
            //    if (!string.IsNullOrEmpty(this.PreviewCardIDThumb.ImageUrl))
            //    {
            //        var f = new FileInfo(Server.MapPath(this.PreviewCardIDThumb.ImageUrl));
            //        if (f.Exists) f.Delete();
            //    }
            //    //更新新图
            //    cer.F_CardIDImage = FileKit.SaveZoomImage(this.cardIDThumb.PostedFile, 900, 900);
            //}

            ////律师证扫描件
            //if (!string.IsNullOrEmpty(this.certificateIDThumb.FileName))
            //{
            //    //清理老图像
            //    if (!string.IsNullOrEmpty(this.PreviewCertificateID.ImageUrl))
            //    {
            //        var f = new FileInfo(Server.MapPath(this.PreviewCertificateID.ImageUrl));
            //        if (f.Exists) f.Delete();
            //    }
            //    //更新新图
            //    cer.F_LawyerCertificateImage = FileKit.SaveZoomImage(this.certificateIDThumb.PostedFile, 900, 900);
            //}

            ////司法考试证件扫描件
            //if (!string.IsNullOrEmpty(this.qualificationIDThumb.FileName))
            //{
            //    //清理老图像
            //    if (!string.IsNullOrEmpty(this.PreviewCertificateID.ImageUrl))
            //    {
            //        var f = new FileInfo(Server.MapPath(this.PreviewQualificationID.ImageUrl));
            //        if (f.Exists) f.Delete();
            //    }
            //    //更新新图
            //    cer.F_JusticeImage = FileKit.SaveZoomImage(this.qualificationIDThumb.PostedFile, 900, 900);
            //}
            //cerBus.Insert(cer);

            this.Alert("恭喜你注册成功，请记住你的用户名密码！");
            Response.Redirect("~/Success.aspx");
            //var user = LoginKit.MemberExist(account.ToSqlParm(), password.ToSqlParm());
            //if (user != null)
            //{
            //    LoginKit.MemberLogin(user);
            //    string url = WebParmKit.GetQuery("url", "");
            //    Response.Redirect(string.IsNullOrEmpty(url) ? "~/Default.aspx" : url);
            //}
        }
    }
}