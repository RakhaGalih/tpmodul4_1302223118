﻿using tpmodul4_1302223118;
using static tpmodul4_1302223118.KodePos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nomor 3 A-C : \n");
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode pos Batununggal\t: " + kodePos.GetKodePos(Kelurahan.Batununggal));
        Console.WriteLine("Kode pos Kujangsari\t: " + kodePos.GetKodePos(Kelurahan.Kujangsari));
        Console.WriteLine("Kode pos Mengger\t: " + kodePos.GetKodePos(Kelurahan.Mengger));
        Console.WriteLine("Kode pos Wates\t\t: " + kodePos.GetKodePos(Kelurahan.Wates));
        Console.WriteLine("Kode pos Cijaura\t: " + kodePos.GetKodePos(Kelurahan.Cijaura));
        Console.WriteLine("Kode pos Jatisari\t: " + kodePos.GetKodePos(Kelurahan.Jatisari));
        Console.WriteLine("Kode pos Margasari\t: " + kodePos.GetKodePos(Kelurahan.Margasari));
        Console.WriteLine("Kode pos Sekejati\t: " + kodePos.GetKodePos(Kelurahan.Sekejati));
        Console.WriteLine("Kode pos Kebonwaru\t: " + kodePos.GetKodePos(Kelurahan.Kebonwaru));
        Console.WriteLine("Kode pos Maleer\t\t: " + kodePos.GetKodePos(Kelurahan.Maleer));
        Console.WriteLine("Kode pos Samoja\t\t: " + kodePos.GetKodePos(Kelurahan.Samoja));

        // Commit "menambahkan implementasi dengan table-driven"

        Console.WriteLine("\n\n\nNomor 5 A-E : \n");

        DoorMachine door = new DoorMachine();
        door.DoAction(Action.BukaPintu);
        door.DoAction(Action.KunciPintu);
        door.DoAction(Action.KunciPintu); // Kunci lagi, tidak akan terjadi apa-apa karena pintu sudah terkunci
        door.DoAction(Action.BukaPintu);

        // Commit "menambahkan implementasi dengan state-based construction"
    }
}