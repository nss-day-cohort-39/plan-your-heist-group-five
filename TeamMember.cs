using System;

namespace plan_your_heist_group_five
{
  public class TeamMember
  {
    public string Name { get; set; }
    public double CourageFactor { get; set; }
    public int SkillLevel { get; set; }
    public TeamMember(string newName, double newCourage, int newSkillLevel)
    {
      Name = newName;
      CourageFactor = newCourage;
      SkillLevel = newSkillLevel;
    }
  }
}
