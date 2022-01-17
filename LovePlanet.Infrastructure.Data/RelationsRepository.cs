using System.Collections.Generic;
using LovePlanet.Domain.Interfaces;
using LovePlanet.Domain.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace LovePlanet.Infrastructure.Data
{
    public class RelationsRepository : IRelationsRepository
    {
        private RelationsContext db;

        public RelationsRepository()
        {
            this.db = new RelationsContext();
        }

        public void Create(Relations rel)
        {
            db.Relations_s.Add(rel);
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Relations rel = db.Relations_s.Find(id);

            if (rel != null)
                db.Relations_s.Remove(rel);
            //throw new NotImplementedException();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;//it`s clear
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }

        public Relations GetRelations(int id)
        {
            return db.Relations_s.Find(id);
            //throw new NotImplementedException();
        }

        public IEnumerable<Relations> GetRelationsList()
        {
            return db.Relations_s.ToList();
            //throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Update(Relations rel)
        {
            db.Entry(rel).State = EntityState.Modified;
            //throw new NotImplementedException();
        }
    }
}
