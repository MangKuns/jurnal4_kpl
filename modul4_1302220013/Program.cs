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

    

}

class PosisiKarakterGame
{
    public enum Trigger
    {
        TombolS, TombolW, TombolX
    }
    
    public enum StatusKarakter
    {
        Berdiri, jongkok, Tengkurap, Terbang
    }

    private StatusKarakter man = StatusKarakter.Berdiri;

    public PosisiKarakterGame()
    {
        Console.WriteLine("Posisi sekarang lagi Berdiri");
    }
    public StatusKarakter ChangePosisi(Trigger trigger)
    {
        
        if (trigger == Trigger.TombolS)
        {
            if (man == StatusKarakter.Berdiri)
            {
                man = StatusKarakter.jongkok;
            }
            else if (man == StatusKarakter.Terbang)
            {
                man = StatusKarakter.Berdiri;
            }
            else if (man == StatusKarakter.jongkok)
            {
                man = StatusKarakter.Tengkurap;
            }
        } else if (trigger == Trigger.TombolW)
        {
            if (man == StatusKarakter.Tengkurap)
            {
                man = StatusKarakter.jongkok;
            }
            else if (man == StatusKarakter.jongkok)
            {
                man = StatusKarakter.Berdiri;
            }
            else if (man == StatusKarakter.Berdiri)
            {
                man = StatusKarakter.Terbang;
                Console.WriteLine("Posisi take off");
            }
        } else if ((trigger == Trigger.TombolX))
        {
            if (man == StatusKarakter.Terbang)
            {
                man = StatusKarakter.jongkok;
                Console.WriteLine("Posisi Landing");
            }
        } 
        
        return man;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
       
        KodeBuah buah = new KodeBuah();
        buah.getKodeBuah(Namabuah.Apel);

        Console.WriteLine("______________________________________" + "\n");

        PosisiKarakterGame karakter1 = new PosisiKarakterGame();
        karakter1.ChangePosisi(PosisiKarakterGame.Trigger.TombolW);
        karakter1.ChangePosisi(PosisiKarakterGame.Trigger.TombolX);
        Console.WriteLine("Posisi " + karakter1.ChangePosisi(PosisiKarakterGame.Trigger.TombolS));
        Console.WriteLine("Posisi " + karakter1.ChangePosisi(PosisiKarakterGame.Trigger.TombolW));
        Console.WriteLine("Posisi " + karakter1.ChangePosisi(PosisiKarakterGame.Trigger.TombolW));
        karakter1.ChangePosisi(PosisiKarakterGame.Trigger.TombolW);
        //Saya pakai 
    }
}














