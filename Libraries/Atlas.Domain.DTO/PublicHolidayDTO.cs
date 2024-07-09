using System;
using System.Collections.Generic;

namespace Atlas.Domain.DTO
{
    public sealed class PublicHolidayDTO
    {
        public int PublicHolidayId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public string BranchCode { get; set; }
        public bool IsHoliday { get; set; }
        public bool IsWeekend { get; set; }
    }
}
