using MChitty.Entity.Helper;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace MChitty.Entity
{
    public class ChittyMember : BaseEntity
    {
        [Required]
        public int ChittyId { get; set; }

        [Required]
        public int MemberId { get; set; }

        public byte LastDraw { get; set; }

        public bool IsAvailable { get; set; }

        public virtual Chitty Chitty { get; set; }

        public virtual Member Member { get; set; }
    }
}
