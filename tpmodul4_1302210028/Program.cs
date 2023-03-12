// See https://aka.ms/new-console-template for more information

using tpmodul4_1302210028;
internal class Program
{
    public static void Main(string[] args)
    {
        KodePos cari = new KodePos();
        KodePos.Kelurahan klu = KodePos.Kelurahan.Batununggal;
        int kp = cari.getKodePos(klu);
        Console.WriteLine("Kode Pos untuk kelurahan " + klu + " adalah " + kp);
    }
}
