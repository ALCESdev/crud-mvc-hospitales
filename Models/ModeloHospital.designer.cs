﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Hospitales.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hospital_MVC")]
	public partial class ModeloHospitalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertDOCTOR(DOCTOR instance);
    partial void UpdateDOCTOR(DOCTOR instance);
    partial void DeleteDOCTOR(DOCTOR instance);
    partial void InsertPLANTILLA(PLANTILLA instance);
    partial void UpdatePLANTILLA(PLANTILLA instance);
    partial void DeletePLANTILLA(PLANTILLA instance);
    partial void InsertENFERMO(ENFERMO instance);
    partial void UpdateENFERMO(ENFERMO instance);
    partial void DeleteENFERMO(ENFERMO instance);
    partial void InsertHOSPITAL(HOSPITAL instance);
    partial void UpdateHOSPITAL(HOSPITAL instance);
    partial void DeleteHOSPITAL(HOSPITAL instance);
    #endregion
		
		public ModeloHospitalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloHospitalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloHospitalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloHospitalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DOCTOR> DOCTOR
		{
			get
			{
				return this.GetTable<DOCTOR>();
			}
		}
		
		public System.Data.Linq.Table<PLANTILLA> PLANTILLA
		{
			get
			{
				return this.GetTable<PLANTILLA>();
			}
		}
		
		public System.Data.Linq.Table<ENFERMO> ENFERMO
		{
			get
			{
				return this.GetTable<ENFERMO>();
			}
		}
		
		public System.Data.Linq.Table<SALA> SALA
		{
			get
			{
				return this.GetTable<SALA>();
			}
		}
		
		public System.Data.Linq.Table<OCUPACION> OCUPACION
		{
			get
			{
				return this.GetTable<OCUPACION>();
			}
		}
		
		public System.Data.Linq.Table<HOSPITAL> HOSPITAL
		{
			get
			{
				return this.GetTable<HOSPITAL>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DOCTOR")]
	public partial class DOCTOR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HOSPITAL_COD;
		
		private string _DOCTOR_NO;
		
		private string _APELLIDO;
		
		private string _ESPECIALIDAD;
		
		private System.Nullable<int> _SALARIO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHOSPITAL_CODChanging(string value);
    partial void OnHOSPITAL_CODChanged();
    partial void OnDOCTOR_NOChanging(string value);
    partial void OnDOCTOR_NOChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnESPECIALIDADChanging(string value);
    partial void OnESPECIALIDADChanged();
    partial void OnSALARIOChanging(System.Nullable<int> value);
    partial void OnSALARIOChanged();
    #endregion
		
		public DOCTOR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="NVarChar(50)")]
		public string HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this.OnHOSPITAL_CODChanging(value);
					this.SendPropertyChanging();
					this._HOSPITAL_COD = value;
					this.SendPropertyChanged("HOSPITAL_COD");
					this.OnHOSPITAL_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOCTOR_NO", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DOCTOR_NO
		{
			get
			{
				return this._DOCTOR_NO;
			}
			set
			{
				if ((this._DOCTOR_NO != value))
				{
					this.OnDOCTOR_NOChanging(value);
					this.SendPropertyChanging();
					this._DOCTOR_NO = value;
					this.SendPropertyChanged("DOCTOR_NO");
					this.OnDOCTOR_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this.OnAPELLIDOChanging(value);
					this.SendPropertyChanging();
					this._APELLIDO = value;
					this.SendPropertyChanged("APELLIDO");
					this.OnAPELLIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESPECIALIDAD", DbType="NVarChar(50)")]
		public string ESPECIALIDAD
		{
			get
			{
				return this._ESPECIALIDAD;
			}
			set
			{
				if ((this._ESPECIALIDAD != value))
				{
					this.OnESPECIALIDADChanging(value);
					this.SendPropertyChanging();
					this._ESPECIALIDAD = value;
					this.SendPropertyChanged("ESPECIALIDAD");
					this.OnESPECIALIDADChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALARIO", DbType="Int")]
		public System.Nullable<int> SALARIO
		{
			get
			{
				return this._SALARIO;
			}
			set
			{
				if ((this._SALARIO != value))
				{
					this.OnSALARIOChanging(value);
					this.SendPropertyChanging();
					this._SALARIO = value;
					this.SendPropertyChanged("SALARIO");
					this.OnSALARIOChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PLANTILLA")]
	public partial class PLANTILLA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HOSPITAL_COD;
		
		private string _SALA_COD;
		
		private string _EMPLEADO_NO;
		
		private string _APELLIDO;
		
		private string _FUNCION;
		
		private string _T;
		
		private string _SALARIO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHOSPITAL_CODChanging(string value);
    partial void OnHOSPITAL_CODChanged();
    partial void OnSALA_CODChanging(string value);
    partial void OnSALA_CODChanged();
    partial void OnEMPLEADO_NOChanging(string value);
    partial void OnEMPLEADO_NOChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnFUNCIONChanging(string value);
    partial void OnFUNCIONChanged();
    partial void OnTChanging(string value);
    partial void OnTChanged();
    partial void OnSALARIOChanging(string value);
    partial void OnSALARIOChanged();
    #endregion
		
		public PLANTILLA()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="NVarChar(50)")]
		public string HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this.OnHOSPITAL_CODChanging(value);
					this.SendPropertyChanging();
					this._HOSPITAL_COD = value;
					this.SendPropertyChanged("HOSPITAL_COD");
					this.OnHOSPITAL_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALA_COD", DbType="NVarChar(50)")]
		public string SALA_COD
		{
			get
			{
				return this._SALA_COD;
			}
			set
			{
				if ((this._SALA_COD != value))
				{
					this.OnSALA_CODChanging(value);
					this.SendPropertyChanging();
					this._SALA_COD = value;
					this.SendPropertyChanged("SALA_COD");
					this.OnSALA_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMPLEADO_NO", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EMPLEADO_NO
		{
			get
			{
				return this._EMPLEADO_NO;
			}
			set
			{
				if ((this._EMPLEADO_NO != value))
				{
					this.OnEMPLEADO_NOChanging(value);
					this.SendPropertyChanging();
					this._EMPLEADO_NO = value;
					this.SendPropertyChanged("EMPLEADO_NO");
					this.OnEMPLEADO_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this.OnAPELLIDOChanging(value);
					this.SendPropertyChanging();
					this._APELLIDO = value;
					this.SendPropertyChanged("APELLIDO");
					this.OnAPELLIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FUNCION", DbType="NVarChar(50)")]
		public string FUNCION
		{
			get
			{
				return this._FUNCION;
			}
			set
			{
				if ((this._FUNCION != value))
				{
					this.OnFUNCIONChanging(value);
					this.SendPropertyChanging();
					this._FUNCION = value;
					this.SendPropertyChanged("FUNCION");
					this.OnFUNCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T", DbType="NVarChar(50)")]
		public string T
		{
			get
			{
				return this._T;
			}
			set
			{
				if ((this._T != value))
				{
					this.OnTChanging(value);
					this.SendPropertyChanging();
					this._T = value;
					this.SendPropertyChanged("T");
					this.OnTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALARIO", DbType="NVarChar(50)")]
		public string SALARIO
		{
			get
			{
				return this._SALARIO;
			}
			set
			{
				if ((this._SALARIO != value))
				{
					this.OnSALARIOChanging(value);
					this.SendPropertyChanging();
					this._SALARIO = value;
					this.SendPropertyChanged("SALARIO");
					this.OnSALARIOChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ENFERMO")]
	public partial class ENFERMO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _INSCRIPCION;
		
		private string _APELLIDO;
		
		private string _DIRECCION;
		
		private System.Nullable<System.DateTime> _FECHA_NAC;
		
		private string _S;
		
		private string _NSS;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnINSCRIPCIONChanging(string value);
    partial void OnINSCRIPCIONChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnDIRECCIONChanging(string value);
    partial void OnDIRECCIONChanged();
    partial void OnFECHA_NACChanging(System.Nullable<System.DateTime> value);
    partial void OnFECHA_NACChanged();
    partial void OnSChanging(string value);
    partial void OnSChanged();
    partial void OnNSSChanging(string value);
    partial void OnNSSChanged();
    #endregion
		
		public ENFERMO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INSCRIPCION", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string INSCRIPCION
		{
			get
			{
				return this._INSCRIPCION;
			}
			set
			{
				if ((this._INSCRIPCION != value))
				{
					this.OnINSCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._INSCRIPCION = value;
					this.SendPropertyChanged("INSCRIPCION");
					this.OnINSCRIPCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this.OnAPELLIDOChanging(value);
					this.SendPropertyChanging();
					this._APELLIDO = value;
					this.SendPropertyChanged("APELLIDO");
					this.OnAPELLIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIRECCION", DbType="NVarChar(50)")]
		public string DIRECCION
		{
			get
			{
				return this._DIRECCION;
			}
			set
			{
				if ((this._DIRECCION != value))
				{
					this.OnDIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._DIRECCION = value;
					this.SendPropertyChanged("DIRECCION");
					this.OnDIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_NAC", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA_NAC
		{
			get
			{
				return this._FECHA_NAC;
			}
			set
			{
				if ((this._FECHA_NAC != value))
				{
					this.OnFECHA_NACChanging(value);
					this.SendPropertyChanging();
					this._FECHA_NAC = value;
					this.SendPropertyChanged("FECHA_NAC");
					this.OnFECHA_NACChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S", DbType="NVarChar(50)")]
		public string S
		{
			get
			{
				return this._S;
			}
			set
			{
				if ((this._S != value))
				{
					this.OnSChanging(value);
					this.SendPropertyChanging();
					this._S = value;
					this.SendPropertyChanged("S");
					this.OnSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSS", DbType="NVarChar(50)")]
		public string NSS
		{
			get
			{
				return this._NSS;
			}
			set
			{
				if ((this._NSS != value))
				{
					this.OnNSSChanging(value);
					this.SendPropertyChanging();
					this._NSS = value;
					this.SendPropertyChanged("NSS");
					this.OnNSSChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SALA")]
	public partial class SALA
	{
		
		private string _HOSPITAL_COD;
		
		private string _SALA_COD;
		
		private string _NOMBRE;
		
		private string _NUM_CAMA;
		
		public SALA()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="NVarChar(50)")]
		public string HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this._HOSPITAL_COD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALA_COD", DbType="NVarChar(50)")]
		public string SALA_COD
		{
			get
			{
				return this._SALA_COD;
			}
			set
			{
				if ((this._SALA_COD != value))
				{
					this._SALA_COD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="NVarChar(50)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUM_CAMA", DbType="NVarChar(50)")]
		public string NUM_CAMA
		{
			get
			{
				return this._NUM_CAMA;
			}
			set
			{
				if ((this._NUM_CAMA != value))
				{
					this._NUM_CAMA = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OCUPACION")]
	public partial class OCUPACION
	{
		
		private System.Nullable<int> _INSCRIPCION;
		
		private System.Nullable<int> _HOSPITAL_COD;
		
		private System.Nullable<int> _SALA_COD;
		
		private System.Nullable<int> _CAMA;
		
		public OCUPACION()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INSCRIPCION", DbType="Int")]
		public System.Nullable<int> INSCRIPCION
		{
			get
			{
				return this._INSCRIPCION;
			}
			set
			{
				if ((this._INSCRIPCION != value))
				{
					this._INSCRIPCION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="Int")]
		public System.Nullable<int> HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this._HOSPITAL_COD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALA_COD", DbType="Int")]
		public System.Nullable<int> SALA_COD
		{
			get
			{
				return this._SALA_COD;
			}
			set
			{
				if ((this._SALA_COD != value))
				{
					this._SALA_COD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAMA", DbType="Int")]
		public System.Nullable<int> CAMA
		{
			get
			{
				return this._CAMA;
			}
			set
			{
				if ((this._CAMA != value))
				{
					this._CAMA = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOSPITAL")]
	public partial class HOSPITAL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HOSPITAL_COD;
		
		private string _NOMBRE;
		
		private string _DIRECCION;
		
		private string _TELEFONO;
		
		private string _NUM_CAMA;
		
		private string _LINK_IMAGEN;
		
		private string _DESCRIPCION;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHOSPITAL_CODChanging(string value);
    partial void OnHOSPITAL_CODChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    partial void OnDIRECCIONChanging(string value);
    partial void OnDIRECCIONChanged();
    partial void OnTELEFONOChanging(string value);
    partial void OnTELEFONOChanged();
    partial void OnNUM_CAMAChanging(string value);
    partial void OnNUM_CAMAChanged();
    partial void OnLINK_IMAGENChanging(string value);
    partial void OnLINK_IMAGENChanged();
    partial void OnDESCRIPCIONChanging(string value);
    partial void OnDESCRIPCIONChanged();
    #endregion
		
		public HOSPITAL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this.OnHOSPITAL_CODChanging(value);
					this.SendPropertyChanging();
					this._HOSPITAL_COD = value;
					this.SendPropertyChanged("HOSPITAL_COD");
					this.OnHOSPITAL_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="NVarChar(50)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIRECCION", DbType="NVarChar(50)")]
		public string DIRECCION
		{
			get
			{
				return this._DIRECCION;
			}
			set
			{
				if ((this._DIRECCION != value))
				{
					this.OnDIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._DIRECCION = value;
					this.SendPropertyChanged("DIRECCION");
					this.OnDIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TELEFONO", DbType="NVarChar(50)")]
		public string TELEFONO
		{
			get
			{
				return this._TELEFONO;
			}
			set
			{
				if ((this._TELEFONO != value))
				{
					this.OnTELEFONOChanging(value);
					this.SendPropertyChanging();
					this._TELEFONO = value;
					this.SendPropertyChanged("TELEFONO");
					this.OnTELEFONOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUM_CAMA", DbType="NVarChar(50)")]
		public string NUM_CAMA
		{
			get
			{
				return this._NUM_CAMA;
			}
			set
			{
				if ((this._NUM_CAMA != value))
				{
					this.OnNUM_CAMAChanging(value);
					this.SendPropertyChanging();
					this._NUM_CAMA = value;
					this.SendPropertyChanged("NUM_CAMA");
					this.OnNUM_CAMAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LINK_IMAGEN", DbType="NVarChar(MAX)")]
		public string LINK_IMAGEN
		{
			get
			{
				return this._LINK_IMAGEN;
			}
			set
			{
				if ((this._LINK_IMAGEN != value))
				{
					this.OnLINK_IMAGENChanging(value);
					this.SendPropertyChanging();
					this._LINK_IMAGEN = value;
					this.SendPropertyChanged("LINK_IMAGEN");
					this.OnLINK_IMAGENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPCION", DbType="NVarChar(MAX)")]
		public string DESCRIPCION
		{
			get
			{
				return this._DESCRIPCION;
			}
			set
			{
				if ((this._DESCRIPCION != value))
				{
					this.OnDESCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPCION = value;
					this.SendPropertyChanged("DESCRIPCION");
					this.OnDESCRIPCIONChanged();
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
