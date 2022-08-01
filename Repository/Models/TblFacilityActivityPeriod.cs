using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblFacilityActivityPeriod")]
    public partial class TblFacilityActivityPeriod
    {
        [Key]
        [Column("period_entry_id")]
        public int PeriodEntryId { get; set; }
        [Column("period_description")]
        [StringLength(50)]
        [Unicode(false)]
        public string PeriodDescription { get; set; } = null!;
        [Column("facility_id")]
        [StringLength(32)]
        public string FacilityId { get; set; } = null!;

        [ForeignKey("FacilityId")]
        [InverseProperty("TblFacilityActivityPeriods")]
        public virtual TblFacilityProfile Facility { get; set; } = null!;
    }
}
