using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopPackages : ModelBase
	{
		public override string TableName { get { return "shop_packages"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _parentId;
		private string _commodityType;
		private int? _commodityId;
		private string _commodityName;
		private int? _amount;
		private Double _price;
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
		[Column(Field = "CommodityType", Type = "varchar", Length = 48, Scale = 0)]
		public string CommodityType
		{
			get { return _commodityType; }
			set
			{
				OnPropertyChanging("CommodityType");
				_commodityType = value;
				OnPropertyChanged("CommodityType");
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
		[Column(Field = "CommodityName", Type = "varchar", Length = 384, Scale = 0)]
		public string CommodityName
		{
			get { return _commodityName; }
			set
			{
				OnPropertyChanging("CommodityName");
				_commodityName = value;
				OnPropertyChanged("CommodityName");
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
