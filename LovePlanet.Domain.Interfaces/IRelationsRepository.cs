using System;
using System.Collections.Generic;
using LovePlanet.Domain.Core;

namespace LovePlanet.Domain.Interfaces
{
    public interface IRelationsRepository:IDisposable
    { //харе спешить, куча ошибок!
        IEnumerable<Relations> GetRelationsList();//create of collection of 'People'
        Relations GetRelations(int id); // GET (R) a people by 'id' field
        void Create(Relations item);// CREATE/add (C) a new string in 'People' table
        void Update(Relations item);// Update (U) an existing string in 'People' table
        void Delete(int id);// Delete (D) an existing string in 'People' table
        void Save(); //save any changes in DB in 'People' table
    }
}
