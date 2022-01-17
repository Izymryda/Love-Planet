using System;
using System.Collections.Generic;
using System.Linq;
using LovePlanet.Domain.Core;
using LovePlanet.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LovePlanet.Infrastructure.Data
{
    class PeopleRepository : IPeopleRepository
    {
        private Rel_of_pepContext db;

        public PeopleRepository()
        {
            this.db = new Rel_of_pepContext();//при создании нового екз класа PeopleRepository будет создан новый екз класа Rel_of_pepContext
        }

        public IEnumerable<People> GetPeoplesList()
        {
            return db.Peoples_s.ToList();//need a System.Linq
        }
        
        public People GetPeople(int id)
        {
            return db.Peoples_s.Find(id);
        }

        public void Create(People people)
        {
            db.Peoples_s.Add(people);
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            People people = db.Peoples_s.Find(id);
            if (people != null)
                db.Peoples_s.Remove(people);            
            //throw new NotImplementedException();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)//здравствуй новое слово. Освобождение памяти?
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
            //throw new NotImplementedException();
        }

        public void Dispose()//очистка памяти после работы с объектом?
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }

        /* я просто очень мега внимательный человек :)
        public People GetPeople(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<People> GetPeoplesList()
        {
            throw new NotImplementedException();
        }*/

        public void Save()
        {
            db.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Update(People people)
        {
            db.Entry(people).State = EntityState.Modified;//need a MS.EntityFrameworkCore
            //throw new NotImplementedException();
        }
    }
}
