using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Delete
    {
        public void DeletePeople(int _Id, string _Fname, string _Lname, string _IGname)
        {
            TournamentEntities context = new TournamentEntities();

            Person people = context.People.First(i => i.Id == _Id);

            context.People.Remove(people);
        }
    }
}
