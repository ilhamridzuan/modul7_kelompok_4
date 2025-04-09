using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_4
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Course
    {
        public string courseName { get; set; }
        public int courseCredits { get; set; }
    }
    public class Mahasiswa
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    public class DataMahasiswa103022300066
    {
        public void ReadJSON()
        {
            var jsonString = File.ReadAllText("../../../jurnal7_103022300066.json");
            var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama: {mahasiswa.firstname} {mahasiswa.lastname}");
            Console.WriteLine($"Gender: {mahasiswa.gender}");
            Console.WriteLine($"Age: {mahasiswa.age}");
            Console.WriteLine($"Address: {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");

            Console.WriteLine("Courses:");
            foreach (var course in mahasiswa.courses)
            {
                Console.WriteLine($"- {course.courseName} ({course.courseCredits} credits)");
            }
        }
    }
}
