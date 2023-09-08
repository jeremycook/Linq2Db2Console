// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace DataModel
{
	[Table("Region")]
	public class Region
	{
		[Column("RegionID"         , IsPrimaryKey = true )] public int    RegionId          { get; set; } // int
		[Column("RegionDescription", CanBeNull    = false)] public string RegionDescription { get; set; } = null!; // nchar(50)

		#region Associations
		/// <summary>
		/// FK_Territories_Region backreference
		/// </summary>
		[Association(ThisKey = nameof(RegionId), OtherKey = nameof(Territory.RegionId))]
		public IEnumerable<Territory> Territories { get; set; } = null!;
		#endregion
	}
}
