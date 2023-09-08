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
	[Table("Products")]
	public class Product
	{
		[Column("ProductID"      , IsPrimaryKey = true , IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int      ProductId       { get; set; } // int
		[Column("ProductName"    , CanBeNull    = false                                                             )] public string   ProductName     { get; set; } = null!; // nvarchar(40)
		[Column("SupplierID"                                                                                        )] public int?     SupplierId      { get; set; } // int
		[Column("CategoryID"                                                                                        )] public int?     CategoryId      { get; set; } // int
		[Column("QuantityPerUnit"                                                                                   )] public string?  QuantityPerUnit { get; set; } // nvarchar(20)
		[Column("UnitPrice"                                                                                         )] public decimal? UnitPrice       { get; set; } // money
		[Column("UnitsInStock"                                                                                      )] public short?   UnitsInStock    { get; set; } // smallint
		[Column("UnitsOnOrder"                                                                                      )] public short?   UnitsOnOrder    { get; set; } // smallint
		[Column("ReorderLevel"                                                                                      )] public short?   ReorderLevel    { get; set; } // smallint
		[Column("Discontinued"                                                                                      )] public bool     Discontinued    { get; set; } // bit

		#region Associations
		/// <summary>
		/// FK_Order_Details_Products backreference
		/// </summary>
		[Association(ThisKey = nameof(ProductId), OtherKey = nameof(OrderDetail.ProductId))]
		public IEnumerable<OrderDetail> OrderDetails { get; set; } = null!;

		/// <summary>
		/// FK_Products_Categories
		/// </summary>
		[Association(ThisKey = nameof(CategoryId), OtherKey = nameof(DataModel.Category.CategoryId))]
		public Category? Category { get; set; }

		/// <summary>
		/// FK_Products_Suppliers
		/// </summary>
		[Association(ThisKey = nameof(SupplierId), OtherKey = nameof(DataModel.Supplier.SupplierId))]
		public Supplier? Supplier { get; set; }
		#endregion
	}
}
