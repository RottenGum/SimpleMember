using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopComment : ModelBase
	{
		public override string TableName { get { return "shop_comment"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private int? _commodityId;
		private int? _userId;
		private string _userName;
		private string _comment;
		private int? _rank;
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
		[Column(Field = "UserName", Type = "varchar", Length = 96, Scale = 0)]
		public string UserName
		{
			get { return _userName; }
			set
			{
				OnPropertyChanging("UserName");
				_userName = value;
				OnPropertyChanged("UserName");
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
