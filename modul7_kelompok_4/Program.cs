﻿class Program
{
    public static void Main(string[] args)
    {
        var data1 = new DataMahasiswa103022300033();
        data1.ReadJSON();

        var anggota = new TeamMembers103022300033();
        anggota.ReadJSON();
    }
}