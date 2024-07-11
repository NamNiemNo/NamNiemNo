using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("THUCUNG")]
public partial class Thucung
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("loai")]
    [StringLength(150)]
    [Unicode(false)]
    public string Loai { get; set; } = null!;

    [Column("maulong")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Maulong { get; set; }

    [Column("tuoi")]
    public int? Tuoi { get; set; }

    [Column("idCN")]
    public int? IdCn { get; set; }

    [ForeignKey("IdCn")]
    [InverseProperty("Thucungs")]
    public virtual Chunhan? IdCnNavigation { get; set; }
}
