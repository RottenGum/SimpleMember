using System;
using System.Collections.Generic;
using System.Data;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopCommodityDao
	{
        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <returns>数据集</returns>
        public DataTable GetShopCommodityList(int curPage, int pageSize, string whereString, string orderBy)
        {
            string sql = @"SELECT * FROM (
	SELECT a.*, b.`Name` AS CategoryName, c.`Name` as BrandName
	FROM shop_commodity a
		LEFT JOIN shop_category b ON a.CategoryId = b.Id
		LEFT JOIN shop_brand c ON a.BrandId = c.Id
	) T
WHERE IsDel=0";
            if (!string.IsNullOrEmpty(whereString))
                sql += " AND " + whereString;

            if (!string.IsNullOrEmpty(orderBy))
                sql += " ORDER BY " + orderBy;

            if (curPage > 0 && pageSize > 0)
            {
                sql += " LIMIT " + pageSize + " OFFSET " + ((curPage - 1) * pageSize);
            }
            var dt = base.QuerySql(sql);
            return dt;
        }

        public int GetShopCommodityCount(string whereString)
        {
            return base.RecordCount<ShopCommodity>(whereString);
        }
	}
}
