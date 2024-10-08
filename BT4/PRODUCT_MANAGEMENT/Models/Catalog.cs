using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLySanPham.Models;

[Table("Catalog")]
public partial class Catalog
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? CatalogCode { get; set; }

    [StringLength(250)]
    public string? CatalogName { get; set; }

    [InverseProperty("Catalog")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
