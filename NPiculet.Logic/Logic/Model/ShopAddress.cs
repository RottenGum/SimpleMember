using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopAddress : ModelBase
	{
		public override string TableName { get { return "shop_address"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _userAccount;
		private string _orderCode;
		private string _type;
		private string _name;
		private string _tel;
		private string _mobile;
		private string _sex;
		private string _idCardType;
		private string _idCard;
		private string _post;
		private string _province;
		private string _town;
		private string _region;
		private string _street;
		private string _address;
		private decimal? _longitude;
		private decimal? _latitude;
		private int? _isDefault;
		private int? _isDel;

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
		[Column(Field = "OrderCode", Type = "varchar", Length = 96, Scale = 0)]
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
		[Column(Field = "Type", Type = "varchar", Length = 48, Scale = 0)]
		public string Type
		{
			get { return _type; }
			set
			{
				OnPropertyChanging("Type");
				_type = value;
				OnPropertyChanged("Type");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Name", Type = "varchar", Length = 192, Scale = 0)]
		public string Name
		{
			get { return _name; }
			set
			{
				OnPropertyChanging("Name");
				_name = value;
				OnPropertyChanged("Name");
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
		[Column(Field = "Mobile", Type = "varchar", Length = 96, Scale = 0)]
		public string Mobile
		{
			get { return _mobile; }
			set
			{
				OnPropertyChanging("Mobile");
				_mobile = value;
				OnPropertyChanged("Mobile");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Sex", Type = "varchar", Length = 24, Scale = 0)]
		public string Sex
		{
			get { return _sex; }
			set
			{
				OnPropertyChanging("Sex");
				_sex = value;
				OnPropertyChanged("Sex");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IdCardType", Type = "varchar", Length = 48, Scale = 0)]
		public string IdCardType
		{
			get { return _idCardType; }
			set
			{
				OnPropertyChanging("IdCardType");
				_idCardType = value;
				OnPropertyChanged("IdCardType");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IdCard", Type = "varchar", Length = 96, Scale = 0)]
		public string IdCard
		{
			get { return _idCard; }
			set
			{
				OnPropertyChanging("IdCard");
				_idCard = value;
				OnPropertyChanged("IdCard");
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
		[Column(Field = "Province", Type = "varchar", Length = 300, Scale = 0)]
		public string Province
		{
			get { return _province; }
			set
			{
				OnPropertyChanging("Province");
				_province = value;
				OnPropertyChanged("Province");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Town", Type = "varchar", Length = 300, Scale = 0)]
		public string Town
		{
			get { return _town; }
			set
			{
				OnPropertyChanging("Town");
				_town = value;
				OnPropertyChanged("Town");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Region", Type = "varchar", Length = 300, Scale = 0)]
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
		[Column(Field = "Street", Type = "varchar", Length = 96, Scale = 0)]
		public string Street
		{
			get { return _street; }
			set
			{
				OnPropertyChanging("Street");
				_street = value;
				OnPropertyChanged("Street");
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
		[Column(Field = "IsDefault", Type = "int", Length = 10, Scale = 0)]
		public int? IsDefault
		{
			get { return _isDefault; }
			set
			{
				OnPropertyChanging("IsDefault");
				_isDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IsDel", Type = "int", Length = 10, Scale = 0)]
		public int? IsDel
		{
			get { return _isDel; }
			set
			{
				OnPropertyChanging("IsDel");
				_isDel = value;
				OnPropertyChanged("IsDel");
			}
		}

		#endregion
	}
}
