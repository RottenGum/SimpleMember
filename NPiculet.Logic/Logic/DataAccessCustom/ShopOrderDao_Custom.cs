using System;
using System.Collections.Generic;
using System.Data;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopOrderDao
	{
        #region 自定义方法

        public DataTable GetOrderItemList(string orderCode, string where2)
        {
//            string sql = @"SELECT	b.*, a.price,	d.`Name` AS UserName,	c.*, e.Address,	f.`Name` AS DerStatus,	a.Amount FROM	shop_order_item a left JOIN shop_order b on a.OrderCode = b.OrderCode LEFT JOIN shop_commodity c
//on c.Id = a.CommodityId LEFT JOIN sys_user_info d on d.Id = b.UserId LEFT JOIN der_address e on b.Postcode = e.Id  LEFT JOIN dict_item f on b.`Status` = f.`Value` and f.GroupCode = 'DerStatus'  ";
			string sql = @"SELECT
	a.*, b.UserId, m.`Name` AS UserName, b.OrderType, b.PayCode, b.PostCode, b.TotalPrice AS OrderTotalPrice, b.PersonNumber
	, b.ChildrenNumber, b.CreateDate, b.SuccessDate, b.PayDate, b.SendDate, b.Address, b.Longitude, b.Latitude
	, b.Post, b.Region, b.Receiver, b.Tel, b.Status
	, c.CategoryId, c.CategoryType, c.SupplierId, c.BrandId, c.`Code`, c.`Name`
	, c.Pinyin, c.Keywords, c.Description, c.Thumb, c.PlaceStartCode, c.PlaceStartName, c.PlaceEndCode, c.PlaceEndName
	, c.Image, c.Stock, c.Model AS CommodityModel, c.Unit, c.Characteristic, c.Size, c.OriginalPrice, c.CurrentPrice
	, c.IsBundling, c.BundlingPrice, c.Point, c.SalePoint, c.SalesVolume, c.TotalFavorite, c.TotalComment, c.TotalClick
	, c.IsPackages, c.IsLimitTime, c.IsPriceOff, c.IsPoint, c.IsRefund, c.IsEnabled, c.IsDel
	, c.Reserve, c.Way, c.Scenery, c.Hint
	, f.`Name` AS DerStatus
FROM shop_order_item a
	INNER JOIN shop_order b ON a.OrderCode = b.OrderCode
	INNER JOIN npc_sys_member_info m ON m.Id = b.UserId
	LEFT JOIN shop_commodity c ON c.Id = a.CommodityId
	LEFT JOIN npc_dict_item f ON b.`Status` = f.`Value` AND f.GroupCode = 'DerStatus'";

            string where = " WHERE 1=1 and c.IsDel = 0 and c.Id IS NOT NULL "; 
            if (!string.IsNullOrEmpty(orderCode))
            {
                where += " and a.OrderCode='" + orderCode + "'";
            }

            var dt = base.QuerySql(sql + where + where2 + " order BY b.CreateDate DESC");
            return dt;
        }

        public DataTable GetOrderItemList(string orderCode, string where2, int curPage, int pageSize = 10)
        {
            /*
            string sql = @"SELECT b.*, a.price, d.`Name` AS UserName, c.*, e.Address, f.`Name` AS DerStatus,	a.Amount
FROM shop_order_item a
	INNER JOIN shop_order b on a.OrderCode = b.OrderCode
	LEFT JOIN shop_commodity c ON c.Id = a.CommodityId
	LEFT JOIN sys_user_info d on d.Id = b.UserId
	LEFT JOIN der_address e on b.Postcode = e.Id
	LEFT JOIN dict_item f on b.`Status` = f.`Value` and f.GroupCode = 'DerStatus'";
             */
			string sql = @"SELECT
	a.*, b.UserId, m.`Name` AS UserName, b.OrderType, b.PayCode, b.PostCode, b.TotalPrice AS OrderTotalPrice, b.PersonNumber
	, b.ChildrenNumber, b.CreateDate, b.SuccessDate, b.PayDate, b.SendDate, b.Address, b.Longitude, b.Latitude
	, b.Post, b.Region, b.Receiver, b.Tel, b.Status
	, c.CategoryId, c.CategoryType, c.SupplierId, c.BrandId, c.`Code`, c.`Name`
	, c.Pinyin, c.Keywords, c.Description, c.Thumb, c.PlaceStartCode, c.PlaceStartName, c.PlaceEndCode, c.PlaceEndName
	, c.Image, c.Stock, c.Model AS CommodityModel, c.Unit, c.Characteristic, c.Size, c.OriginalPrice, c.CurrentPrice
	, c.IsBundling, c.BundlingPrice, c.Point, c.SalePoint, c.SalesVolume, c.TotalFavorite, c.TotalComment, c.TotalClick
	, c.IsPackages, c.IsLimitTime, c.IsPriceOff, c.IsPoint, c.IsRefund, c.IsEnabled, c.IsDel
	, c.Reserve, c.Way, c.Scenery, c.Hint
	, f.`Name` AS DerStatus
FROM shop_order_item a
	INNER JOIN shop_order b ON a.OrderCode = b.OrderCode
	INNER JOIN npc_sys_member_info m ON m.Id = b.UserId
	LEFT JOIN shop_commodity c ON c.Id = a.CommodityId
	LEFT JOIN npc_dict_item f ON b.`Status` = f.`Value` AND f.GroupCode = 'DerStatus'";

            string where = " WHERE c.IsDel = 0 and c.Id IS NOT NULL ";
            if (!string.IsNullOrEmpty(orderCode))
            {
                where += " and a.OrderCode='" + orderCode + "'";
            }

            //where += " Order by a.ID ";
            string where3 = string.Format(@" LIMIT {0}, {1}"
				, ((curPage - 1) * pageSize)
				, 10);

            var dt = base.QuerySql(sql + where + where2 + " order BY b.CreateDate DESC " + where3);
            return dt;
        }

        public DataTable GetOrderItemList(int userId, string orderCode)
        {
            string sql = @"SELECT i.*, c.`Name`, o.TotalPrice, c.CurrentPrice, o.`Status`
FROM shop_order o
	INNER JOIN shop_order_item i ON o.OrderCode = i.OrderCode
	INNER JOIN shop_commodity c ON c.Id = i.CommodityId";
            string where = " WHERE o.UserId=" + userId;

            if (!string.IsNullOrEmpty(orderCode))
            {
                where += " and o.OrderCode='" + orderCode + "'";
            }

            var dt = base.QuerySql(sql + where + " ORDER BY o.CreateDate DESC");
            return dt;
        }

        #endregion
	}
}
