﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeCom")]
public partial class EmployeeComDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertprofile(profile instance);
  partial void Updateprofile(profile instance);
  partial void Deleteprofile(profile instance);
  partial void Insertuser_location(user_location instance);
  partial void Updateuser_location(user_location instance);
  partial void Deleteuser_location(user_location instance);
  partial void Insertusertbl(usertbl instance);
  partial void Updateusertbl(usertbl instance);
  partial void Deleteusertbl(usertbl instance);
  partial void Insertmessage(message instance);
  partial void Updatemessage(message instance);
  partial void Deletemessage(message instance);
  #endregion
	
	public EmployeeComDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EmployeeComConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeComDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeComDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeComDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeComDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<profile> profiles
	{
		get
		{
			return this.GetTable<profile>();
		}
	}
	
	public System.Data.Linq.Table<user_location> user_locations
	{
		get
		{
			return this.GetTable<user_location>();
		}
	}
	
	public System.Data.Linq.Table<usertbl> usertbls
	{
		get
		{
			return this.GetTable<usertbl>();
		}
	}
	
	public System.Data.Linq.Table<message> messages
	{
		get
		{
			return this.GetTable<message>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.profile")]
public partial class profile : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _UserName;
	
	private string _password;
	
	private int _user_id;
	
	private EntitySet<message> _messages;
	
	private EntitySet<message> _messages1;
	
	private EntityRef<usertbl> _usertbl;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    #endregion
	
	public profile()
	{
		this._messages = new EntitySet<message>(new Action<message>(this.attach_messages), new Action<message>(this.detach_messages));
		this._messages1 = new EntitySet<message>(new Action<message>(this.attach_messages1), new Action<message>(this.detach_messages1));
		this._usertbl = default(EntityRef<usertbl>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
	public int user_id
	{
		get
		{
			return this._user_id;
		}
		set
		{
			if ((this._user_id != value))
			{
				if (this._usertbl.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onuser_idChanging(value);
				this.SendPropertyChanging();
				this._user_id = value;
				this.SendPropertyChanged("user_id");
				this.Onuser_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="profile_message", Storage="_messages", ThisKey="Id", OtherKey="sender_ID")]
	public EntitySet<message> messages
	{
		get
		{
			return this._messages;
		}
		set
		{
			this._messages.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="profile_message1", Storage="_messages1", ThisKey="Id", OtherKey="receiver_ID")]
	public EntitySet<message> messages1
	{
		get
		{
			return this._messages1;
		}
		set
		{
			this._messages1.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usertbl_profile", Storage="_usertbl", ThisKey="user_id", OtherKey="Id", IsForeignKey=true)]
	public usertbl usertbl
	{
		get
		{
			return this._usertbl.Entity;
		}
		set
		{
			usertbl previousValue = this._usertbl.Entity;
			if (((previousValue != value) 
						|| (this._usertbl.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._usertbl.Entity = null;
					previousValue.profiles.Remove(this);
				}
				this._usertbl.Entity = value;
				if ((value != null))
				{
					value.profiles.Add(this);
					this._user_id = value.Id;
				}
				else
				{
					this._user_id = default(int);
				}
				this.SendPropertyChanged("usertbl");
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
	
	private void attach_messages(message entity)
	{
		this.SendPropertyChanging();
		entity.profile = this;
	}
	
	private void detach_messages(message entity)
	{
		this.SendPropertyChanging();
		entity.profile = null;
	}
	
	private void attach_messages1(message entity)
	{
		this.SendPropertyChanging();
		entity.profile1 = this;
	}
	
	private void detach_messages1(message entity)
	{
		this.SendPropertyChanging();
		entity.profile1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_location")]
public partial class user_location : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _street_addr;
	
	private string _city;
	
	private string _province_state;
	
	private string _country;
	
	private string _postal_zipCode;
	
	private int _user_id;
	
	private EntityRef<usertbl> _usertbl;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onstreet_addrChanging(string value);
    partial void Onstreet_addrChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void Onprovince_stateChanging(string value);
    partial void Onprovince_stateChanged();
    partial void OncountryChanging(string value);
    partial void OncountryChanged();
    partial void Onpostal_zipCodeChanging(string value);
    partial void Onpostal_zipCodeChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    #endregion
	
	public user_location()
	{
		this._usertbl = default(EntityRef<usertbl>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_street_addr", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string street_addr
	{
		get
		{
			return this._street_addr;
		}
		set
		{
			if ((this._street_addr != value))
			{
				this.Onstreet_addrChanging(value);
				this.SendPropertyChanging();
				this._street_addr = value;
				this.SendPropertyChanged("street_addr");
				this.Onstreet_addrChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string city
	{
		get
		{
			return this._city;
		}
		set
		{
			if ((this._city != value))
			{
				this.OncityChanging(value);
				this.SendPropertyChanging();
				this._city = value;
				this.SendPropertyChanged("city");
				this.OncityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_province_state", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string province_state
	{
		get
		{
			return this._province_state;
		}
		set
		{
			if ((this._province_state != value))
			{
				this.Onprovince_stateChanging(value);
				this.SendPropertyChanging();
				this._province_state = value;
				this.SendPropertyChanged("province_state");
				this.Onprovince_stateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_country", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string country
	{
		get
		{
			return this._country;
		}
		set
		{
			if ((this._country != value))
			{
				this.OncountryChanging(value);
				this.SendPropertyChanging();
				this._country = value;
				this.SendPropertyChanged("country");
				this.OncountryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_postal_zipCode", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string postal_zipCode
	{
		get
		{
			return this._postal_zipCode;
		}
		set
		{
			if ((this._postal_zipCode != value))
			{
				this.Onpostal_zipCodeChanging(value);
				this.SendPropertyChanging();
				this._postal_zipCode = value;
				this.SendPropertyChanged("postal_zipCode");
				this.Onpostal_zipCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
	public int user_id
	{
		get
		{
			return this._user_id;
		}
		set
		{
			if ((this._user_id != value))
			{
				if (this._usertbl.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onuser_idChanging(value);
				this.SendPropertyChanging();
				this._user_id = value;
				this.SendPropertyChanged("user_id");
				this.Onuser_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usertbl_user_location", Storage="_usertbl", ThisKey="user_id", OtherKey="Id", IsForeignKey=true)]
	public usertbl usertbl
	{
		get
		{
			return this._usertbl.Entity;
		}
		set
		{
			usertbl previousValue = this._usertbl.Entity;
			if (((previousValue != value) 
						|| (this._usertbl.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._usertbl.Entity = null;
					previousValue.user_locations.Remove(this);
				}
				this._usertbl.Entity = value;
				if ((value != null))
				{
					value.user_locations.Add(this);
					this._user_id = value.Id;
				}
				else
				{
					this._user_id = default(int);
				}
				this.SendPropertyChanged("usertbl");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usertbl")]
public partial class usertbl : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _firstName;
	
	private string _lastName;
	
	private string _gender;
	
	private string _date_birth;
	
	private EntitySet<profile> _profiles;
	
	private EntitySet<user_location> _user_locations;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void Ondate_birthChanging(string value);
    partial void Ondate_birthChanged();
    #endregion
	
	public usertbl()
	{
		this._profiles = new EntitySet<profile>(new Action<profile>(this.attach_profiles), new Action<profile>(this.detach_profiles));
		this._user_locations = new EntitySet<user_location>(new Action<user_location>(this.attach_user_locations), new Action<user_location>(this.detach_user_locations));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string firstName
	{
		get
		{
			return this._firstName;
		}
		set
		{
			if ((this._firstName != value))
			{
				this.OnfirstNameChanging(value);
				this.SendPropertyChanging();
				this._firstName = value;
				this.SendPropertyChanged("firstName");
				this.OnfirstNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string lastName
	{
		get
		{
			return this._lastName;
		}
		set
		{
			if ((this._lastName != value))
			{
				this.OnlastNameChanging(value);
				this.SendPropertyChanging();
				this._lastName = value;
				this.SendPropertyChanged("lastName");
				this.OnlastNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NChar(10) NOT NULL", CanBeNull=false)]
	public string gender
	{
		get
		{
			return this._gender;
		}
		set
		{
			if ((this._gender != value))
			{
				this.OngenderChanging(value);
				this.SendPropertyChanging();
				this._gender = value;
				this.SendPropertyChanged("gender");
				this.OngenderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_birth", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string date_birth
	{
		get
		{
			return this._date_birth;
		}
		set
		{
			if ((this._date_birth != value))
			{
				this.Ondate_birthChanging(value);
				this.SendPropertyChanging();
				this._date_birth = value;
				this.SendPropertyChanged("date_birth");
				this.Ondate_birthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usertbl_profile", Storage="_profiles", ThisKey="Id", OtherKey="user_id")]
	public EntitySet<profile> profiles
	{
		get
		{
			return this._profiles;
		}
		set
		{
			this._profiles.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usertbl_user_location", Storage="_user_locations", ThisKey="Id", OtherKey="user_id")]
	public EntitySet<user_location> user_locations
	{
		get
		{
			return this._user_locations;
		}
		set
		{
			this._user_locations.Assign(value);
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
	
	private void attach_profiles(profile entity)
	{
		this.SendPropertyChanging();
		entity.usertbl = this;
	}
	
	private void detach_profiles(profile entity)
	{
		this.SendPropertyChanging();
		entity.usertbl = null;
	}
	
	private void attach_user_locations(user_location entity)
	{
		this.SendPropertyChanging();
		entity.usertbl = this;
	}
	
	private void detach_user_locations(user_location entity)
	{
		this.SendPropertyChanging();
		entity.usertbl = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.message")]
public partial class message : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _messageText;
	
	private System.DateTime _time;
	
	private int _sender_ID;
	
	private int _receiver_ID;
	
	private System.Nullable<int> _seen;
	
	private EntityRef<profile> _profile;
	
	private EntityRef<profile> _profile1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnmessageTextChanging(string value);
    partial void OnmessageTextChanged();
    partial void OntimeChanging(System.DateTime value);
    partial void OntimeChanged();
    partial void Onsender_IDChanging(int value);
    partial void Onsender_IDChanged();
    partial void Onreceiver_IDChanging(int value);
    partial void Onreceiver_IDChanged();
    partial void OnseenChanging(System.Nullable<int> value);
    partial void OnseenChanged();
    #endregion
	
	public message()
	{
		this._profile = default(EntityRef<profile>);
		this._profile1 = default(EntityRef<profile>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messageText", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
	public string messageText
	{
		get
		{
			return this._messageText;
		}
		set
		{
			if ((this._messageText != value))
			{
				this.OnmessageTextChanging(value);
				this.SendPropertyChanging();
				this._messageText = value;
				this.SendPropertyChanged("messageText");
				this.OnmessageTextChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime NOT NULL")]
	public System.DateTime time
	{
		get
		{
			return this._time;
		}
		set
		{
			if ((this._time != value))
			{
				this.OntimeChanging(value);
				this.SendPropertyChanging();
				this._time = value;
				this.SendPropertyChanged("time");
				this.OntimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sender_ID", DbType="Int NOT NULL")]
	public int sender_ID
	{
		get
		{
			return this._sender_ID;
		}
		set
		{
			if ((this._sender_ID != value))
			{
				if (this._profile.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onsender_IDChanging(value);
				this.SendPropertyChanging();
				this._sender_ID = value;
				this.SendPropertyChanged("sender_ID");
				this.Onsender_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_receiver_ID", DbType="Int NOT NULL")]
	public int receiver_ID
	{
		get
		{
			return this._receiver_ID;
		}
		set
		{
			if ((this._receiver_ID != value))
			{
				if (this._profile1.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onreceiver_IDChanging(value);
				this.SendPropertyChanging();
				this._receiver_ID = value;
				this.SendPropertyChanged("receiver_ID");
				this.Onreceiver_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seen", DbType="Int")]
	public System.Nullable<int> seen
	{
		get
		{
			return this._seen;
		}
		set
		{
			if ((this._seen != value))
			{
				this.OnseenChanging(value);
				this.SendPropertyChanging();
				this._seen = value;
				this.SendPropertyChanged("seen");
				this.OnseenChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="profile_message", Storage="_profile", ThisKey="sender_ID", OtherKey="Id", IsForeignKey=true)]
	public profile profile
	{
		get
		{
			return this._profile.Entity;
		}
		set
		{
			profile previousValue = this._profile.Entity;
			if (((previousValue != value) 
						|| (this._profile.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._profile.Entity = null;
					previousValue.messages.Remove(this);
				}
				this._profile.Entity = value;
				if ((value != null))
				{
					value.messages.Add(this);
					this._sender_ID = value.Id;
				}
				else
				{
					this._sender_ID = default(int);
				}
				this.SendPropertyChanged("profile");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="profile_message1", Storage="_profile1", ThisKey="receiver_ID", OtherKey="Id", IsForeignKey=true)]
	public profile profile1
	{
		get
		{
			return this._profile1.Entity;
		}
		set
		{
			profile previousValue = this._profile1.Entity;
			if (((previousValue != value) 
						|| (this._profile1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._profile1.Entity = null;
					previousValue.messages1.Remove(this);
				}
				this._profile1.Entity = value;
				if ((value != null))
				{
					value.messages1.Add(this);
					this._receiver_ID = value.Id;
				}
				else
				{
					this._receiver_ID = default(int);
				}
				this.SendPropertyChanged("profile1");
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
#pragma warning restore 1591
