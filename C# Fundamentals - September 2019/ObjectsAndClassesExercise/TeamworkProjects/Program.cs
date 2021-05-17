using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TeamworkProjects
{

    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<TeamworkProjects> teams = new List<TeamworkProjects>();
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] newTeamNameAndUser = Console.ReadLine().Split("-");
                TeamworkProjects team = CreateTeam(newTeamNameAndUser[0], newTeamNameAndUser[1], teams);
                if (team != null)
                {
                    teams.Add(team);
                }
            }
            string addMemberInput = null;
            while ((addMemberInput = Console.ReadLine()) != "end of assignment")
            {
                string[] tokens = addMemberInput.Split("->");
                string member = tokens[0];
                string teamName = tokens[1];
                AddMemberToTeam(member, teamName, teams);
            }
            List<string> disbandNameTeams = GetDisbandTeams(teams);
            disbandNameTeams.Sort();
            teams = teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();
            foreach (TeamworkProjects team in teams)
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine(team);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (string disbandTeam in disbandNameTeams)
            {
                Console.WriteLine(disbandTeam);
            }
        }

        private static TeamworkProjects CreateTeam(string creatorName, string teamName, List<TeamworkProjects> teams)
        {
            TeamworkProjects team = null;
            bool containsTeam = ContainsTeam(teamName, teams);
            if (containsTeam)
            {
                Console.WriteLine($"Team {teamName} was already created!");
                return team;
            }
            bool userIsCreator = UserIsCreatedTeam(creatorName, teams);
            if (userIsCreator)
            {
                Console.WriteLine($"{creatorName} cannot create another team!");
                return team;
            }
            team = new TeamworkProjects(creatorName, teamName);
            Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            return team;
        }

        private static bool ContainsTeam(string teamName, List<TeamworkProjects> teams)
        {
            bool contains = false;
            foreach (TeamworkProjects team in teams)
            {
                if (team.TeamName == teamName)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private static bool UserIsCreatedTeam(string creatorName, List<TeamworkProjects> teams)
        {
            bool userIsCreator = false;
            foreach (TeamworkProjects team in teams)
            {
                if (team.Creator == creatorName)
                {
                    userIsCreator = true;
                    break;
                }
            }
            return userIsCreator;
        }

        private static void AddMemberToTeam(string member, string teamName, List<TeamworkProjects> teams)
        {
            bool containsTeam = false;
            foreach (TeamworkProjects team in teams)
            {
                containsTeam = team.TeamName == teamName;
                if (containsTeam)
                {
                    break;
                }
            }
            if (!containsTeam)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                return;
            }
            bool containsMember = false;
            foreach (TeamworkProjects team in teams)
            {
                containsMember = ContainsMember(member, team);
                if (containsMember)
                {
                    break;
                }
            }
            if (containsMember)
            {
                Console.WriteLine($"Member {member} cannot join team {teamName}!");
                return;
            }
            foreach (TeamworkProjects team in teams)
            {
                if (team.TeamName == teamName && !containsMember)
                {
                    team.Members.Add(member);
                    break;
                }
            }
        }

        private static bool ContainsMember(string member, TeamworkProjects team)
        {
            bool contains = team.Creator == member;
            if (!contains)
            {


                foreach (string teamMember in team.Members)
                {
                    if (teamMember == member)
                    {
                        contains = true;
                        break;
                    }
                }
            }
            return contains;
        }

        private static List<string> GetDisbandTeams(List<TeamworkProjects> teams)
        {
            List<string> disbandTeams = new List<string>();
            foreach (TeamworkProjects team in teams)
            {
                if (team.Members.Count == 0)
                {
                    disbandTeams.Add(team.TeamName);
                }
            }
            return disbandTeams;
        }
    }
}
