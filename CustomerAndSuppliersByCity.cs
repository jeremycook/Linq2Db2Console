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
	[Table("Customer and Suppliers by City", IsView = true)]
	public class CustomerAndSuppliersByCity
	{
		[Column("City"                           )] public string? City         { get; set; } // nvarchar(15)
		[Column("CompanyName" , CanBeNull = false)] public string  CompanyName  { get; set; } = null!; // nvarchar(40)
		[Column("ContactName"                    )] public string? ContactName  { get; set; } // nvarchar(30)
		[Column("Relationship", CanBeNull = false)] public string  Relationship { get; set; } = null!; // varchar(9)
	}
}
