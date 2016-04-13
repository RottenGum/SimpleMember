using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopCommodityPrice : ModelBase
	{
		public override string TableName { get { return "shop_commodity_price"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _commodityId;
		private string _code;
		private Double _price;
		private DateTime _dateBegin;
		private DateTime _dateEnd;
		private string _status;

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
		[Column(Field = "Code", Type = "varchar", Length = 600, Scale = 0)]
		public string Code
		{
			get { return _code; }
			set
			{
				OnPropertyChanging("Code");
				_code = value;
				OnPropertyChanged("Code");
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
		[Column(Field = "DateBegin", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime DateBegin
		{
			get { return _dateBegin; }
			set
			{
				OnPropertyChanging("DateBegin");
				_dateBegin = value;
				OnPropertyChanged("DateBegin");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "DateEnd", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime DateEnd
		{
			get { return _dateEnd; }
			set
			{
				OnPropertyChanging("DateEnd");
				_dateEnd = value;
				OnPropertyChanged("DateEnd");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Status", Type = "varchar", Length = 48, Scale = 0)]
		public string Status
		{
			get { return _status; }
			set
			{
				OnPropertyChanging("Status");
				_status = value;
				OnPropertyChanged("Status");
			}
		}

		#endregion
	}
}
