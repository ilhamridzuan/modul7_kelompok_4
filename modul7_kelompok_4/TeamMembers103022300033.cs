using System;
using System.IO;
using System.Text.Json;
class TeamMembers103022300033
{
    public class Mahasiswa
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public string nim;
    }

    public class Members
    {
        public Mahasiswa[] members;
    }

    public void ReadJSON()
    {
        var dataJson = File.ReadAllText("../../../jurnal7_2_103022300033.json");

        var member = JsonSerializer.Deserialize<Members>(dataJson, new JsonSerializerOptions { IncludeFields = true });
        Console.WriteLine("Team Member List: ");

        for (int i = 0; i < member.members.Length; i++)
        {
            Console.WriteLine("{0}. {1} {2} {3}({4} - {5})", i + 1, member.members[i].nim, member.members[i].firstName, member.members[i].lastName, member.members[i].age, member.members[i].gender);
        }
    }
}