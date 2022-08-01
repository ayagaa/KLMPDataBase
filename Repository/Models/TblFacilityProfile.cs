using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblFacilityProfile")]
    public partial class TblFacilityProfile
    {
        public TblFacilityProfile()
        {
            TblFacilityActivityPeriods = new HashSet<TblFacilityActivityPeriod>();
            TblFacilityAmenities = new HashSet<TblFacilityAmenity>();
            TblFacilityContactPeople = new HashSet<TblFacilityContactPerson>();
            TblFacilityDescriptions = new HashSet<TblFacilityDescription>();
            TblFacilityMetrics = new HashSet<TblFacilityMetric>();
            TblFacilityValueChains = new HashSet<TblFacilityValueChain>();
        }

        [Key]
        [Column("facility_id")]
        [StringLength(32)]
        public string FacilityId { get; set; } = Guid.NewGuid().ToString().Substring(0, 7);
        [Column("facility_name")]
        [StringLength(512)]
        public string FacilityName { get; set; } = null!;
        [Column("facility_type")]
        [StringLength(50)]
        [Unicode(false)]
        public string FacilityType { get; set; } = null!;
        [Column("facility_ownership")]
        [StringLength(50)]
        [Unicode(false)]
        public string? FacilityOwnership { get; set; }
        [Column("ward_id")]
        public int WardId { get; set; }
        [Column("altitude")]
        public float? Altitude { get; set; }
        [Column("latitude")]
        public float? Latitude { get; set; }
        [Column("longitude")]
        public float? Longitude { get; set; }
        [Column("precision")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Precision { get; set; }
        [Column("facility_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? FacilityStatus { get; set; }

        [ForeignKey("WardId")]
        [InverseProperty("TblFacilityProfiles")]
        public virtual TblWard Ward { get; set; } = null!;
        [InverseProperty("Facility")]
        public virtual ICollection<TblFacilityActivityPeriod> TblFacilityActivityPeriods { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<TblFacilityAmenity> TblFacilityAmenities { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<TblFacilityContactPerson> TblFacilityContactPeople { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<TblFacilityDescription> TblFacilityDescriptions { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<TblFacilityMetric> TblFacilityMetrics { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<TblFacilityValueChain> TblFacilityValueChains { get; set; }
    }
}
