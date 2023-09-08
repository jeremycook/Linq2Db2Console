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
	[Table("Territories")]
	public class Territory
	{
		[Column("TerritoryID"         , CanBeNull = false, IsPrimaryKey = true)] public string TerritoryId          { get; set; } = null!; // nvarchar(20)
		[Column("TerritoryDescription", CanBeNull = false                     )] public string TerritoryDescription { get; set; } = null!; // nchar(50)
		[Column("RegionID"                                                    )] public int    RegionId             { get; set; } // int

		#region Associations
		/// <summary>
		/// FK_EmployeeTerritories_Territories backreference
		/// </summary>
		[Association(ThisKey = nameof(TerritoryId), OtherKey = nameof(EmployeeTerritory.TerritoryId))]
		public IEnumerable<EmployeeTerritory> EmployeeTerritories { get; set; } = null!;

		/// <summary>
		/// FK_Territories_Region
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(RegionId), OtherKey = nameof(DataModel.Region.RegionId))]
		public Region Region { get; set; } = null!;
		#endregion
	}
}
