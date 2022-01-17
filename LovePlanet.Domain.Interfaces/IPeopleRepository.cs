using System;
using System.Collections.Generic;
using LovePlanet.Domain.Core;

namespace LovePlanet.Domain.Interfaces
{
    //Domen Services layer
    public interface IPeopleRepository:IDisposable
    {
        IEnumerable<People> GetPeoplesList();//create of collection of 'People'
        People GetPeople(int id); // GET (R) a people by 'id' field
        void Create(People item);// CREATE/add (C) a new string in 'People' table
        void Update(People item);// Update (U) an existing string in 'People' table
        void Delete(int id);// Delete (D) an existing string in 'People' table
        void Save(); //save any changes in DB in 'People' table
    }
}
