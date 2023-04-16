using System.ComponentModel.DataAnnotations;

namespace MChitty.DTO
{
    public class ChittyDto : BaseDto
    {
        public string Name { get; set; }

        public decimal Contribution { get; set; } // amount

        public int Duration { get; set; } // 40 member/ 40 chitty

        public int Slot { get; set; } // ex: 7 days

        public DateTime StartDate { get; set; }
    }
}
