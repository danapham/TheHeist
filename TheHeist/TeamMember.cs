using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public double SkillLevel { get; set; }
        public double CourageFactor { get; set; }
        public static int Count = 0;

        public TeamMember()
        {
            Count++;
        }

        public void Display()
        {
            Console.WriteLine($"Team Member: {Name}");
            Console.WriteLine($"Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
        }

        public void CreateTeamMember()
        {
            Console.WriteLine("Plan Your Heist!");
            Console.Write("Enter a team member's name: ");
            Name = Console.ReadLine();

            while (Name != "")
            {
                Console.WriteLine("Enter this team member's skill level: ");
                SkillLevel = Math.Round(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter this team member's courage factor: ");
                CourageFactor = Convert.ToInt32(Console.ReadLine());

                if (CourageFactor < 0)
                {
                    CourageFactor = 0;
                }
                else if (CourageFactor > 2)
                {
                    CourageFactor = 2.0;
                }
                CreateTeamMember();
            }
        }
    }
}
