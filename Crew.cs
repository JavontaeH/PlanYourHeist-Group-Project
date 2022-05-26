using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class Crew
    {
        public Dictionary<string, TeamMember> TeamMembers = new Dictionary<string, TeamMember>();

        // adds team members as key value pairs with name as key
        public void AddMember(TeamMember member)
        {
            TeamMembers.Add(member.Name, member);
        }


    }
}