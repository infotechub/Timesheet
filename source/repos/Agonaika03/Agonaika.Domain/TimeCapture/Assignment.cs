using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Agonaika.Domain
{
    public partial class Assignment
    {
        [Key]
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string MemberId { get; set; }
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }
        public string AffiliateId { get; set; }
        public string SiteId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftId { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? PayRate { get; set; }
        public string Position { get; set; }
        public string IsExempt { get; set; }
    }
}
