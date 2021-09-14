using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaTiago.Database;
using AgendaTiago.Models;

namespace AgendaTiago.Business
{
    public class ScheduleLogic : IScheduleLogic
    {
        public ScheduleLogic() { }
        private readonly AppDbContext db;

        public ScheduleLogic(AppDbContext context)
        {
            db = context;
        }

        public IEnumerable<Schedule> GetAllPeople()
        {
            try
            {
                return db.Person.ToList();
            }
            catch { throw; }
        }

        public void AddPerson(Schedule person)
        {
            try
            {
                db.Person.Add(person);
                db.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdatePerson(Schedule person)
        {
            try
            {
                db.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch { throw; }
        }

        public void DeletePerson(int id)
        {
            try
            {
                Schedule person = db.Person.Find(id);
                db.Person.Remove(person);
                db.SaveChanges();
            }
            catch { throw; }
        }
    }
}