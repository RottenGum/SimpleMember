using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopPayList : ModelBase
	{
		public override string TableName { get { return "shop_pay_list"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _branchCode;
		private int? _userId;
		private string _memberCard;
		private string _payCode;
		private decimal? _cost;
		private decimal? _point;
		private DateTime _payDate;

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
		[Column(Field = "MemberCard", Type = "varchar", Length = 96, Scale = 0)]
		public string MemberCard
		{
			get { return _memberCard; }
			set
			{
				OnPropertyChanging("MemberCard");
				_memberCard = value;
				OnPropertyChanged("MemberCard");
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
		[Column(Field = "Cost", Type = "decimal", Length = 16, Scale = 4)]
		public decimal? Cost
		{
			get { return _cost; }
			set
			{
				OnPropertyChanging("Cost");
				_cost = value;
				OnPropertyChanged("Cost");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Point", Type = "decimal", Length = 16, Scale = 4)]
		public decimal? Point
		{
			get { return _point; }
			set
			{
				OnPropertyChanging("Point");
				_point = value;
				OnPropertyChanged("Point");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "PayDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime PayDate
		{
			get { return _payDate; }
			set
			{
				OnPropertyChanging("PayDate");
				_payDate = value;
				OnPropertyChanged("PayDate");
			}
		}

		#endregion
	}
}
