//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Data.Objects.DataClasses;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using nHydrate.LocationService.EFDAL.Interfaces;

namespace nHydrate.LocationService.EFDAL.Interfaces.Entity
{
	/// <summary>
	/// This is the interface for the entity Zip
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "5.2.0")]
	public partial interface IZip
	{
		#region Properties

		/// <summary>
		/// The property that maps back to the database 'Zip.City' field
		/// </summary>
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DisplayName("City")]
		string City { get; set; }

		/// <summary>
		/// The property that maps back to the database 'Zip.Latitude' field
		/// </summary>
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DisplayName("Latitude")]
		double? Latitude { get; set; }

		/// <summary>
		/// The property that maps back to the database 'Zip.Longitude' field
		/// </summary>
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DisplayName("Longitude")]
		double? Longitude { get; set; }

		/// <summary>
		/// The property that maps back to the database 'Zip.Name' field
		/// </summary>
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DisplayName("Name")]
		string Name { get; set; }

		/// <summary>
		/// The property that maps back to the database 'Zip.Population' field
		/// </summary>
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DisplayName("Population")]
		int? Population { get; set; }

		/// <summary>
		/// The property that maps back to the database 'Zip.State' field
		/// </summary>
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DisplayName("State")]
		string State { get; set; }

		/// <summary>
		/// The property that maps back to the database 'Zip.ZipId' field
		/// </summary>
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DataAnnotations.Key()]
		[System.ComponentModel.ReadOnly(true)]
		[System.ComponentModel.DisplayName("ZipId")]
		int ZipId { get; set; }

		/// <summary>
		/// The audit field for the 'Created By' column.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		string CreatedBy { get; }

		/// <summary>
		/// The audit field for the 'Created Date' column.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		DateTime? CreatedDate { get; }

		/// <summary>
		/// The audit field for the 'Modified By' column.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		string ModifiedBy { get; }

		/// <summary>
		/// The audit field for the 'Modified Date' column.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		DateTime? ModifiedDate { get; }

		#endregion

		#region Navigation Properties

		#endregion

	}

}

#region Metadata Class

namespace nHydrate.LocationService.EFDAL.Interfaces.Entity.Metadata
{
	/// <summary>
	/// Metadata class for the 'Zip' entity
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "5.2.0")]
	public partial class ZipMetadata : nHydrate.LocationService.EFDAL.Interfaces.IMetadata
	{
		#region Properties

		/// <summary>
		/// Metadata information for the 'City' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'City' is required.")]
		[System.ComponentModel.DataAnnotations.StringLength(50, ErrorMessage = "The property 'City' has a maximum length of 50")]
		[System.ComponentModel.DataAnnotations.DisplayAttribute(Description = "", Name = "City", AutoGenerateField = true)]
		public object City;

		/// <summary>
		/// Metadata information for the 'Latitude' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.DisplayAttribute(Description = "", Name = "Latitude", AutoGenerateField = true)]
		public object Latitude;

		/// <summary>
		/// Metadata information for the 'Longitude' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.DisplayAttribute(Description = "", Name = "Longitude", AutoGenerateField = true)]
		public object Longitude;

		/// <summary>
		/// Metadata information for the 'Name' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'Name' is required.")]
		[System.ComponentModel.DataAnnotations.StringLength(10, ErrorMessage = "The property 'Name' has a maximum length of 10")]
		[System.ComponentModel.DataAnnotations.DisplayAttribute(Description = "", Name = "Name", AutoGenerateField = true)]
		public object Name;

		/// <summary>
		/// Metadata information for the 'Population' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.DisplayAttribute(Description = "", Name = "Population", AutoGenerateField = true)]
		public object Population;

		/// <summary>
		/// Metadata information for the 'State' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'State' is required.")]
		[System.ComponentModel.DataAnnotations.StringLength(50, ErrorMessage = "The property 'State' has a maximum length of 50")]
		[System.ComponentModel.DataAnnotations.DisplayAttribute(Description = "", Name = "State", AutoGenerateField = true)]
		public object State;

		/// <summary>
		/// Metadata information for the 'ZipId' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'ZipId' is required.")]
		[System.ComponentModel.DataAnnotations.Key()]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		[System.ComponentModel.ReadOnly(true)]
		[System.ComponentModel.DataAnnotations.DisplayAttribute(Description = "", Name = "ZipId", AutoGenerateField = true)]
		public object ZipId;

		/// <summary>
		/// Metadata information for the 'CreatedBy' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength(100, ErrorMessage = "The property 'CreatedBy' has a maximum length of 100")]
		[System.ComponentModel.ReadOnly(true)]
		public object CreatedBy;

		/// <summary>
		/// Metadata information for the 'CreatedDate' parameter
		/// </summary>
		[System.ComponentModel.ReadOnly(true)]
		public object CreatedDate;

		/// <summary>
		/// Metadata information for the 'ModifiedBy' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength(100, ErrorMessage = "The property 'ModifiedBy' has a maximum length of 100")]
		[System.ComponentModel.ReadOnly(true)]
		public object ModifiedBy;

		/// <summary>
		/// Metadata information for the 'ModifiedDate' parameter
		/// </summary>
		[System.ComponentModel.ReadOnly(true)]
		public object ModifiedDate;

		/// <summary>
		/// Metadata information for the 'TimeStamp' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Timestamp()]
		[System.ComponentModel.ReadOnly(true)]
		public object TimeStamp;

		#endregion

	}

}

#endregion
