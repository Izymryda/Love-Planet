using System;
using LovePlanet.Domain.Core;

namespace LovePlanet.Services.Interfaces
{
    public interface IRel_of_pep
    {
        void MakeRel_of_pep(People people1, People people2, Relations relations);
    }
}
