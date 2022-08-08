using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLMP.DataAccess.Repository.Models
{
    [Table("tblValueChain")]
    public partial class TblValueChain
    {
        public TblValueChain()
        {
            TblFacilityValueChains = new HashSet<TblFacilityValueChain>();
        }

        [Key]
        [Column("value_chain_id")]
        public int ValueChainId { get; set; }
        [Column("value_chain_type")]
        [StringLength(50)]
        [Unicode(false)]
        public string ValueChainType { get; set; } = null!;
        [Column("value_chain_name")]
        [MaxLength(50)]
        public string ValueChainName { get; set; } = null!;

        [InverseProperty("ValueChain")]
        public virtual ICollection<TblFacilityValueChain> TblFacilityValueChains { get; set; }
    }
}
