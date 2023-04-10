using System.ComponentModel.DataAnnotations;

namespace MChitty.DTO
{
    public class ChittyDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Contribution { get; set; } // amount

        public int Duration { get; set; } // 40 member/ 40 chitty

        public int Slot { get; set; } // ex: 7 days

        public DateTime StartDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }
    }
}
