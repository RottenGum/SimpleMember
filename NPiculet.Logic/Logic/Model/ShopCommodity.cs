using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopCommodity : ModelBase
	{
		public override string TableName { get { return "shop_commodity"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _categoryId;
		private string _categoryType;
		private int? _supplierId;
		private int? _rootCategoryId;
		private int? _brandId;
		private string _code;
		private string _name;
		private string _pinyin;
		private string _keywords;
		private string _description;
		private string _thumb;
		private string _placeStartCode;
		private string _placeStartName;
		private string _placeEndCode;
		private string _placeEndName;
		private string _image;
		private int? _stock;
		private string _model;
		private string _unit;
		private string _address;
		private string _characteristic;
		private string _size;
		private Double _originalPrice;
		private Double _currentPrice;
		private int? _isBundling;
		private Double _bundlingPrice;
		private Double _point;
		private Double _salePoint;
		private int? _salesVolume;
		private int? _totalFavorite;
		private int? _totalComment;
		private int? _totalClick;
		private int? _isPackages;
		private int? _isLimitTime;
		private int? _isPriceOff;
		private int? _isPoint;
		private int? _isRefund;
		private string _refundMemo;
		private int? _isEnabled;
		private int? _isDel;
		private string _creator;
		private DateTime _leaveDate;
		private DateTime _arrivalDate;
		private string _reserve;
		private string _way;
		private string _scenery;
		private string _hint;
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
		[Column(Field = "CategoryId", Type = "int", Length = 10, Scale = 0)]
		public int? CategoryId
		{
			get { return _categoryId; }
			set
			{
				OnPropertyChanging("CategoryId");
				_categoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "CategoryType", Type = "varchar", Length = 48, Scale = 0)]
		public string CategoryType
		{
			get { return _categoryType; }
			set
			{
				OnPropertyChanging("CategoryType");
				_categoryType = value;
				OnPropertyChanged("CategoryType");
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
		[Column(Field = "RootCategoryId", Type = "int", Length = 10, Scale = 0)]
		public int? RootCategoryId
		{
			get { return _rootCategoryId; }
			set
			{
				OnPropertyChanging("RootCategoryId");
				_rootCategoryId = value;
				OnPropertyChanged("RootCategoryId");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "BrandId", Type = "int", Length = 10, Scale = 0)]
		public int? BrandId
		{
			get { return _brandId; }
			set
			{
				OnPropertyChanging("BrandId");
				_brandId = value;
				OnPropertyChanged("BrandId");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Code", Type = "varchar", Length = 192, Scale = 0)]
		public string Code
		{
			get { return _code; }
			set
			{
				OnPropertyChanging("Code");
				_code = value;
				OnPropertyChanged("Code");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Name", Type = "varchar", Length = 384, Scale = 0)]
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
		[Column(Field = "Pinyin", Type = "varchar", Length = 384, Scale = 0)]
		public string Pinyin
		{
			get { return _pinyin; }
			set
			{
				OnPropertyChanging("Pinyin");
				_pinyin = value;
				OnPropertyChanged("Pinyin");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Keywords", Type = "varchar", Length = 765, Scale = 0)]
		public string Keywords
		{
			get { return _keywords; }
			set
			{
				OnPropertyChanging("Keywords");
				_keywords = value;
				OnPropertyChanged("Keywords");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Description", Type = "text", Length = 65535, Scale = 0)]
		public string Description
		{
			get { return _description; }
			set
			{
				OnPropertyChanging("Description");
				_description = value;
				OnPropertyChanged("Description");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Thumb", Type = "varchar", Length = 765, Scale = 0)]
		public string Thumb
		{
			get { return _thumb; }
			set
			{
				OnPropertyChanging("Thumb");
				_thumb = value;
				OnPropertyChanged("Thumb");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "PlaceStartCode", Type = "varchar", Length = 24, Scale = 0)]
		public string PlaceStartCode
		{
			get { return _placeStartCode; }
			set
			{
				OnPropertyChanging("PlaceStartCode");
				_placeStartCode = value;
				OnPropertyChanged("PlaceStartCode");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "PlaceStartName", Type = "varchar", Length = 192, Scale = 0)]
		public string PlaceStartName
		{
			get { return _placeStartName; }
			set
			{
				OnPropertyChanging("PlaceStartName");
				_placeStartName = value;
				OnPropertyChanged("PlaceStartName");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "PlaceEndCode", Type = "varchar", Length = 24, Scale = 0)]
		public string PlaceEndCode
		{
			get { return _placeEndCode; }
			set
			{
				OnPropertyChanging("PlaceEndCode");
				_placeEndCode = value;
				OnPropertyChanged("PlaceEndCode");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "PlaceEndName", Type = "varchar", Length = 192, Scale = 0)]
		public string PlaceEndName
		{
			get { return _placeEndName; }
			set
			{
				OnPropertyChanging("PlaceEndName");
				_placeEndName = value;
				OnPropertyChanged("PlaceEndName");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Image", Type = "varchar", Length = 765, Scale = 0)]
		public string Image
		{
			get { return _image; }
			set
			{
				OnPropertyChanging("Image");
				_image = value;
				OnPropertyChanged("Image");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Stock", Type = "int", Length = 10, Scale = 0)]
		public int? Stock
		{
			get { return _stock; }
			set
			{
				OnPropertyChanging("Stock");
				_stock = value;
				OnPropertyChanged("Stock");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Model", Type = "varchar", Length = 96, Scale = 0)]
		public string Model
		{
			get { return _model; }
			set
			{
				OnPropertyChanging("Model");
				_model = value;
				OnPropertyChanged("Model");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Unit", Type = "varchar", Length = 96, Scale = 0)]
		public string Unit
		{
			get { return _unit; }
			set
			{
				OnPropertyChanging("Unit");
				_unit = value;
				OnPropertyChanged("Unit");
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
		[Column(Field = "Characteristic", Type = "varchar", Length = 765, Scale = 0)]
		public string Characteristic
		{
			get { return _characteristic; }
			set
			{
				OnPropertyChanging("Characteristic");
				_characteristic = value;
				OnPropertyChanged("Characteristic");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Size", Type = "varchar", Length = 96, Scale = 0)]
		public string Size
		{
			get { return _size; }
			set
			{
				OnPropertyChanging("Size");
				_size = value;
				OnPropertyChanged("Size");
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
		[Column(Field = "IsBundling", Type = "int", Length = 10, Scale = 0)]
		public int? IsBundling
		{
			get { return _isBundling; }
			set
			{
				OnPropertyChanging("IsBundling");
				_isBundling = value;
				OnPropertyChanged("IsBundling");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "BundlingPrice", Type = "double", Length = 22, Scale = 0)]
		public Double BundlingPrice
		{
			get { return _bundlingPrice; }
			set
			{
				OnPropertyChanging("BundlingPrice");
				_bundlingPrice = value;
				OnPropertyChanged("BundlingPrice");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Point", Type = "double", Length = 22, Scale = 0)]
		public Double Point
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
		[Column(Field = "SalePoint", Type = "double", Length = 22, Scale = 0)]
		public Double SalePoint
		{
			get { return _salePoint; }
			set
			{
				OnPropertyChanging("SalePoint");
				_salePoint = value;
				OnPropertyChanged("SalePoint");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "SalesVolume", Type = "int", Length = 10, Scale = 0)]
		public int? SalesVolume
		{
			get { return _salesVolume; }
			set
			{
				OnPropertyChanging("SalesVolume");
				_salesVolume = value;
				OnPropertyChanged("SalesVolume");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "TotalFavorite", Type = "int", Length = 10, Scale = 0)]
		public int? TotalFavorite
		{
			get { return _totalFavorite; }
			set
			{
				OnPropertyChanging("TotalFavorite");
				_totalFavorite = value;
				OnPropertyChanged("TotalFavorite");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "TotalComment", Type = "int", Length = 10, Scale = 0)]
		public int? TotalComment
		{
			get { return _totalComment; }
			set
			{
				OnPropertyChanging("TotalComment");
				_totalComment = value;
				OnPropertyChanged("TotalComment");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "TotalClick", Type = "int", Length = 10, Scale = 0)]
		public int? TotalClick
		{
			get { return _totalClick; }
			set
			{
				OnPropertyChanging("TotalClick");
				_totalClick = value;
				OnPropertyChanged("TotalClick");
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
		[Column(Field = "IsLimitTime", Type = "int", Length = 10, Scale = 0)]
		public int? IsLimitTime
		{
			get { return _isLimitTime; }
			set
			{
				OnPropertyChanging("IsLimitTime");
				_isLimitTime = value;
				OnPropertyChanged("IsLimitTime");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IsPriceOff", Type = "int", Length = 10, Scale = 0)]
		public int? IsPriceOff
		{
			get { return _isPriceOff; }
			set
			{
				OnPropertyChanging("IsPriceOff");
				_isPriceOff = value;
				OnPropertyChanged("IsPriceOff");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IsPoint", Type = "int", Length = 10, Scale = 0)]
		public int? IsPoint
		{
			get { return _isPoint; }
			set
			{
				OnPropertyChanging("IsPoint");
				_isPoint = value;
				OnPropertyChanged("IsPoint");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "IsRefund", Type = "int", Length = 10, Scale = 0)]
		public int? IsRefund
		{
			get { return _isRefund; }
			set
			{
				OnPropertyChanging("IsRefund");
				_isRefund = value;
				OnPropertyChanged("IsRefund");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "RefundMemo", Type = "text", Length = 65535, Scale = 0)]
		public string RefundMemo
		{
			get { return _refundMemo; }
			set
			{
				OnPropertyChanging("RefundMemo");
				_refundMemo = value;
				OnPropertyChanged("RefundMemo");
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
		[Column(Field = "Reserve", Type = "text", Length = 65535, Scale = 0)]
		public string Reserve
		{
			get { return _reserve; }
			set
			{
				OnPropertyChanging("Reserve");
				_reserve = value;
				OnPropertyChanged("Reserve");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Way", Type = "text", Length = 65535, Scale = 0)]
		public string Way
		{
			get { return _way; }
			set
			{
				OnPropertyChanging("Way");
				_way = value;
				OnPropertyChanged("Way");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Scenery", Type = "text", Length = 65535, Scale = 0)]
		public string Scenery
		{
			get { return _scenery; }
			set
			{
				OnPropertyChanging("Scenery");
				_scenery = value;
				OnPropertyChanged("Scenery");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Hint", Type = "text", Length = 65535, Scale = 0)]
		public string Hint
		{
			get { return _hint; }
			set
			{
				OnPropertyChanging("Hint");
				_hint = value;
				OnPropertyChanged("Hint");
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
