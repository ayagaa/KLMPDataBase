using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblFacilityDescription")]
    public partial class TblFacilityDescription
    {
        [Key]
        [Column("description_entry_id")]
        public int DescriptionEntryId { get; set; }
        [Column("description")]
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [Column("facility_id")]
        [StringLength(32)]
        public string FacilityId { get; set; } = null!;

        [ForeignKey("FacilityId")]
        [InverseProperty("TblFacilityDescriptions")]
        public virtual TblFacilityProfile Facility { get; set; } = null!;
    }
}
