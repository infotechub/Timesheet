using Agonaika.Domain.TimeCapture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agonaika.Data.EntityConfigs
{
    class TimesheetDbConfig : IEntityTypeConfiguration<Timesheet>
    {
        public void Configure(EntityTypeBuilder<Timesheet> builder)
        {
            builder.ToTable("Timesheet", AgoCRUDTestContext.DEFAULT_SCHEMA);
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id)
             .ForSqlServerUseSequenceHiLo("TimesheetSeq", AgoCRUDTestContext.DEFAULT_SCHEMA);
            builder.Property<DateTime>("PayPeriodEndDate").IsRequired();
            builder.Property<int>("MemberId").IsRequired();
            builder.Property<int>("SiteId").IsRequired();
            builder.Property<int>("EmployeeId").IsRequired();


           // var navigation = builder.Metadata.FindNavigation(nameof(Timesheet.Assignments));
            //Tells EF to access the assignments collection thru the backing field. The assignments property is an IReadOnlyCollection
           // navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

        }
    }
}
