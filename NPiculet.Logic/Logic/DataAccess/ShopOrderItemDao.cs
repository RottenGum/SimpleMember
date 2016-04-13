using System;
using System.Collections.Generic;
using System.Data;

namespace NPiculet.Logic.Data
{
	public partial class ShopOrderItemDao : DataDao, IDao<ShopOrderItem>
	{
		#region 获取数据实体类

		/// <summary>
		/// 创建数据实体类
		/// </summary>
		/// <returns></returns>
		public ShopOrderItem CreateModel()
		{
			return new ShopOrderItem();
		}

		#endregion

		#region 常用数据维护方法

		/// <summary>
		/// 新增数据
		/// </summary>
		/// <param name="model">实体类</param>
		/// <returns></returns>
		public bool Insert(ShopOrderItem model)
		{
			return base.Insert(model);
		}

		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name="model">实体类</param>
		/// <param name="whereString">可选，更新条件</param>
		/// <returns></returns>
		public bool Update(ShopOrderItem model, string whereString = null)
		{
			return base.Update(model, whereString);
		}

		/// <summary>
		/// 删除数据
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public bool Delete(string whereString)
		{
			return base.Delete<ShopOrderItem>(whereString);
		}

		#endregion

		#region 常用查询方法

		/// <summary>
		/// 查询数据表
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序字段</param>
		/// <returns></returns>
		public DataTable Query(string whereString = null, string orderBy = null)
		{
			return base.Query<ShopOrderItem>(whereString, orderBy);
		}

		/// <summary>
		/// 查询数据表，并分页返回
		/// </summary>
		/// <param name="curPage">当前页码</param>
		/// <param name="pageSize">分页大小</param>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序字段</param>
		/// <returns></returns>
		public DataTable Query(int curPage, int pageSize = 10, string whereString = null, string orderBy = null)
		{
			return base.Query<ShopOrderItem>(curPage, pageSize, whereString, orderBy);
		}

		/// <summary>
		/// 查询实体类
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public ShopOrderItem QueryModel(string whereString)
		{
			return base.QueryModel<ShopOrderItem>(whereString);
		}

		/// <summary>
		/// 查询实体类列表
		/// </summary>
		/// <param name="curPage">当前页码</param>
		/// <param name="pageSize">每页大小</param>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序</param>
		/// <returns></returns>
		public List<ShopOrderItem> QueryList(int curPage, int pageSize = 10, string whereString = null, string orderBy = null)
		{
			return base.QueryList<ShopOrderItem>(curPage, pageSize, whereString, orderBy);
		}

		/// <summary>
		/// 查询实体类列表
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序</param>
		/// <returns></returns>
		public List<ShopOrderItem> QueryList(string whereString, string orderBy = null)
		{
			return base.QueryList<ShopOrderItem>(whereString, orderBy);
		}

		/// <summary>
		/// 记录统计
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public int RecordCount(string whereString)
		{
			return base.RecordCount<ShopOrderItem>(whereString);
		}

		#endregion
	}
}
