using System;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {


            Crew myCrew = new Crew();
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter your team members name");
            string response = Console.ReadLine();
            CreateMemberLoop(response);

            void CreateMemberLoop(string str)
            {
                if (str != "")
                {
                    TeamMember temp = new TeamMember(str);
                    Console.WriteLine("Enter your team members skill level");
                    temp.SkillLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your team members courage");
                    temp.CourageFactor = Double.Parse(Console.ReadLine());
                    myCrew.AddMember(temp);
                    Console.WriteLine("Enter the next Team Members Name");
                    CreateMemberLoop(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Your crew has {myCrew.TeamMembers.Count} team members!");
                    for (int i = 0; i < myCrew.TeamMembers.Count; i++)
                    {
                        var crewMember = myCrew.TeamMembers.ElementAt(i).Value;

                    }
                }

            }

        }
    }
}
