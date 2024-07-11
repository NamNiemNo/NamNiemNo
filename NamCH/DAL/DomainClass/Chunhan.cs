using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("CHUNHAN")]
public partial class Chunhan
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

    [InverseProperty("IdCnNavigation")]
    public virtual ICollection<Thucung> Thucungs { get; set; } = new List<Thucung>();
}
