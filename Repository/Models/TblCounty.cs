using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblCounty")]
    public partial class TblCounty
    {
        public TblCounty()
        {
            TblSubCounties = new HashSet<TblSubCounty>();
            TblWards = new HashSet<TblWard>();
        }

        [Key]
        [Column("county_id")]
        public int CountyId { get; set; }
        [Column("county_name")]
        [StringLength(50)]
        public string CountyName { get; set; } = null!;

        [InverseProperty("County")]
        public virtual ICollection<TblSubCounty> TblSubCounties { get; set; }
        [InverseProperty("County")]
        public virtual ICollection<TblWard> TblWards { get; set; }
    }
}
