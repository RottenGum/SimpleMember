using System;

namespace NPiculet.Logic.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShopLogs : ModelBase
	{
		public override string TableName { get { return "shop_logs"; } }
		public override string PrimeKey { get { return "Id"; } }

		#region 数据项（私有属性）

		private int _id;
		private string _type;
		private int? _level;
		private string _message;
		private Double _value;
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
		[Column(Field = "Level", Type = "int", Length = 10, Scale = 0)]
		public int? Level
		{
			get { return _level; }
			set
			{
				OnPropertyChanging("Level");
				_level = value;
				OnPropertyChanged("Level");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Message", Type = "text", Length = 65535, Scale = 0)]
		public string Message
		{
			get { return _message; }
			set
			{
				OnPropertyChanging("Message");
				_message = value;
				OnPropertyChanged("Message");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Column(Field = "Value", Type = "double", Length = 22, Scale = 0)]
		public Double Value
		{
			get { return _value; }
			set
			{
				OnPropertyChanging("Value");
				_value = value;
				OnPropertyChanged("Value");
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
