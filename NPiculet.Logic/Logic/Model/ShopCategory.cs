using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopCategory : ModelBase
	{
		public override string TableName { get { return "shop_category"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _appCode;
		private string _type;
		private int? _parentId;
		private int? _rootId;
		private string _path;
		private string _name;
		private string _code;
		private string _icon;
		private int? _depth;
		private string _comment;
		private int? _orderBy;
		private int? _isEnabled;
		private int? _isDel;
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
		[Column(Field = "AppCode", Type = "varchar", Length = 96, Scale = 0)]
		public string AppCode
		{
			get { return _appCode; }
			set
			{
				OnPropertyChanging("AppCode");
				_appCode = value;
				OnPropertyChanged("AppCode");
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
		[Column(Field = "RootId", Type = "int", Length = 10, Scale = 0)]
		public int? RootId
		{
			get { return _rootId; }
			set
			{
				OnPropertyChanging("RootId");
				_rootId = value;
				OnPropertyChanged("RootId");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Path", Type = "text", Length = 65535, Scale = 0)]
		public string Path
		{
			get { return _path; }
			set
			{
				OnPropertyChanging("Path");
				_path = value;
				OnPropertyChanged("Path");
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
		[Column(Field = "Code", Type = "varchar", Length = 96, Scale = 0)]
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
		[Column(Field = "Icon", Type = "text", Length = 65535, Scale = 0)]
		public string Icon
		{
			get { return _icon; }
			set
			{
				OnPropertyChanging("Icon");
				_icon = value;
				OnPropertyChanged("Icon");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Depth", Type = "int", Length = 10, Scale = 0)]
		public int? Depth
		{
			get { return _depth; }
			set
			{
				OnPropertyChanging("Depth");
				_depth = value;
				OnPropertyChanged("Depth");
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
		[Column(Field = "OrderBy", Type = "int", Length = 10, Scale = 0)]
		public int? OrderBy
		{
			get { return _orderBy; }
			set
			{
				OnPropertyChanging("OrderBy");
				_orderBy = value;
				OnPropertyChanged("OrderBy");
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
