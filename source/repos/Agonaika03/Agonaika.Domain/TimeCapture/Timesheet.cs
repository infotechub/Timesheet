using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Agonaika.Domain
{
    public partial class Timesheet
    {
        [Key]
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string MemberId { get; set; }
        public long? Frequency { get; set; }
        public DateTime? PayPeriodEndDate { get; set; }
    }
}
