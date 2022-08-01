using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblFacilityValueChain")]
    public partial class TblFacilityValueChain
    {
        [Key]
        [Column("entry_id")]
        public int EntryId { get; set; }
        [Column("facility_id")]
        [StringLength(32)]
        public string FacilityId { get; set; } = null!;
        [Column("value_chain_id")]
        public int ValueChainId { get; set; }

        [ForeignKey("FacilityId")]
        [InverseProperty("TblFacilityValueChains")]
        public virtual TblFacilityProfile Facility { get; set; } = null!;
        [ForeignKey("ValueChainId")]
        [InverseProperty("TblFacilityValueChains")]
        public virtual TblValueChain ValueChain { get; set; } = null!;
    }
}
