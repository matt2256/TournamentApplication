using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Update
    {
        /// <summary>
        /// Represent a method for updating People data
        /// </summary>
        public void UpdatePeople(int _Id, string _Fname, string _Lname, string _IGname)
        {
            TournamentEntities context = new TournamentEntities();

            var people = context.People.First<Person>();
            people.Id = _Id;
            people.FirstName = _Fname;
            people.LastName = _Lname;
            people.PeoplePlayerName = _IGname;

            context.SaveChanges();
        }
    }
}
