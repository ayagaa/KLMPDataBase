using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblFacilityAmenity")]
    public partial class TblFacilityAmenity
    {
        [Key]
        [Column("amenity_entry_id")]
        public int AmenityEntryId { get; set; }
        [Column("facility_id")]
        [StringLength(32)]
        public string FacilityId { get; set; } = null!;
        [Column("amenity_description")]
        [StringLength(50)]
        [Unicode(false)]
        public string AmenityDescription { get; set; } = null!;

        [ForeignKey("FacilityId")]
        [InverseProperty("TblFacilityAmenities")]
        public virtual TblFacilityProfile Facility { get; set; } = null!;
    }
}
