//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using LovePlanet.Domain.Core;

namespace LovePlanet.Infrastructure.Data
{
    public class PepopleContext : DbContext
    {
        public DbSet<People> Peoples_s { get; set; }
        //public DbSet<Relations> Relations_s { get; set; }//? i`m not shure, but have a try
    }
}
