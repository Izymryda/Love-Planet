﻿using System;

namespace LovePlanet.Domain.Core
{
    //Domen Model layer
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
