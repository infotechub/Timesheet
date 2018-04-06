using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Agonaika.Domain.Interfaces
{
    public interface ITimesheetRepository
    {
        void Add(Timesheet t);
        void Edit(Timesheet t);
        void Remove(int Id);
        IEnumerable GetTimesheets();
        Timesheet FindById(int Id);
    }
}
