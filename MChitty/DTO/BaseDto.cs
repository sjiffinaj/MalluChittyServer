﻿namespace MChitty.DTO
{
    public class BaseDto
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }
    }
}
