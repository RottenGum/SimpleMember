using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopOrderItem : ModelBase
	{
		public override string TableName { get { return "shop_order_item"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _orderCode;
		private int? _commodityId;
		private int? _amount;
		private string _model;
		private Double _price;
		private Double _totalPrice;
		private string _memo;
		private DateTime _arrivalDate;
		private DateTime _leaveDate;
		private int? _occupancyDay;

		#endregion

		#region 数据项（访问器）

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Id", Type = "int", Length = 10, Scale = 0)]
		public int Id
		{
			get { return _id; }
			set
			{
				OnPropertyChanging("Id");
				_id = value;
				OnPropertyChanged("Id");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "OrderCode", Type = "varchar", Length = 192, Scale = 0)]
		public string OrderCode
		{
			get { return _orderCode; }
			set
			{
				OnPropertyChanging("OrderCode");
				_orderCode = value;
				OnPropertyChanged("OrderCode");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "CommodityId", Type = "int", Length = 10, Scale = 0)]
		public int? CommodityId
		{
			get { return _commodityId; }
			set
			{
				OnPropertyChanging("CommodityId");
				_commodityId = value;
				OnPropertyChanged("CommodityId");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Amount", Type = "int", Length = 10, Scale = 0)]
		public int? Amount
		{
			get { return _amount; }
			set
			{
				OnPropertyChanging("Amount");
				_amount = value;
				OnPropertyChanged("Amount");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Model", Type = "varchar", Length = 384, Scale = 0)]
		public string Model
		{
			get { return _model; }
			set
			{
				OnPropertyChanging("Model");
				_model = value;
				OnPropertyChanged("Model");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Price", Type = "double", Length = 22, Scale = 0)]
		public Double Price
		{
			get { return _price; }
			set
			{
				OnPropertyChanging("Price");
				_price = value;
				OnPropertyChanged("Price");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "TotalPrice", Type = "double", Length = 22, Scale = 0)]
		public Double TotalPrice
		{
			get { return _totalPrice; }
			set
			{
				OnPropertyChanging("TotalPrice");
				_totalPrice = value;
				OnPropertyChanged("TotalPrice");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Memo", Type = "text", Length = 65535, Scale = 0)]
		public string Memo
		{
			get { return _memo; }
			set
			{
				OnPropertyChanging("Memo");
				_memo = value;
				OnPropertyChanged("Memo");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "ArrivalDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime ArrivalDate
		{
			get { return _arrivalDate; }
			set
			{
				OnPropertyChanging("ArrivalDate");
				_arrivalDate = value;
				OnPropertyChanged("ArrivalDate");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "LeaveDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime LeaveDate
		{
			get { return _leaveDate; }
			set
			{
				OnPropertyChanging("LeaveDate");
				_leaveDate = value;
				OnPropertyChanged("LeaveDate");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "OccupancyDay", Type = "int", Length = 10, Scale = 0)]
		public int? OccupancyDay
		{
			get { return _occupancyDay; }
			set
			{
				OnPropertyChanging("OccupancyDay");
				_occupancyDay = value;
				OnPropertyChanged("OccupancyDay");
			}
		}

		#endregion
	}
}
