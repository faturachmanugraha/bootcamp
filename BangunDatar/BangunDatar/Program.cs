using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            string keluar = "";
            do
            {
            #region input pilihan
            input:
                Console.WriteLine("Pilih :");
                Console.WriteLine("1. Segitiga");
                Console.WriteLine("2. Persegi");
                Console.WriteLine("3. Persegi Panjang");
                Console.WriteLine("4. Jajar Genjang");
                Console.WriteLine("5. Belah Ketupat");
                Console.WriteLine("6. Lingkaran");
                Console.WriteLine("7. Trapesium");
                Console.WriteLine("8. Layang Layang");
                Console.WriteLine("Input Pilihan Anda dari 1-8 :");
                try
                {
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                    Console.WriteLine("tolong input berupa angka dari 1 sampai 8\n");
                    goto input;
                    throw;
                }

                #endregion

                Console.Clear();

                switch (pilihan)
                {

                    #region segitiga
                    case 1:
                        Segitiga s = new Segitiga();

                    segitiga:
                        try
                        {
                            Console.WriteLine("tolong input alas :");
                            s.alas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input tinggi :");
                            s.tinggi = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input sisi :");
                            s.sisi = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto segitiga;
                            throw;
                        }

                        Console.Clear();

                        Console.WriteLine("Panjang Alas anda : {0}", s.alas);
                        Console.WriteLine("Panjang Tinggi anda : {0}", s.tinggi);
                        Console.WriteLine("Panjang Sisi anda : {0}", s.sisi);
                        Console.WriteLine("Keliling dari segitiga anda : {0}", s.HitungKeliling());
                        Console.WriteLine("Luas dari segitiga anda : {0}\n\n", s.HitungLuas());

                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();

                        break;
                    #endregion

                    #region persegi
                    case 2:

                        Persegi p = new Persegi();

                    persegi:
                        try
                        {
                            Console.WriteLine("tolong input sisi :");
                            p.sisi = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto persegi;
                            throw;
                        }

                        Console.WriteLine("Panjang Sisi anda : {0}", p.sisi);
                        Console.WriteLine("Keliling dari Persegi anda : {0}", p.HitungKeliling());
                        Console.WriteLine("Luas dari Persegi anda : {0}\n\n", p.HitungLuas());
                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();

                        break;
                    #endregion

                    #region Persegi Panjang
                    case 3:

                        PersegiPanjang pp = new PersegiPanjang();

                    persegipanjang:
                        try
                        {
                            Console.WriteLine("tolong input Panjang :");
                            pp.panjang = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input Lebar :");
                            pp.lebar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto persegipanjang;
                            throw;
                        }
                        Console.Clear();
                        Console.WriteLine("Panjang anda : {0}", pp.panjang);
                        Console.WriteLine("Panjang Lebar anda : {0}", pp.lebar);
                        Console.WriteLine("Keliling dari Persegi Panjang anda : {0}", pp.HitungKeliling());
                        Console.WriteLine("Luas dari Persegi Panjang anda : {0}\n\n", pp.HitungLuas());
                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();


                        break;
                    #endregion

                    #region Jajar Genjang
                    case 4:

                        JajarGenjang jg = new JajarGenjang();
                    jajargenjang:

                        try
                        {
                            Console.WriteLine("tolong input Alas :");
                            jg.alas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input Tinggi :");
                            jg.tinggi = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input Sisi Miring :");
                            jg.miring = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto jajargenjang;
                            throw;
                        }
                        Console.Clear();

                        Console.WriteLine("Panjang Alas anda : {0}", jg.alas);
                        Console.WriteLine("Panjang Tinggi anda : {0}", jg.tinggi);
                        Console.WriteLine("Panjang Sisi Miring anda : {0}", jg.miring);
                        Console.WriteLine("Keliling dari Jajar Genjang anda : {0}", jg.HitungKeliling());
                        Console.WriteLine("Luas dari Jajar Genjang anda : {0}\n\n", jg.HitungLuas());
                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();


                        break;
                    #endregion

                    #region Belah Ketupat
                    case 5:
                        BelahKetupat bk = new BelahKetupat();
                    belahketupat:
                        try
                        {
                            Console.WriteLine("tolong input Panjang Sisi :");
                            bk.sisi = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input Panjang Diagonal :");
                            bk.diagonal = Convert.ToDouble(Console.ReadLine());

                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto belahketupat;
                            throw;
                        }
                        Console.Clear();

                        Console.WriteLine("Panjang Sisi anda : {0}", bk.sisi);
                        Console.WriteLine("Panjang Diagonal anda : {0}", bk.diagonal);
                        Console.WriteLine("Keliling dari Jajar Genjang anda : {0}", bk.HitungKeliling());
                        Console.WriteLine("Luas dari Jajar Genjang anda : {0}\n\n", bk.HitungLuas());
                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();

                        break;
                    #endregion

                    #region Lingkaran
                    case 6:
                        Lingkaran l = new Lingkaran();
                    lingkaran:
                        try
                        {
                            Console.WriteLine("tolong input panjang jari jari  :");
                            l.jarijari = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto lingkaran;
                            throw;
                        }

                        Console.WriteLine("Panjang jari jari anda : {0}", l.jarijari);
                        Console.WriteLine("Keliling dari Persegi anda : {0}", l.HitungKeliling());
                        Console.WriteLine("Luas dari Persegi anda : {0}\n\n", l.HitungLuas());
                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();
                        break;

                    #endregion

                    #region trapesium
                    case 7:

                        Trapesium tr = new Trapesium();
                    trapesium:

                        try
                        {
                            Console.WriteLine("tolong input panjang Sisi Atas  :");
                            tr.sisiAtas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input panjang Sisi Bawah  :");
                            tr.sisiBawah = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input panjang Sisi Samping Pertama  :");
                            tr.sisiSamping1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input panjang Sisi Samping Kedua  :");
                            tr.sisiSamping2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input panjang Tinggi  :");
                            tr.tinggi = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto trapesium;
                            throw;
                        }

                        Console.WriteLine("Panjang Sisi Atas anda : {0}", tr.sisiAtas);
                        Console.WriteLine("Panjang Sisi Bawah anda : {0}", tr.sisiBawah);
                        Console.WriteLine("Panjang Sisi Samping Pertama anda : {0}", tr.sisiSamping1);
                        Console.WriteLine("Panjang Sisi Samping Kedua anda : {0}", tr.sisiSamping2);
                        Console.WriteLine("Panjang Sisi Samping Kedua anda : {0}", tr.tinggi);
                        Console.WriteLine("Keliling dari Trapesium anda : {0}", tr.HitungKeliling());
                        Console.WriteLine("Luas dari Trapesium anda : {0}\n\n", tr.HitungLuas());
                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();

                        break;
                    #endregion

                    #region Layang Layang
                    case 8:
                        LayangLayang ll = new LayangLayang();

                    layanglayang:
                        try
                        {
                            Console.WriteLine("tolong input Panjang Diagonal Pertama :");
                            ll.diagonal1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input Panjang Diagonal Kedua :");
                            ll.diagonal2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input Panjang Sisi Pertama :");
                            ll.sisi1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("tolong input Panjang Sisi Kedua :");
                            ll.sisi2 = Convert.ToDouble(Console.ReadLine());

                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("tolong masukkan angka bukan huruf !!\n");
                            goto layanglayang;
                            throw;
                        }
                        Console.Clear();

                        Console.WriteLine("Panjang Diagonal Pertama anda : {0}", ll.diagonal1);
                        Console.WriteLine("Panjang Diagonal Kedua anda : {0}", ll.diagonal2);
                        Console.WriteLine("Panjang Sisi Pertama anda : {0}", ll.sisi1);
                        Console.WriteLine("Panjang Sisi Kedua anda : {0}", ll.sisi2);
                        Console.WriteLine("Keliling dari Layang Layang anda : {0}", ll.HitungKeliling());
                        Console.WriteLine("Luas dari Layang Layang anda : {0}\n\n", ll.HitungLuas());
                        Console.WriteLine("Apakah anda ingin menyudahi ini semua ?");
                        Console.WriteLine("Ya/Tidak");
                        keluar = Console.ReadLine().ToLower().Trim();
                        Console.Clear();

                        break;
                    #endregion

                    default:
                        if (pilihan > 8)
                        {
                            Console.WriteLine("tolong masukan angka 1-8");
                            goto input;
                        }
                        break;
                }





            } while (keluar == "tidak");

            Console.WriteLine("Terimakasih ^__^");
        }
    }
}
