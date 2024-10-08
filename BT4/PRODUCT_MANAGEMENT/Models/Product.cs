using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLySanPham.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    public int Id { get; set; }

    public int? CatalogId { get; set; }

    [StringLength(50)]
    public string? ProductCode { get; set; }

    [StringLength(250)]
    public string? ProductName { get; set; }

    public string? Picture { get; set; }

    public double? UnitPrice { get; set; }

    [ForeignKey("CatalogId")]
    [InverseProperty("Products")]
    public virtual Catalog? Catalog { get; set; }
}
