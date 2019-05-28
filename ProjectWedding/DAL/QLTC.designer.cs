﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyTiecCuoi")]
	public partial class QLTCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDATTIEC(DATTIEC instance);
    partial void UpdateDATTIEC(DATTIEC instance);
    partial void DeleteDATTIEC(DATTIEC instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertMenu(Menu instance);
    partial void UpdateMenu(Menu instance);
    partial void DeleteMenu(Menu instance);
    partial void InsertQuiDinh(QuiDinh instance);
    partial void UpdateQuiDinh(QuiDinh instance);
    partial void DeleteQuiDinh(QuiDinh instance);
    partial void InsertSANH(SANH instance);
    partial void UpdateSANH(SANH instance);
    partial void DeleteSANH(SANH instance);
    #endregion
		
		public QLTCDataContext() : 
				base(global::DAL.Properties.Settings.Default.QuanLyTiecCuoiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLTCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DATTIEC> DATTIECs
		{
			get
			{
				return this.GetTable<DATTIEC>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<Menu> Menus
		{
			get
			{
				return this.GetTable<Menu>();
			}
		}
		
		public System.Data.Linq.Table<QuiDinh> QuiDinhs
		{
			get
			{
				return this.GetTable<QuiDinh>();
			}
		}
		
		public System.Data.Linq.Table<SANH> SANHs
		{
			get
			{
				return this.GetTable<SANH>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DATTIEC")]
	public partial class DATTIEC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDT;
		
		private System.Nullable<System.DateTime> _NgayDT;
		
		private System.Nullable<int> _Ca;
		
		private System.Nullable<int> _TienDC;
		
		private System.Nullable<int> _SLBan;
		
		private System.Nullable<int> _MaSanh;
		
		private System.Nullable<int> _SoBanDuTru;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDTChanging(int value);
    partial void OnMaDTChanged();
    partial void OnNgayDTChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDTChanged();
    partial void OnCaChanging(System.Nullable<int> value);
    partial void OnCaChanged();
    partial void OnTienDCChanging(System.Nullable<int> value);
    partial void OnTienDCChanged();
    partial void OnSLBanChanging(System.Nullable<int> value);
    partial void OnSLBanChanged();
    partial void OnMaSanhChanging(System.Nullable<int> value);
    partial void OnMaSanhChanged();
    partial void OnSoBanDuTruChanging(System.Nullable<int> value);
    partial void OnSoBanDuTruChanged();
    #endregion
		
		public DATTIEC()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDT
		{
			get
			{
				return this._MaDT;
			}
			set
			{
				if ((this._MaDT != value))
				{
					this.OnMaDTChanging(value);
					this.SendPropertyChanging();
					this._MaDT = value;
					this.SendPropertyChanged("MaDT");
					this.OnMaDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDT", DbType="DateTime2")]
		public System.Nullable<System.DateTime> NgayDT
		{
			get
			{
				return this._NgayDT;
			}
			set
			{
				if ((this._NgayDT != value))
				{
					this.OnNgayDTChanging(value);
					this.SendPropertyChanging();
					this._NgayDT = value;
					this.SendPropertyChanged("NgayDT");
					this.OnNgayDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ca", DbType="Int")]
		public System.Nullable<int> Ca
		{
			get
			{
				return this._Ca;
			}
			set
			{
				if ((this._Ca != value))
				{
					this.OnCaChanging(value);
					this.SendPropertyChanging();
					this._Ca = value;
					this.SendPropertyChanged("Ca");
					this.OnCaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TienDC", DbType="Int")]
		public System.Nullable<int> TienDC
		{
			get
			{
				return this._TienDC;
			}
			set
			{
				if ((this._TienDC != value))
				{
					this.OnTienDCChanging(value);
					this.SendPropertyChanging();
					this._TienDC = value;
					this.SendPropertyChanged("TienDC");
					this.OnTienDCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLBan", DbType="Int")]
		public System.Nullable<int> SLBan
		{
			get
			{
				return this._SLBan;
			}
			set
			{
				if ((this._SLBan != value))
				{
					this.OnSLBanChanging(value);
					this.SendPropertyChanging();
					this._SLBan = value;
					this.SendPropertyChanged("SLBan");
					this.OnSLBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanh", DbType="Int")]
		public System.Nullable<int> MaSanh
		{
			get
			{
				return this._MaSanh;
			}
			set
			{
				if ((this._MaSanh != value))
				{
					this.OnMaSanhChanging(value);
					this.SendPropertyChanging();
					this._MaSanh = value;
					this.SendPropertyChanged("MaSanh");
					this.OnMaSanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoBanDuTru", DbType="Int")]
		public System.Nullable<int> SoBanDuTru
		{
			get
			{
				return this._SoBanDuTru;
			}
			set
			{
				if ((this._SoBanDuTru != value))
				{
					this.OnSoBanDuTruChanging(value);
					this.SendPropertyChanging();
					this._SoBanDuTru = value;
					this.SendPropertyChanged("SoBanDuTru");
					this.OnSoBanDuTruChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private System.Nullable<int> _MaKH;
		
		private System.Nullable<System.DateTime> _NgayThanhToan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    partial void OnNgayThanhToanChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayThanhToanChanged();
    #endregion
		
		public HOADON()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayThanhToan", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayThanhToan
		{
			get
			{
				return this._NgayThanhToan;
			}
			set
			{
				if ((this._NgayThanhToan != value))
				{
					this.OnNgayThanhToanChanging(value);
					this.SendPropertyChanging();
					this._NgayThanhToan = value;
					this.SendPropertyChanged("NgayThanhToan");
					this.OnNgayThanhToanChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenCR;
		
		private string _TenCD;
		
		private System.Nullable<int> _SoDienThoai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenCRChanging(string value);
    partial void OnTenCRChanged();
    partial void OnTenCDChanging(string value);
    partial void OnTenCDChanged();
    partial void OnSoDienThoaiChanging(System.Nullable<int> value);
    partial void OnSoDienThoaiChanged();
    #endregion
		
		public KHACHHANG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenCR", DbType="VarChar(100)")]
		public string TenCR
		{
			get
			{
				return this._TenCR;
			}
			set
			{
				if ((this._TenCR != value))
				{
					this.OnTenCRChanging(value);
					this.SendPropertyChanging();
					this._TenCR = value;
					this.SendPropertyChanged("TenCR");
					this.OnTenCRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenCD", DbType="VarChar(100)")]
		public string TenCD
		{
			get
			{
				return this._TenCD;
			}
			set
			{
				if ((this._TenCD != value))
				{
					this.OnTenCDChanging(value);
					this.SendPropertyChanging();
					this._TenCD = value;
					this.SendPropertyChanged("TenCD");
					this.OnTenCDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="Int")]
		public System.Nullable<int> SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Menu")]
	public partial class Menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaMenu;
		
		private string _Ten;
		
		private System.Nullable<int> _DonGia;
		
		private System.Nullable<int> _MaHD;
		
		private string _GhiChu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMenuChanging(int value);
    partial void OnMaMenuChanged();
    partial void OnTenChanging(string value);
    partial void OnTenChanged();
    partial void OnDonGiaChanging(System.Nullable<int> value);
    partial void OnDonGiaChanged();
    partial void OnMaHDChanging(System.Nullable<int> value);
    partial void OnMaHDChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public Menu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMenu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaMenu
		{
			get
			{
				return this._MaMenu;
			}
			set
			{
				if ((this._MaMenu != value))
				{
					this.OnMaMenuChanging(value);
					this.SendPropertyChanging();
					this._MaMenu = value;
					this.SendPropertyChanged("MaMenu");
					this.OnMaMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="VarChar(100)")]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this.OnTenChanging(value);
					this.SendPropertyChanging();
					this._Ten = value;
					this.SendPropertyChanged("Ten");
					this.OnTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Int")]
		public System.Nullable<int> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Int")]
		public System.Nullable<int> MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="VarChar(100)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuiDinh")]
	public partial class QuiDinh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaQD;
		
		private string _TenQD;
		
		private string _Phat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaQDChanging(int value);
    partial void OnMaQDChanged();
    partial void OnTenQDChanging(string value);
    partial void OnTenQDChanged();
    partial void OnPhatChanging(string value);
    partial void OnPhatChanged();
    #endregion
		
		public QuiDinh()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaQD
		{
			get
			{
				return this._MaQD;
			}
			set
			{
				if ((this._MaQD != value))
				{
					this.OnMaQDChanging(value);
					this.SendPropertyChanging();
					this._MaQD = value;
					this.SendPropertyChanged("MaQD");
					this.OnMaQDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenQD", DbType="VarChar(100)")]
		public string TenQD
		{
			get
			{
				return this._TenQD;
			}
			set
			{
				if ((this._TenQD != value))
				{
					this.OnTenQDChanging(value);
					this.SendPropertyChanging();
					this._TenQD = value;
					this.SendPropertyChanged("TenQD");
					this.OnTenQDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phat", DbType="VarChar(100)")]
		public string Phat
		{
			get
			{
				return this._Phat;
			}
			set
			{
				if ((this._Phat != value))
				{
					this.OnPhatChanging(value);
					this.SendPropertyChanging();
					this._Phat = value;
					this.SendPropertyChanged("Phat");
					this.OnPhatChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANH")]
	public partial class SANH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSanh;
		
		private string _TenSanh;
		
		private System.Nullable<int> _LoaiSanh;
		
		private System.Nullable<int> _SoLuongMax;
		
		private System.Nullable<int> _DonGiaMin;
		
		private string _GhiChu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSanhChanging(int value);
    partial void OnMaSanhChanged();
    partial void OnTenSanhChanging(string value);
    partial void OnTenSanhChanged();
    partial void OnLoaiSanhChanging(System.Nullable<int> value);
    partial void OnLoaiSanhChanged();
    partial void OnSoLuongMaxChanging(System.Nullable<int> value);
    partial void OnSoLuongMaxChanged();
    partial void OnDonGiaMinChanging(System.Nullable<int> value);
    partial void OnDonGiaMinChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public SANH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSanh
		{
			get
			{
				return this._MaSanh;
			}
			set
			{
				if ((this._MaSanh != value))
				{
					this.OnMaSanhChanging(value);
					this.SendPropertyChanging();
					this._MaSanh = value;
					this.SendPropertyChanged("MaSanh");
					this.OnMaSanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanh", DbType="VarChar(100)")]
		public string TenSanh
		{
			get
			{
				return this._TenSanh;
			}
			set
			{
				if ((this._TenSanh != value))
				{
					this.OnTenSanhChanging(value);
					this.SendPropertyChanging();
					this._TenSanh = value;
					this.SendPropertyChanged("TenSanh");
					this.OnTenSanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiSanh", DbType="Int")]
		public System.Nullable<int> LoaiSanh
		{
			get
			{
				return this._LoaiSanh;
			}
			set
			{
				if ((this._LoaiSanh != value))
				{
					this.OnLoaiSanhChanging(value);
					this.SendPropertyChanging();
					this._LoaiSanh = value;
					this.SendPropertyChanged("LoaiSanh");
					this.OnLoaiSanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongMax", DbType="Int")]
		public System.Nullable<int> SoLuongMax
		{
			get
			{
				return this._SoLuongMax;
			}
			set
			{
				if ((this._SoLuongMax != value))
				{
					this.OnSoLuongMaxChanging(value);
					this.SendPropertyChanging();
					this._SoLuongMax = value;
					this.SendPropertyChanged("SoLuongMax");
					this.OnSoLuongMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaMin", DbType="Int")]
		public System.Nullable<int> DonGiaMin
		{
			get
			{
				return this._DonGiaMin;
			}
			set
			{
				if ((this._DonGiaMin != value))
				{
					this.OnDonGiaMinChanging(value);
					this.SendPropertyChanging();
					this._DonGiaMin = value;
					this.SendPropertyChanged("DonGiaMin");
					this.OnDonGiaMinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="VarChar(100)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
