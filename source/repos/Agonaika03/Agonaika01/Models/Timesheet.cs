using System;
using System.Collections.Generic;

namespace Agonaika01.Models
{
    public partial class Timesheet
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string MemberId { get; set; }
        public long? Frequency { get; set; }
        public DateTime? PayPeriodEndDate { get; set; }
    }
}
