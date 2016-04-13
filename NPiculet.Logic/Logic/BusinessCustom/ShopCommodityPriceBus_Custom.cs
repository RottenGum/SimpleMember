using System;
using System.Collections.Generic;
using System.Data;
using NPiculet.Data;
using NPiculet.Logic.Data;
using NPiculet.Logic.Sys;
using NPiculet.Toolkit;

namespace NPiculet.Logic.Business
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopCommodityPriceBus
    {
		/// <summary>
		/// 计算会员价
		/// </summary>
		/// <param name="level">会员等级</param>
		/// <param name="commodityId">商品ID</param>
		/// <returns></returns>
		public double GetMemberOriginalPrice(string level, int commodityId, DateTime date)
		{
			if (commodityId == 0) return 0; //检查产品ID

			ShopCommodityBus cbus = new ShopCommodityBus();
			var commodity = cbus.QueryModel("Id =" + commodityId);

			if (commodity == null) return 0; //检查产品

			//查询会员价，并判断时间段
			ShopCommodityPriceBus pbus = new ShopCommodityPriceBus();
			var prices = pbus.QueryList("Code='" + level + "' and CommodityId=" + commodityId);
			foreach (var price in prices) {
				if (price.DateBegin <= date && price.DateEnd >= date) {
					return price.Price;
				}
			}

			//没有找到合适的会员价，默认使用产品原价
			return commodity.OriginalPrice;
		}

		/// <summary>
		/// 计算会员价
		/// </summary>
		/// <param name="level">会员等级</param>
		/// <param name="commodityId">商品ID</param>
		/// <returns></returns>
		public double GetMemberCurrentPrice(string level, int commodityId, DateTime date)
		{
			if (commodityId == 0) return 0; //检查产品ID

			ShopCommodityBus cbus = new ShopCommodityBus();
			var commodity = cbus.QueryModel("Id =" + commodityId);

			if (commodity == null) return 0; //检查产品

			//查询会员价，并判断时间段
			ShopCommodityPriceBus pbus = new ShopCommodityPriceBus();
			var prices = pbus.QueryList("Code='" + level + "' and CommodityId=" + commodityId);
			foreach (var price in prices) {
				if (price.DateBegin <= date && price.DateEnd >= date) {
					return price.Price;
				}
			}

			//没有找到合适的会员价，默认使用产品当前价
			return commodity.CurrentPrice;
		}

	}
}
