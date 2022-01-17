using System;
using System.Collections.Generic;
using LovePlanet.Domain.Core;

namespace LovePlanet.Domain.Interfaces
{
    interface IRelationsRepository:IDisposable
    {
        IEnumerable<People> GetRelationsList();//create of collection of 'People'
        People GetRelations(int id); // GET (R) a people by 'id' field
        void Create(People item);// CREATE/add (C) a new string in 'People' table
        void Update(People item);// Update (U) an existing string in 'People' table
        void Delete(People item);// Delete (D) an existing string in 'People' table
        void Save(); //save any changes in DB in 'People' table
    }
}
