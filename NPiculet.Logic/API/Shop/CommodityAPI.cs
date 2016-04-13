using System.Web.UI.WebControls;
using NPiculet.Logic.Sys;
using NPiculet.Toolkit;
using NPiculet.WebAPI;

namespace NPiculet.Logic
{
	/// <summary>
	/// 商品接口
	/// </summary>
	[WebApiConfig(ModuleName = "commodity")]
	public class CommodityAPI : WebApiBase
	{
		/// <summary>
		/// 商品列表
		/// </summary>
		/// <param name="render"></param>
		[WebApiConfig(ModuleName = "list")]
		public void Login(ResultRender render)
		{
			ShopCommodityInfoBus bus = new ShopCommodityInfoBus();
			render.Render(bus.Query());
		}

		/// <summary>
		/// 商品信息
		/// </summary>
		/// <param name="render"></param>
		[WebApiConfig(ModuleName = "info")]
		public void Login(ResultRender render)
		{
			ShopCommodityInfoBus bus = new ShopCommodityInfoBus();
			render.Render(bus.Query());
		}
	}
}