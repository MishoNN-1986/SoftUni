using System;
using System.Collections.Generic;
using System.Text;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        public TeamworkProjects(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Members = new List<string>();
        }

        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(TeamName)
                .Append(Environment.NewLine)
                .Append($"- {Creator}")
                .Append(Environment.NewLine);

            Members.Sort();

            foreach (string member in Members)
            {
                sb.Append($"-- {member}")
                    .Append(Environment.NewLine);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
