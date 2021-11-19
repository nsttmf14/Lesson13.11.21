using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Команда №1: ");
            string team_ru = Console.ReadLine();
            Console.Write("Команда №2: ");
            string team_frc = Console.ReadLine();
            Console.Write("Команда №3: ");
            string team_chn = Console.ReadLine();
            Console.Write("Команда №4: ");
            string team_ukr = Console.ReadLine();

            Team[] teams = {
                new Team(team_ru),
                new Team(team_frc),
                new Team(team_chn),
                new Team(team_ukr)
            };

            foreach (Team team in teams)
            {
                team.ToPlay(new Beach());
                team.ToPlay(new MouseCatching());
                team.ToPlay(new Sea());
                team.ToPlay(new Fishing());
                team.ToPlay(new Postmans());
                team.ToPlay(new Hill());
            }

            Console.ReadKey();
        }
    }
}
