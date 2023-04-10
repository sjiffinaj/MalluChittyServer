using MChitty.Entity.Helper;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace MChitty.Entity
{
    public class Chitty : BaseEntity
    {
        [Required] 
        public string Name { get; set; }

        [Required]
        public decimal Contribution { get; set; } // amount

        [Required]
        public int Duration { get; set; } // 40 member/ 40 chitty

        [Required]
        public int Slot { get; set; } // ex: 7 days

        [Required]
        public DateTime StartDate { get; set; }

        public ICollection<ChittyMember> ChittyMembers { get; set; }
    }
}
