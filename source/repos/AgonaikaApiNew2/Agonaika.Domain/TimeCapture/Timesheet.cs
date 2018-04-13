using System;
using System.Collections.Generic;
using System.Text;

namespace Agonaika.Domain.TimeCapture
{
    public class Timesheet
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string MemberId { get; set; }
        public long? Frequency { get; set; }
        public DateTime? PayPeriodEndDate { get; set; }
    }
}
