using System.Web.UI.WebControls;
using NPiculet.Logic.Sys;
using NPiculet.Toolkit;
using NPiculet.WebAPI;

namespace NPiculet.Logic
{
    ///// <summary>
    ///// 登录接口
    ///// </summary>
    //[WebApiConfig(ModuleName = "login")]
    //public class LoginAPI : WebApiBase
    //{
    //    /// <summary>
    //    /// 登录授权
    //    /// </summary>
    //    /// <param name="render"></param>
    //    [WebApiConfig(ModuleName = "auth")]
    //    public void Login(ResultRender render)
    //    {
    //        string account = WebParmKit.GetQuery("account", "");
    //        string password = WebParmKit.GetQuery("pass", "");
    //        var user = LoginKit.AdminExist(account, password);
    //        if (user != null) {
    //            render.Render(new { result = LoginKit.AdminLogin(user) });
    //        } else {
    //            render.Render(new { error = "登录失败！" });
    //        }
    //    }
	//}
}