using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class Member
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string nim { get; set; }

    }
    public class TeamMembers
    {
        public List<Member> members { get; set; }
    }
    public class TeamMember103022300066
    {
        public void ReadJSON()
        {
            var json = File.ReadAllText("../../../jurnal7_103022300066.json");
            var teamMembers = JsonSerializer.Deserialize<TeamMembers>(json);

            Console.WriteLine("Team Members:");
            foreach (var member in teamMembers.members)
            {
                Console.WriteLine($"{member.nim} {member.firstname} {member.lastname} {member.age} {member.gender}");
            }

        }
    }
}
