// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace DataModel
{
	[Table("Products by Category", IsView = true)]
	public class ProductsByCategory
	{
		[Column("CategoryName"   , CanBeNull = false)] public string  CategoryName    { get; set; } = null!; // nvarchar(15)
		[Column("ProductName"    , CanBeNull = false)] public string  ProductName     { get; set; } = null!; // nvarchar(40)
		[Column("QuantityPerUnit"                   )] public string? QuantityPerUnit { get; set; } // nvarchar(20)
		[Column("UnitsInStock"                      )] public short?  UnitsInStock    { get; set; } // smallint
		[Column("Discontinued"                      )] public bool    Discontinued    { get; set; } // bit
	}
}
