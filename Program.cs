using System;

namespace plan_your_heist_group_five
{
  class Program
  {
    static void Main(string[] args)
    {
      // Print the message "Plan Your Heist!".
      Console.WriteLine("Plan Your Heist!");

      Console.WriteLine($"Enter team member's name:");
      string TeamMemberName = Console.ReadLine();

      Console.WriteLine($"Enter team member's skill level (1-10):");
      int TeamMemberSkill = Int32.Parse((Console.ReadLine()));

      Console.WriteLine($"Enter team member's courage (0.0-2.0):");
      double TeamMemberCourage = Double.Parse((Console.ReadLine()));

      Console.WriteLine($"{TeamMemberName} {TeamMemberSkill} {TeamMemberCourage}");
    }
  }
}