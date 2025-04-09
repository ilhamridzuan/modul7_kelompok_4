using System;
using System.Text.Json;
using static DataMahasiswa103022300033;

class DataMahasiswa103022300033
{
    public class Address
    {
        public String streetAddress;
        public String city;
        public String state;
    }
    public class MataKuliah
    {
        public string code;
        public string name;
    }
    public class Mahasiswa103022300033
    {
        public String firstName;
        public String lastName;
        public String gender;
        public int age;
        public String fakultas;
        public Address address;
        public MataKuliah[] courses;
    }

    public void ReadJSON()
    {
        var dataJson = File.ReadAllText("../../../jurnal7_1_103022300033.json");

        var mahasiswa = JsonSerializer.Deserialize<Mahasiswa103022300033>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama: {0} {1}, gender: {2}, umur: {3}, alamat: {4}, {5}, {6}", mahasiswa.firstName, mahasiswa.lastName, mahasiswa.gender, mahasiswa.age, mahasiswa.address.streetAddress, mahasiswa.address.city, mahasiswa.address.state);
        Console.WriteLine("MK {0} - {1}", mahasiswa.courses[0].code, mahasiswa.courses[0].name);
    }
}
