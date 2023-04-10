using MChitty.Entity.Helper;
using System.ComponentModel.DataAnnotations;

namespace MChitty.Entity
{
    public class Member : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<ChittyMember> ChittyMembers { get; set; }
    }
}
