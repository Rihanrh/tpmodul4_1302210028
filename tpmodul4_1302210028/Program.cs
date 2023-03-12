// See https://aka.ms/new-console-template for more information

using tpmodul4_1302210028;
internal class Program
{
    public static void Main(string[] args)
    {
        KodePos cari = new KodePos();
        KodePos.Kelurahan batun = KodePos.Kelurahan.Batununggal;
        int kp = cari.getKodePos(batun);
        Console.WriteLine("Kode Pos untuk kelurahan " + batun + " adalah " + kp);
        Console.WriteLine("\n");

        DoorMachine doorMachine = new DoorMachine();
        doorMachine.currentState = DoorMachine.DoorState.Terbuka;

        Console.Write("Sekarang pintu: ");
        if (doorMachine.currentState == DoorMachine.DoorState.Terbuka)
        {
            Console.WriteLine("Terbuka");
        }
        else
        {
            Console.WriteLine("Terkunci");
        }
        Console.WriteLine("Pintunya akan: (input y untuk membuka, n untuk mengunci)");
        string input = Console.ReadLine();
        if (input == "y")
        {
            doorMachine.activeTrigger(DoorMachine.Trigger.BukaPintu);
            Console.Write("\nSekarang pintu: "+doorMachine.currentState);
        }
        else if (input == "n")
        {
            doorMachine.activeTrigger(DoorMachine.Trigger.KunciPintu);
            Console.Write("\nSekarang pintu: " +doorMachine.currentState);
        }
    }
}
