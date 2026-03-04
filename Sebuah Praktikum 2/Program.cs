class Rumah
{
    // atribut
    public string warna;
    public int jumlah_ruangan;
    public int jumlah_pintu;
    public string alamat; 

    public Rumah(string Warna, int Jumlah_Ruangan, int Jumlah_Pintu, string Alamat)
    {
        warna = Warna;
        jumlah_ruangan = Jumlah_Ruangan;
        jumlah_pintu = Jumlah_Pintu;
        alamat = Alamat;
    }

// method
    public void TampilkanInfo()
    {
        Console.WriteLine($"Warna Rumah :{warna} ");
        Console.WriteLine($"Jumlah Ruangan :{jumlah_ruangan} Ruangan");
        Console.WriteLine($"Jumlah Pintu :{jumlah_pintu} Pintu ");
        Console.WriteLine($"Alamat Rumah :{alamat} ");
    }
}


 class Program
{
    static void Main(string[] args)
    {
        //NamaClass namaObjek = new NamaClass();


        Rumah rumahMewah = new Rumah("Merah Merona", 10, 5, "bwi"); // ini adalah sebuah objek
        Rumah rumahKecil = new Rumah("Merah abang", 11, 3, "bwi"); // ini adalah sebuah objek
        Rumah rumahBesar = new Rumah("Merah Biru", 190, 4, "Ngawi"); // ini adalah sebuah objek


        //pemberian value di atribut
        //rumahMewah.warna = "Putih Elegant";
        //rumahMewah.jumlah_pintu = 15;
        //rumahMewah.alamat = "Jepang, Jember Patrang";
        //rumahMewah.jumlah_ruangan = 3;

        // pemanggilan method
        rumahMewah.TampilkanInfo();
        Console.WriteLine(" ");
        rumahKecil.TampilkanInfo();
        Console.WriteLine(" ");
        rumahBesar.TampilkanInfo();

    }
}