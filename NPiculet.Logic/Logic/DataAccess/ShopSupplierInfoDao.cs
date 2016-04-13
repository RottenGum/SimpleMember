using System;
using System.Collections.Generic;
using System.Data;

namespace NPiculet.Logic.Data
{
	public partial class ShopSupplierInfoDao : DataDao, IDao<ShopSupplierInfo>
	{
		#region 获取数据实体类

		/// <summary>
		/// 创建数据实体类
		/// </summary>
		/// <returns></returns>
		public ShopSupplierInfo CreateModel()
		{
			return new ShopSupplierInfo();
		}

		#endregion

		#region 常用数据维护方法

		/// <summary>
		/// 新增数据
		/// </summary>
		/// <param name="model">实体类</param>
		/// <returns></returns>
		public bool Insert(ShopSupplierInfo model)
		{
			return base.Insert(model);
		}

		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name="model">实体类</param>
		/// <param name="whereString">可选，更新条件</param>
		/// <returns></returns>
		public bool Update(ShopSupplierInfo model, string whereString = null)
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
			return base.Delete<ShopSupplierInfo>(whereString);
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
			return base.Query<ShopSupplierInfo>(whereString, orderBy);
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
			return base.Query<ShopSupplierInfo>(curPage, pageSize, whereString, orderBy);
		}

		/// <summary>
		/// 查询实体类
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public ShopSupplierInfo QueryModel(string whereString)
		{
			return base.QueryModel<ShopSupplierInfo>(whereString);
		}

		/// <summary>
		/// 查询实体类列表
		/// </summary>
		/// <param name="curPage">当前页码</param>
		/// <param name="pageSize">每页大小</param>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序</param>
		/// <returns></returns>
		public List<ShopSupplierInfo> QueryList(int curPage, int pageSize = 10, string whereString = null, string orderBy = null)
		{
			return base.QueryList<ShopSupplierInfo>(curPage, pageSize, whereString, orderBy);
		}

		/// <summary>
		/// 查询实体类列表
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序</param>
		/// <returns></returns>
		public List<ShopSupplierInfo> QueryList(string whereString, string orderBy = null)
		{
			return base.QueryList<ShopSupplierInfo>(whereString, orderBy);
		}

		/// <summary>
		/// 记录统计
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public int RecordCount(string whereString)
		{
			return base.RecordCount<ShopSupplierInfo>(whereString);
		}

		#endregion
	}
}
