using System;
using System.Collections.Generic;
using System.Data;
using NPiculet.Logic.Data;

namespace NPiculet.Logic.Business
{
	public partial class ShopConsultationBus : IBusiness
	{
		#region 获取数据访问类

		private ShopConsultationDao _dao = null;

		/// <summary>
		/// 创建数据访问类
		/// </summary>
		/// <returns></returns>
		public ShopConsultationDao CreateDao()
		{
			return _dao ?? (_dao = new ShopConsultationDao());
		}

		/// <summary>
		/// 创建数据实体类
		/// </summary>
		/// <returns></returns>
		public ShopConsultation CreateModel()
		{
			return new ShopConsultation();
		}

		#endregion

		#region 常用数据维护方法

		/// <summary>
		/// 新增数据
		/// </summary>
		/// <param name="model">实体类</param>
		/// <returns></returns>
		public bool Insert(ShopConsultation model)
		{
			return CreateDao().Insert(model);
		}
		
		/// <summary>
		/// 新增数据，并返回自增ID
		/// </summary>
		/// <param name="model">实体类</param>
		/// <returns></returns>
		public int InsertIdentity(ShopConsultation model)
		{
			return CreateDao().InsertIdentity(model);
		}

		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name="model">实体类</param>
		/// <param name="whereString">可选，更新条件</param>
		/// <returns></returns>
		public bool Update(ShopConsultation model, string whereString = null)
		{
			return CreateDao().Update(model, whereString);
		}

		/// <summary>
		/// 删除数据
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public bool Delete(string whereString)
		{
			return CreateDao().Delete(whereString);
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
			return CreateDao().Query(whereString, orderBy);
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
			return CreateDao().Query(curPage, pageSize, whereString, orderBy);
		}

		/// <summary>
		/// 查询实体类
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public ShopConsultation QueryModel(string whereString)
		{
			return CreateDao().QueryModel(whereString);
		}

		/// <summary>
		/// 查询实体类列表
		/// </summary>
		/// <param name="curPage">当前页码</param>
		/// <param name="pageSize">每页大小</param>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序</param>
		/// <returns></returns>
		public List<ShopConsultation> QueryList(int curPage, int pageSize = 10, string whereString = null, string orderBy = null)
		{
			return CreateDao().QueryList(curPage, pageSize, whereString, orderBy);
		}

		/// <summary>
		/// 查询实体类列表
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <param name="orderBy">排序</param>
		/// <returns></returns>
		public List<ShopConsultation> QueryList(string whereString, string orderBy = null)
		{
			return CreateDao().QueryList(whereString, orderBy);
		}

		/// <summary>
		/// 记录统计
		/// </summary>
		/// <param name="whereString">查询条件</param>
		/// <returns></returns>
		public int RecordCount(string whereString)
		{
			return CreateDao().RecordCount(whereString);
		}

		#endregion
	}
}
