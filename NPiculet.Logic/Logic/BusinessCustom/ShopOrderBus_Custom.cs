using System;
using System.Collections.Generic;
using System.Data;
using NPiculet.Data;
using NPiculet.Logic.Data;
using NPiculet.Toolkit;

namespace NPiculet.Logic.Business
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopOrderBus
	{
        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="orderCode">传入0获取全部，传入ID返回ID数据</param>
        /// <returns></returns>
        public DataTable GetOrderItemList(string orderCode, string where)
        {
            var dao = CreateDao();
            return dao.GetOrderItemList(orderCode, where);
        }

        public DataTable GetOrderItemList(string orderCode, string where, int curPage, int pageSize = 10)
        {
            var dao = CreateDao();
            return dao.GetOrderItemList(orderCode, where, curPage, pageSize);
        }

        /// <summary>
        /// 获取订单项列表
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="orderCode"></param>
        /// <returns></returns>
        public DataTable GetOrderItemList(int userId, string orderCode)
        {
            var dao = CreateDao();
            return dao.GetOrderItemList(userId, orderCode);
        }

        /// <summary>
        /// 获取最新订单列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<ShopOrder> GetNewOrderList(int userId)
        {
            string whereString = "UserId=" + userId;
            return QueryList(whereString, "CreateDate");
        }

		/// <summary>
		/// 获取订单列表
		/// </summary>
		/// <param name="whereString"></param>
		/// <returns></returns>
		public DataTable GetOrderList(int curPage, int pageSize, string whereString)
		{
			string sql = @"SELECT * FROM (SELECT o.*, (SELECT COUNT(*) FROM shop_order_item i WHERE i.OrderCode=o.OrderCode) AS Count FROM shop_order o";
			sql += ") T";

			if (!string.IsNullOrEmpty(whereString))
				sql += " WHERE " + whereString;

			sql += " ORDER BY CreateDate DESC";
			sql += " LIMIT " + pageSize + " OFFSET " + ((curPage - 1) * pageSize);

			return DbHelper.Query(sql);
		}

        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public DataTable GetOrderList(int userId, int status)
        {
            string sql = @"SELECT o.*, (SELECT COUNT(*) FROM shop_order_item i WHERE i.OrderCode=o.OrderCode) AS Count FROM shop_order o
WHERE o.UserId=" + userId;

            if (status > -1) sql += " AND o.Status='" + status + "'";

            sql += " ORDER BY o.CreateDate DESC";

            return DbHelper.Query(sql);
        }

        /// <summary>
        /// 获取订单状态名称
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public string GetStatusName(int status)
        {
            switch (status)
            {
                case 0: return "等待处理";
				case 1: return "审核通过，待支付";
                case 2: return "已支付";
                case 3: return "已完成";
				case 4: return "已关闭";
				case 5: return "退款中";
				case 6: return "已退款";
                default:
                    return "未知状态";
            }
        }

		/// <summary>
		/// 获取等待处理订单统计
		/// </summary>
		/// <returns></returns>
		public int GetWaitOrderCount()
		{
			return CreateDao().RecordCount("Status!='3'");
		}

		/// <summary>
		/// 创建订单编号
		/// </summary>
		/// <returns></returns>
		public string CreateOrderCode()
		{
			//16位时间戳数字排序订单
			//return JsonKit.ToJsDate(DateTime.Now) + StringKit.GetRandomStringByNumber(3);
			//20位明显的时间排序订单
			return StringKit.GetStringByDateTime() + StringKit.GetRandomStringByNumber(4);
		}
	}
}
