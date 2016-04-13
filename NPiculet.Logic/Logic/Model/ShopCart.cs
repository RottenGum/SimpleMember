using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopCart : ModelBase
	{
		public override string TableName { get { return "shop_cart"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _userId;
		private int? _parentId;
		private int? _commodityId;
		private int? _amount;
		private string _memberLevel;
		private Double _price;
		private Double _totalPrice;
		private int? _personNumber;
		private int? _childrenNumber;
		private DateTime _arrivalDate;
		private DateTime _leaveDate;
		private int? _occupancyDay;
		private int? _isPackages;
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
		[Column(Field = "UserId", Type = "int", Length = 10, Scale = 0)]
		public int? UserId
		{
			get { return _userId; }
			set
			{
				OnPropertyChanging("UserId");
				_userId = value;
				OnPropertyChanged("UserId");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "ParentId", Type = "int", Length = 10, Scale = 0)]
		public int? ParentId
		{
			get { return _parentId; }
			set
			{
				OnPropertyChanging("ParentId");
				_parentId = value;
				OnPropertyChanged("ParentId");
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
		[Column(Field = "MemberLevel", Type = "varchar", Length = 48, Scale = 0)]
		public string MemberLevel
		{
			get { return _memberLevel; }
			set
			{
				OnPropertyChanging("MemberLevel");
				_memberLevel = value;
				OnPropertyChanged("MemberLevel");
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
		[Column(Field = "PersonNumber", Type = "int", Length = 10, Scale = 0)]
		public int? PersonNumber
		{
			get { return _personNumber; }
			set
			{
				OnPropertyChanging("PersonNumber");
				_personNumber = value;
				OnPropertyChanged("PersonNumber");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "ChildrenNumber", Type = "int", Length = 10, Scale = 0)]
		public int? ChildrenNumber
		{
			get { return _childrenNumber; }
			set
			{
				OnPropertyChanging("ChildrenNumber");
				_childrenNumber = value;
				OnPropertyChanged("ChildrenNumber");
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

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IsPackages", Type = "int", Length = 10, Scale = 0)]
		public int? IsPackages
		{
			get { return _isPackages; }
			set
			{
				OnPropertyChanging("IsPackages");
				_isPackages = value;
				OnPropertyChanged("IsPackages");
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
