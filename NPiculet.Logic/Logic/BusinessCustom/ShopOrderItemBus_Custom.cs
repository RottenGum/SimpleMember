using System;
using System.Collections.Generic;
using System.Data;
using NPiculet.Logic.Data;
using NPiculet.Data;

namespace NPiculet.Logic.Business
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopOrderItemBus
	{

		public DataTable GetOrderCommodity(string orderCode)
		{
            string sql = @"SELECT c.*, t.Amount,t.OccupancyDay FROM shop_commodity c
	INNER JOIN shop_order_item t ON c.Id=t.CommodityId
WHERE t.OrderCode='" + orderCode + "'";
			//sql += " ORDER BY t.CreateDate";

			return DbHelper.Query(sql);
		}

        public DataTable GetOrderCommodityList(string orderCode)
        {
            string sql = @"select a.*,b.OrderCode,c.TotalPrice,c.Tel,c.CreateDate as OrderDate,c.`Status` from shop_commodity a
right join shop_order_item b
on a.Id = b.CommodityId 
LEFT JOIN shop_order c
on b.OrderCode = c.OrderCode
where a.IsDel=0 and  b.OrderCode='" + orderCode + "'";
            //sql += " ORDER BY t.CreateDate";

            return CreateDao().Query(sql);
        }

	}
}
