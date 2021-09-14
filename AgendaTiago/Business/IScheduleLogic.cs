using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaTiago.Models;

namespace AgendaTiago.Business
{
    public interface IScheduleLogic
    {
        IEnumerable<Schedule> GetAllPeople();
        void AddPerson(Schedule person);
        void UpdatePerson(Schedule person);
        void DeletePerson(int id);
    }
}
