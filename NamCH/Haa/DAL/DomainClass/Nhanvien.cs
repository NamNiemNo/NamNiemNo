using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("NHANVIEN")]
public partial class Nhanvien
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("diachi")]
    [StringLength(150)]
    [Unicode(false)]
    public string Diachi { get; set; } = null!;

    [Column("sodienthoai")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sodienthoai { get; set; }

    [Column("ngaytuyendung")]
    public DateOnly? Ngaytuyendung { get; set; }

    [Column("idCN")]
    public int? IdCn { get; set; }

    [ForeignKey("IdCn")]
    [InverseProperty("Nhanviens")]
    public virtual Congty? IdCnNavigation { get; set; }
}
