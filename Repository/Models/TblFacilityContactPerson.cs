using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblFacilityContactPerson")]
    public partial class TblFacilityContactPerson
    {
        [Key]
        [Column("contact_entry_id")]
        public int ContactEntryId { get; set; }
        [Column("contact_person")]
        [StringLength(50)]
        public string ContactPerson { get; set; } = null!;
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = null!;
        [Column("contact_type")]
        [StringLength(50)]
        [Unicode(false)]
        public string ContactType { get; set; } = null!;
        [Column("facility_id")]
        [StringLength(32)]
        public string? FacilityId { get; set; }
        [Column("county_id")]
        public int? CountyId { get; set; }
        [Column("subcounty_id")]
        public int? SubcountyId { get; set; }
        [Column("ward_id")]
        public int? WardId { get; set; }

        [ForeignKey("FacilityId")]
        [InverseProperty("TblFacilityContactPeople")]
        public virtual TblFacilityProfile? Facility { get; set; }
    }
}
