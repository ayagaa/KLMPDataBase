using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblWard")]
    public partial class TblWard
    {
        public TblWard()
        {
            TblFacilityProfiles = new HashSet<TblFacilityProfile>();
        }

        [Key]
        [Column("ward_id")]
        public int WardId { get; set; }
        [Column("ward_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string WardName { get; set; } = null!;
        [Column("county_id")]
        public int CountyId { get; set; }
        [Column("subcounty_id")]
        public int? SubcountyId { get; set; }

        [ForeignKey("CountyId")]
        [InverseProperty("TblWards")]
        public virtual TblCounty County { get; set; } = null!;
        [InverseProperty("Ward")]
        public virtual ICollection<TblFacilityProfile> TblFacilityProfiles { get; set; }
    }
}
