using System;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamMember1 = new TeamMember();
            teamMember1.CreateTeamMember();

            //    var teamMember2 = new TeamMember();
            //    teamMember2.CreateTeamMember();

            //    var teamMember3 = new TeamMember();
            //    teamMember3.CreateTeamMember();

            //    teamMember3.Display();
            //    teamMember2.Display();
            teamMember1.Display();
        }
    }
}
