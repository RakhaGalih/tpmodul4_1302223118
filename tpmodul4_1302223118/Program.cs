using tpmodul4_1302223118;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nomor 3 A-C : \n");
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode pos Batununggal\t: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode pos Kujangsari\t: " + kodePos.GetKodePos("Kujangsari"));
        Console.WriteLine("Kode pos Mengger\t: " + kodePos.GetKodePos("Mengger"));
        Console.WriteLine("Kode pos Wates\t\t: " + kodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode pos Cijaura\t: " + kodePos.GetKodePos("Cijaura"));
        Console.WriteLine("Kode pos Jatisari\t: " + kodePos.GetKodePos("Jatisari"));
        Console.WriteLine("Kode pos Margasari\t: " + kodePos.GetKodePos("Margasari"));
        Console.WriteLine("Kode pos Sekejati\t: " + kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode pos Kebonwaru\t: " + kodePos.GetKodePos("Kebonwaru"));
        Console.WriteLine("Kode pos Maleer\t\t: " + kodePos.GetKodePos("Maleer"));
        Console.WriteLine("Kode pos Samoja\t\t: " + kodePos.GetKodePos("Samoja"));

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