using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopSale : ModelBase
	{
		public override string TableName { get { return "shop_sale"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _commodityId;
		private Double _price;
		private DateTime _beginDate;
		private DateTime _endDate;
		private int? _isEnabled;
		private string _creator;
		private DateTime _createDate;

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
		[Column(Field = "BeginDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime BeginDate
		{
			get { return _beginDate; }
			set
			{
				OnPropertyChanging("BeginDate");
				_beginDate = value;
				OnPropertyChanged("BeginDate");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "EndDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime EndDate
		{
			get { return _endDate; }
			set
			{
				OnPropertyChanging("EndDate");
				_endDate = value;
				OnPropertyChanged("EndDate");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IsEnabled", Type = "int", Length = 10, Scale = 0)]
		public int? IsEnabled
		{
			get { return _isEnabled; }
			set
			{
				OnPropertyChanging("IsEnabled");
				_isEnabled = value;
				OnPropertyChanged("IsEnabled");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Creator", Type = "varchar", Length = 96, Scale = 0)]
		public string Creator
		{
			get { return _creator; }
			set
			{
				OnPropertyChanging("Creator");
				_creator = value;
				OnPropertyChanged("Creator");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "CreateDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime CreateDate
		{
			get { return _createDate; }
			set
			{
				OnPropertyChanging("CreateDate");
				_createDate = value;
				OnPropertyChanged("CreateDate");
			}
		}

		#endregion
	}
}
