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
   public class AssignmentRepository : IAssignmentRepository
    {
        AgonaikaDbContext context = new AgonaikaDbContext();
        public void Add(Assignment a)
        {
            context.Assignments.Add(a);
            context.SaveChanges();
        }


        private readonly AgonaikaDbContext _dbContext;
        public AssignmentRepository(AgonaikaDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void Update(Assignment a)
        {
            throw new NotImplementedException();
        }

        public Assignment FindById(int Id)
        {
            var result = (from r in context.Assignments where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetTimesheets() { return context.Assignments; }
        public void Remove(int Id) { Assignment p = context.Assignments.Find(Id); context.Assignments.Remove(p); context.SaveChanges(); }

        IEnumerable IAssignmentRepository.GetAssignments()
        {
            throw new NotImplementedException();
        }

        public void Edit(Assignment a)
        {
            throw new NotImplementedException();
        }
    }
}

