using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopOrder : ModelBase
	{
		public override string TableName { get { return "shop_order"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _userId;
		private int? _supplierId;
		private string _orderType;
		private string _orderCode;
		private string _payCode;
		private string _postCode;
		private decimal? _totalPrice;
		private int? _personNumber;
		private int? _childrenNumber;
		private DateTime _createDate;
		private DateTime _successDate;
		private DateTime _payDate;
		private DateTime _sendDate;
		private string _address;
		private decimal? _longitude;
		private decimal? _latitude;
		private string _post;
		private string _region;
		private string _receiver;
		private string _tel;
		private string _memo;
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
		[Column(Field = "SupplierId", Type = "int", Length = 10, Scale = 0)]
		public int? SupplierId
		{
			get { return _supplierId; }
			set
			{
				OnPropertyChanging("SupplierId");
				_supplierId = value;
				OnPropertyChanged("SupplierId");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "OrderType", Type = "varchar", Length = 48, Scale = 0)]
		public string OrderType
		{
			get { return _orderType; }
			set
			{
				OnPropertyChanging("OrderType");
				_orderType = value;
				OnPropertyChanged("OrderType");
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
		[Column(Field = "PostCode", Type = "varchar", Length = 384, Scale = 0)]
		public string PostCode
		{
			get { return _postCode; }
			set
			{
				OnPropertyChanging("PostCode");
				_postCode = value;
				OnPropertyChanged("PostCode");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "TotalPrice", Type = "decimal", Length = 16, Scale = 2)]
		public decimal? TotalPrice
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

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "SendDate", Type = "datetime", Length = 0, Scale = 0)]
		public DateTime SendDate
		{
			get { return _sendDate; }
			set
			{
				OnPropertyChanging("SendDate");
				_sendDate = value;
				OnPropertyChanged("SendDate");
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
		[Column(Field = "Longitude", Type = "decimal", Length = 16, Scale = 8)]
		public decimal? Longitude
		{
			get { return _longitude; }
			set
			{
				OnPropertyChanging("Longitude");
				_longitude = value;
				OnPropertyChanged("Longitude");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Latitude", Type = "decimal", Length = 16, Scale = 8)]
		public decimal? Latitude
		{
			get { return _latitude; }
			set
			{
				OnPropertyChanging("Latitude");
				_latitude = value;
				OnPropertyChanged("Latitude");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Post", Type = "varchar", Length = 96, Scale = 0)]
		public string Post
		{
			get { return _post; }
			set
			{
				OnPropertyChanging("Post");
				_post = value;
				OnPropertyChanged("Post");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Region", Type = "varchar", Length = 96, Scale = 0)]
		public string Region
		{
			get { return _region; }
			set
			{
				OnPropertyChanging("Region");
				_region = value;
				OnPropertyChanged("Region");
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
