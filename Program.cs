using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            TeamMember phase1 = new TeamMember();
            Console.WriteLine("Enter You Team member's name");
            phase1.Name = Console.ReadLine();
            Console.WriteLine("Enter You Team member's skill level");
            phase1.SkillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter You Team member's courage factor");
            phase1.CourageFactor = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {phase1.Name} SkillLevel: {phase1.SkillLevel} CourageFactor: {phase1.CourageFactor}");
        }
    }
}
