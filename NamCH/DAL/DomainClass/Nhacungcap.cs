using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("NHACUNGCAP")]
public partial class Nhacungcap
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("diachi")]
    [StringLength(50)]
    public string? Diachi { get; set; }

    [InverseProperty("IdNccNavigation")]
    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
