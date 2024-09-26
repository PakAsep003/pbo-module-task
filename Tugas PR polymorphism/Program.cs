using System;

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Hewan hewan = new Hewan("Asep", 12);
        kebunBinatang.TambahHewan(hewan);
        Singa singa = new Singa("Singa", 5, 4);
        kebunBinatang.TambahHewan(singa);
        Gajah gajah = new Gajah("Mambo", 10, 3);
        kebunBinatang.TambahHewan(gajah);
        Ular ular = new Ular("Ujang", 3, 6.5f);
        kebunBinatang.TambahHewan(ular);
        Buaya buaya = new Buaya("Gusti", 7, 4.3f);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        //Console.WriteLine(hewan.Suara());
        //Console.WriteLine(buaya.Suara());
        //Console.WriteLine(ular.Suara());
        //ular.Merayap();
        //Console.WriteLine(singa.Suara());
        //singa.Mengaum();
        //Console.WriteLine(gajah.Suara());


        // Untuk soal nomor 1
        Console.WriteLine(ular.Suara());
        Console.WriteLine(gajah.Suara());

        // Untuk soal nomor 2
        singa.Mengaum();

        // Untuk soal nomor 3
        Console.WriteLine(singa.InfoHewan());

        // Untuk soal nomor 4
        ular.Merayap();

        // Untuk soal nomor 5
        Reptil reptil = buaya;
        Console.WriteLine(reptil.Suara());
    }
}


class Hewan
{
    public string Nama;
    public int Umur;
    
    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return ("Hewan ini bersuara");
    }
    public virtual string InfoHewan()
    {
        return ($"Nama: {Nama},\nUmur: {Umur} tahun.");
    }
}

class Mamalia : Hewan
{
    public int JmlKaki;

    public Mamalia(string nama, int umur, int jmlKaki) : base(nama, umur)
    {
        JmlKaki = jmlKaki;
    }

    public override string Suara()
    {
        return ($"Mamalia ini mengeong");
    }
    public override string InfoHewan()
    {
        return $"\n{base.InfoHewan()},\nJumlah Kaki: {JmlKaki}\n";
    }
}

class Reptil : Hewan
{
    public float PanjangTbh;

    public Reptil(string nama, int umur, float panjangTbh) : base(nama, umur)
    {
        PanjangTbh = panjangTbh;
    }

    public override string Suara()
    {
        return ($"Reptil ini bersuara dengan mendesis");
    }
    public override string InfoHewan()
    {
        return $"{base.InfoHewan()},\nPanjang Tubuh: {PanjangTbh} meter\n";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jmlKaki) : base(nama, umur, jmlKaki)
    { 

    }
    public void Mengaum()
    {
         Console.WriteLine($"Singa ini mengaum kencang");
    }

    public override string Suara()
    {
        return ($"Singa ini bersuara");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jmlKaki) : base(nama, umur, jmlKaki)
    {

    }

    public override String Suara()
    {
        return ($"Gajah ini menderu dengan suara yang kencang");
    }
}

class Ular : Reptil
{
    public Ular (string nama, int umur, float panjangTbh) : base(nama, umur, panjangTbh)
    {

    }

    public void Merayap()
    {
        Console.WriteLine($"Ular ini sedang merayap");
    }
    public override String Suara()
    {
        return ($"Ular bersuara dengan mendesis");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, float panjangTbh) : base(nama, umur, panjangTbh)
    {

    }

    public override String Suara()
    {
        return ($"Buaya sedang bersuara");
    }
}

class KebunBinatang
{
    private List<Hewan> KoleksiHewan;

    public KebunBinatang()
    {
        KoleksiHewan = new List<Hewan>();
    }

    public void TambahHewan(Hewan hewan)
    {
        KoleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in KoleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}