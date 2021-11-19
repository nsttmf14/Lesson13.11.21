using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    class Team
    {
        public string Country;

        public Team(string country)
        {
            Country = country;
        }

        public void ToPlay(IGame game)
        {
            game.Play(Country);
        }
    }
}
