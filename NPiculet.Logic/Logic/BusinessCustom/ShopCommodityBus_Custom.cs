using System;
using System.Collections.Generic;
using System.Data;
using NPiculet.Logic.Data;

namespace NPiculet.Logic.Business
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopCommodityBus
	{
        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetShopCommodityList(int curPage, int pageSize, string whereString, string orderBy)
        {
            var dao = CreateDao();
            return dao.GetShopCommodityList(curPage, pageSize, whereString, orderBy);
        }

        public int GetShopCommodityCount(string whereString)
        {
            var dao = CreateDao();
            return dao.GetShopCommodityCount(whereString);
        }

        /// <summary>
        /// 获取排行列表
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<ShopCommodity> GetRankList(int categoryId)
        {
            string whereString = "";
            if (categoryId > 0)
            {
                whereString = "CategoryId IN (SELECT Id FROM shop_category WHERE Path LIKE CONCAT((SELECT Path FROM shop_category WHERE Id=" + categoryId + "), '/" + categoryId + "', '%'))";
            }
            return CreateDao().QueryList(1, 10, whereString, "TotalClick DESC, CreateDate DESC");
        }

		public DataTable GetCommodityInfo(int cid)
		{
			string sql = @"SELECT c.*, d.`Value`, d.Memo FROM shop_commodity c
	LEFT JOIN npc_dict_item d ON c.IsRefund=d.Id
WHERE c.Id=" + cid;
			return CreateDao().QuerySql(sql);
		}
	}
}
