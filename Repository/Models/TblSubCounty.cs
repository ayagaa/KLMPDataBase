using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblSubCounty")]
    public partial class TblSubCounty
    {
        [Key]
        [Column("subcounty_id")]
        public int SubcountyId { get; set; }
        [Column("subcounty_name")]
        [StringLength(50)]
        public string SubcountyName { get; set; } = null!;
        [Column("county_id")]
        public int CountyId { get; set; }

        [ForeignKey("CountyId")]
        [InverseProperty("TblSubCounties")]
        public virtual TblCounty County { get; set; } = null!;
    }
}
