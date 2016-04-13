using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopConsultation : ModelBase
	{
		public override string TableName { get { return "shop_consultation"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _commodityId;
		private string _consultation;
		private string _reply;
		private string _contactWay;
		private int? _isShow;
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
		[Column(Field = "Consultation", Type = "text", Length = 65535, Scale = 0)]
		public string Consultation
		{
			get { return _consultation; }
			set
			{
				OnPropertyChanging("Consultation");
				_consultation = value;
				OnPropertyChanged("Consultation");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Reply", Type = "text", Length = 65535, Scale = 0)]
		public string Reply
		{
			get { return _reply; }
			set
			{
				OnPropertyChanging("Reply");
				_reply = value;
				OnPropertyChanged("Reply");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "ContactWay", Type = "varchar", Length = 192, Scale = 0)]
		public string ContactWay
		{
			get { return _contactWay; }
			set
			{
				OnPropertyChanging("ContactWay");
				_contactWay = value;
				OnPropertyChanged("ContactWay");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IsShow", Type = "int", Length = 10, Scale = 0)]
		public int? IsShow
		{
			get { return _isShow; }
			set
			{
				OnPropertyChanging("IsShow");
				_isShow = value;
				OnPropertyChanged("IsShow");
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
