﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineApp
{
    internal class Place
    {
        public string Town { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Place(string town, string state, string country)
        {
            Town = town;
            State = state;
            Country = country;
        }
    }
}