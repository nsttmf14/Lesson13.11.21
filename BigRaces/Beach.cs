﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    class Beach : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет в игру ПЛЯЖ.");
        }
    }
}
