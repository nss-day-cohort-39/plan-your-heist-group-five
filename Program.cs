using System;
using System.Collections.Generic;
using System.Linq;

namespace plan_your_heist_group_five
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> Team = new List<TeamMember>();

            int memberCount = 0;

            while (true)
            {
                // Print the message "Plan Your Heist!".
                Console.WriteLine("Plan Your Heist!");

                Console.WriteLine($"Enter team member's name:");
                string TeamMemberName = Console.ReadLine();

                if (TeamMemberName == "")
                {
                    break;
                }

                Console.WriteLine($"Enter team member's skill level (1-10):");
                int TeamMemberSkill = Int32.Parse((Console.ReadLine()));

                Console.WriteLine($"Enter team member's courage (0.0-2.0):");
                double TeamMemberCourage = Double.Parse((Console.ReadLine()));

                TeamMember newMember = new TeamMember()
                {
                    Name = TeamMemberName,
                    SkillLevel = TeamMemberSkill,
                    CourageFactor = TeamMemberCourage
                };

                Team.Add(newMember);

                memberCount++;

                Console.WriteLine("---------------");

                Console.WriteLine($"member total = {memberCount}");

                Console.WriteLine("---------------");
                Console.WriteLine($"Name: {newMember.Name}");

                Console.WriteLine("---------------");
                Console.WriteLine($"Skill Level: {newMember.SkillLevel}");

                Console.WriteLine("---------------");
                Console.WriteLine($"Courage: {newMember.CourageFactor}");

                Console.WriteLine("---------------");

                Console.WriteLine(Team);
            }
        }
    }
}
