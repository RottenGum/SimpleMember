using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopSupplierInfo : ModelBase
	{
		public override string TableName { get { return "shop_supplier_info"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _companyName;
		private string _companyCode;
		private string _companyProperty;
		private string _address;
		private decimal? _longitude;
		private decimal? _latitude;
		private string _post;
		private string _region;
		private string _contact;
		private string _tel;
		private string _memo;
		private string _status;
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
		[Column(Field = "CompanyName", Type = "varchar", Length = 384, Scale = 0)]
		public string CompanyName
		{
			get { return _companyName; }
			set
			{
				OnPropertyChanging("CompanyName");
				_companyName = value;
				OnPropertyChanged("CompanyName");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "CompanyCode", Type = "varchar", Length = 192, Scale = 0)]
		public string CompanyCode
		{
			get { return _companyCode; }
			set
			{
				OnPropertyChanging("CompanyCode");
				_companyCode = value;
				OnPropertyChanged("CompanyCode");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "CompanyProperty", Type = "varchar", Length = 192, Scale = 0)]
		public string CompanyProperty
		{
			get { return _companyProperty; }
			set
			{
				OnPropertyChanging("CompanyProperty");
				_companyProperty = value;
				OnPropertyChanged("CompanyProperty");
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
		[Column(Field = "Contact", Type = "varchar", Length = 96, Scale = 0)]
		public string Contact
		{
			get { return _contact; }
			set
			{
				OnPropertyChanging("Contact");
				_contact = value;
				OnPropertyChanged("Contact");
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
