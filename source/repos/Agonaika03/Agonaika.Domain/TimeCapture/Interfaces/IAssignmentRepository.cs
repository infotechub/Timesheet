using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Agonaika.Domain.Interfaces
{
    public interface IAssignmentRepository
    {
        void Add(Assignment a);
        void Edit(Assignment a);
        void Remove(int Id);
        IEnumerable GetAssignments();
        Assignment FindById(int Id);
    }
}
