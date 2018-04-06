using Agonaika.Domain;
using Agonaika.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace Agonaika.Core.Repositories
{
   public class TimesheetRepository : ITimesheetRepository
    {
        AgonaikaDbContext context = new AgonaikaDbContext();
        public void Add(Timesheet t)
        {
            context.Timesheets.Add(t);
            context.SaveChanges();
        }


        private readonly AgonaikaDbContext _dbContext;
        public TimesheetRepository(AgonaikaDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void Update(Timesheet t)
        {
            throw new NotImplementedException();
        }

        public Timesheet FindById(int Id)
        {
            var result = (from r in context.Timesheets where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetTimesheets() { return context.Timesheets; }
        public void Remove(int Id) { Timesheet p = context.Timesheets.Find(Id); context.Timesheets.Remove(p); context.SaveChanges(); }

        IEnumerable ITimesheetRepository.GetTimesheets()
        {
            throw new NotImplementedException();
        }

        public void Edit(Timesheet t)
        {
            throw new NotImplementedException();
        }
    }
}

