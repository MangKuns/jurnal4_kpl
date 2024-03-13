// See https://aka.ms/new-console-template for more information


using static KodeBuah;

class KodeBuah
{
    public enum Namabuah
    {
        Apel, Aprikot, Pisang, Paprika,
        Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, melon, Semangka

    }

    public void getKodeBuah (Namabuah namabuah)
    {
        string[] kodeFruit = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00"
        , "K00", "L00", "M00", "N00", "O00"};

        Console.WriteLine("Kode buah dari buah " + namabuah + " adalah " + kodeFruit[(int)namabuah]);
    }

    public static void Main(string[] args)
    {
        KodeBuah buah = new KodeBuah();
        buah.getKodeBuah(Namabuah.Apel);
    }

}
















