﻿using modul7_kelompok_4;

class Program
{
    static void Main(string[] args)
    {
        var dataMahasiswa = new DataMahasiswa103022300066();
        dataMahasiswa.ReadJSON();

        Console.WriteLine();

        var teamMember = new TeamMember103022300066();
        teamMember.ReadJSON();
    }
}