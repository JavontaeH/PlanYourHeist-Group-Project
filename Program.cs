using System;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

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
                    Console.WriteLine("Enter your number of trial runs");
                    int trialRuns = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your crew has {myCrew.TeamMembers.Count} team members!");
                    Console.WriteLine($"The team's combined skill level is: {myCrew.sumOfSkill}");
                    for (int i = 0; i < trialRuns; i++)
                    {
                        int luck = rand.Next(-10, 11);
                        int bankDifficulty = 100 + luck;
                        for (int ii = 0; ii < myCrew.TeamMembers.Count; ii++)
                        {
                            var crewMember = myCrew.TeamMembers.ElementAt(ii).Value;

                        }
                        Console.WriteLine($"The bank's difficulty level is: {bankDifficulty}");
                        if (myCrew.sumOfSkill >= bankDifficulty)
                        {
                            Console.WriteLine("Success!");
                        }
                        else
                        {
                            Console.WriteLine("Failure!");
                        }
                    }
                }
            }


        }
    }
}
