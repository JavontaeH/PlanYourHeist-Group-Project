using System;
using System.Linq;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class Crew
    {
        public Dictionary<string, TeamMember> TeamMembers = new Dictionary<string, TeamMember>();

        public int sumOfSkill
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < this.TeamMembers.Count; i++)
                {
                    var crewMember = this.TeamMembers.ElementAt(i).Value;
                    sum += crewMember.SkillLevel;

                }
                return sum;
            }
        }

        // adds team members as key value pairs with name as key
        public void AddMember(TeamMember member)
        {
            TeamMembers.Add(member.Name, member);
        }




    }
}