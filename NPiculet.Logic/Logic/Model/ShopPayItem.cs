using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopPayItem : ModelBase
	{
		public override string TableName { get { return "shop_pay_item"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _branchCode;
		private string _payCode;
		private int? _commodityId;
		private Double _originalPrice;
		private Double _currentPrice;
		private Double _amount;
		private Double _money;

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
		[Column(Field = "BranchCode", Type = "varchar", Length = 96, Scale = 0)]
		public string BranchCode
		{
			get { return _branchCode; }
			set
			{
				OnPropertyChanging("BranchCode");
				_branchCode = value;
				OnPropertyChanged("BranchCode");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "PayCode", Type = "varchar", Length = 96, Scale = 0)]
		public string PayCode
		{
			get { return _payCode; }
			set
			{
				OnPropertyChanging("PayCode");
				_payCode = value;
				OnPropertyChanged("PayCode");
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
		[Column(Field = "OriginalPrice", Type = "double", Length = 22, Scale = 0)]
		public Double OriginalPrice
		{
			get { return _originalPrice; }
			set
			{
				OnPropertyChanging("OriginalPrice");
				_originalPrice = value;
				OnPropertyChanged("OriginalPrice");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "CurrentPrice", Type = "double", Length = 22, Scale = 0)]
		public Double CurrentPrice
		{
			get { return _currentPrice; }
			set
			{
				OnPropertyChanging("CurrentPrice");
				_currentPrice = value;
				OnPropertyChanged("CurrentPrice");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Amount", Type = "double", Length = 22, Scale = 0)]
		public Double Amount
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
		[Column(Field = "Money", Type = "double", Length = 22, Scale = 0)]
		public Double Money
		{
			get { return _money; }
			set
			{
				OnPropertyChanging("Money");
				_money = value;
				OnPropertyChanged("Money");
			}
		}

		#endregion
	}
}
