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
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Gravitybox.LocationService.EFDAL
{
	#region ContextStartup

	/// <summary>
	/// This object holds the modifer information for audits on an ObjectContext
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class ContextStartup : ICloneable
	{
		protected internal string DebugInfo { get; set; }
		protected internal bool DefaultTimeout { get; private set; }

		/// <summary>
		/// Creates a new instance of the ContextStartup object
		/// </summary>
		public ContextStartup(string modifier)
		{
			this.CommandTimeout = 30;
			this.Modifer = modifier;
			this.AllowLazyLoading = true;
			this.DefaultTimeout = true;
		}

		/// <summary>
		/// Creates a new instance of the ContextStartup object
		/// </summary>
		public ContextStartup(string modifier, bool allowLazyLoading) :
			this(modifier)
		{
			this.AllowLazyLoading = allowLazyLoading;
			this.DefaultTimeout = true;
		}

		/// <summary>
		/// Creates a new instance of the ContextStartup object
		/// </summary>
		public ContextStartup(string modifier, bool allowLazyLoading, int commandTimeout) :
			this(modifier, allowLazyLoading)
		{
			this.CommandTimeout = commandTimeout;
			this.DefaultTimeout = false;
		}

		/// <summary>
		/// The modifier string used for auditing
		/// </summary>
		public virtual string Modifer { get; protected internal set; }

		/// <summary>
		/// Determines if relationships can be walked via 'Lazy Loading'
		/// </summary>
		public virtual bool AllowLazyLoading { get; protected internal set; }

		/// <summary>
		/// Determines the database timeout value in seconds
		/// </summary>
		public virtual int CommandTimeout { get; protected internal set; }

		/// <summary />
		public object Clone()
		{
			return (ContextStartup)this.MemberwiseClone();
		}

	}

	#endregion

}
