using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("SANPHAM")]
public partial class Sanpham
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("mota")]
    [StringLength(150)]
    [Unicode(false)]
    public string Mota { get; set; } = null!;

    [Column("soluongtonkho")]
    public int? Soluongtonkho { get; set; }

    [Column("giatien")]
    public int? Giatien { get; set; }

    [Column("idNCC")]
    public int? IdNcc { get; set; }

    [ForeignKey("IdNcc")]
    [InverseProperty("Sanphams")]
    public virtual Nhacungcap? IdNccNavigation { get; set; }
}
