using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblFacilityMetric")]
    public partial class TblFacilityMetric
    {
        [Key]
        [Column("metric_entry_id")]
        public int MetricEntryId { get; set; }
        [Column("facility_id")]
        [StringLength(32)]
        public string FacilityId { get; set; } = null!;
        [Column("metric_description")]
        [StringLength(50)]
        public string MetricDescription { get; set; } = null!;
        [Column("metric_uom")]
        [StringLength(50)]
        [Unicode(false)]
        public string? MetricUom { get; set; }
        [Column("metric_value")]
        [StringLength(50)]
        public string? MetricValue { get; set; }
        [Column("year_of_measure")]
        public int YearOfMeasure { get; set; }

        [ForeignKey("FacilityId")]
        [InverseProperty("TblFacilityMetrics")]
        public virtual TblFacilityProfile Facility { get; set; } = null!;
    }
}
