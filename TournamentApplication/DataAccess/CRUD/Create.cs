using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Create
    {
        /// <summary>
        /// Represent a overloadet method used for Create in CRUD 
        /// </summary>
        /// <param name="x">X represent a object. Where object is a <TournamentModel></param>
        public void Creation(object x)
        {
            ///Represent a obejct of TournamentEntities
            TournamentEntities Context = new TournamentEntities();
        }

    }
}
