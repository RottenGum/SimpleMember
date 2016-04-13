using System;
using System.Collections.Generic;
using System.Data;
using NPiculet.Data;
using NPiculet.Logic.Data;

namespace NPiculet.Logic.Business
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopCartBus
	{

		/// <summary>
		/// 获取购物车的商品
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public DataTable GetCartCommodity(int userId)
		{
			string sql = @"SELECT c.*, t.Amount FROM shop_commodity c
	INNER JOIN shop_cart t ON c.Id=t.CommodityId
WHERE t.UserId=" + userId;
			sql += " ORDER BY t.CreateDate";

			return CreateDao().Query(sql);
		}

		/// <summary>
		/// 获取购物车项目
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="cid"></param>
		/// <returns></returns>
		public ShopCart GetCart(int userId, int cid)
		{
			return QueryModel("UserId=" + userId + " and CommodityId=" + cid);
		}

		/// <summary>
		/// 改变数量
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="commodityId"></param>
		/// <param name="amount"></param>
		public bool ChangeAmount(int userId, int commodityId, int amount)
		{
			string sql = @"UPDATE shop_cart SET Amount=" + amount + " WHERE UserId=" + userId + " AND CommodityId=" + commodityId;
			return DbHelper.Execute(sql) > 0;
		}

	}
}
