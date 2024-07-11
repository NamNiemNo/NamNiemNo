using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("CUAHANG")]
public partial class Cuahang
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

    [Column("loaihang")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Loaihang { get; set; }

    [Column("ngaydangky")]
    public DateOnly? Ngaydangky { get; set; }

    [Column("idCN")]
    public int? IdCn { get; set; }

    [ForeignKey("IdCn")]
    [InverseProperty("Cuahangs")]
    public virtual Trungtam? IdCnNavigation { get; set; }
}
