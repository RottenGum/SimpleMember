using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopServiceOrder : ModelBase
	{
		public override string TableName { get { return "shop_service_order"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _userAccount;
		private string _orderCode;
		private string _payCode;
		private string _serviceType;
		private string _address;
		private string _receiver;
		private string _tel;
		private string _memo;
		private int? _rank;
		private string _comment;
		private int? _status;
		private DateTime _reserveDate;
		private DateTime _successDate;
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
		[Column(Field = "UserAccount", Type = "varchar", Length = 96, Scale = 0)]
		public string UserAccount
		{
			get { return _userAccount; }
			set
			{
				OnPropertyChanging("UserAccount");
				_userAccount = value;
				OnPropertyChanged("UserAccount");
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
		[Column(Field = "PayCode", Type = "varchar", Length = 384, Scale = 0)]
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
		[Column(Field = "ServiceType", Type = "varchar", Length = 96, Scale = 0)]
		public string ServiceType
		{
			get { return _serviceType; }
			set
			{
				OnPropertyChanging("ServiceType");
				_serviceType = value;
				OnPropertyChanged("ServiceType");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Address", Type = "varchar", Length = 765, Scale = 0)]
		public string Address
		{
			get { return _address; }
			set
			{
				OnPropertyChanging("Address");
				_address = value;
				OnPropertyChanged("Address");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Receiver", Type = "varchar", Length = 96, Scale = 0)]
		public string Receiver
		{
			get { return _receiver; }
			set
			{
				OnPropertyChanging("Receiver");
				_receiver = value;
				OnPropertyChanged("Receiver");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Tel", Type = "varchar", Length = 96, Scale = 0)]
		public string Tel
		{
			get { return _tel; }
			set
			{
				OnPropertyChanging("Tel");
				_tel = value;
				OnPropertyChanged("Tel");
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
		[Column(Field = "Rank", Type = "int", Length = 10, Scale = 0)]
		public int? Rank
		{
			get { return _rank; }
			set
			{
				OnPropertyChanging("Rank");
				_rank = value;
				OnPropertyChanged("Rank");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Comment", Type = "text", Length = 65535, Scale = 0)]
		public string Comment
		{
			get { return _comment; }
			set
			{
				OnPropertyChanging("Comment");
				_comment = value;
				OnPropertyChanged("Comment");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Status", Type = "int", Length = 10, Scale = 0)]
		public int? Status
		{
			get { return _status; }
			set
			{
				OnPropertyChanging("Status");
				_status = value;
				OnPropertyChanged("Status");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "ReserveDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime ReserveDate
		{
			get { return _reserveDate; }
			set
			{
				OnPropertyChanging("ReserveDate");
				_reserveDate = value;
				OnPropertyChanged("ReserveDate");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "SuccessDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime SuccessDate
		{
			get { return _successDate; }
			set
			{
				OnPropertyChanging("SuccessDate");
				_successDate = value;
				OnPropertyChanged("SuccessDate");
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
