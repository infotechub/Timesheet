using Agonaika.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agonaika.Core
{
   public class AgonaikaDbContext : DbContext
    {
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }

        public AgonaikaDbContext(DbContextOptions<AgonaikaDbContext> options)
 : base(options)
        { }

        public AgonaikaDbContext()
        {
        }
    }
}
