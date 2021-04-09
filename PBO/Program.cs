using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace PBO
{
    public enum TipeOrder { ALACARTE, PAKET };
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double HargaWaffle = 15.500;
            const double HargaPancake = 16.250;
            string TipeInput;
            string Waffle_s;
            string Pancake_s;
            int Waffle;
            int Pancake;
            int Jumlah;
            bool bolTipeOrder;

            do
            {
                Console.WriteLine("Pilih satu tipe order <ALACARTE atau PAKET>?");
                TipeInput = Console.ReadLine().ToUpper();
                Console.WriteLine("");

                bolTipeOrder = Check.CekTipeOrder(TipeInput);

                if (bolTipeOrder == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Tipe order tidak sesuai. Harap tuliskan 'AlaCarte' atau 'Paket'.");
                    Console.WriteLine("");
                }
            } while (bolTipeOrder == false);

            do
            {
                Jumlah = 0;
                do
                {
                    Console.WriteLine("Jumlah Waffle yang dipesan :");
                    Waffle_s = Console.ReadLine();
                    Waffle = Check.CekItem(Waffle_s);

                    if (Waffle == -1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Jumlah pesanan tidak sesuai. Harap menuliskan angka bulat saja.\n");
                    }
                    else if (Waffle != -1) 
                    { 
                        Jumlah += Waffle; 
                    }
                    Console.WriteLine("");
                } while (Waffle == -1);

                do
                {
                    Console.WriteLine("Jumlah Pancake yang dipesan:");
                    Pancake_s = Console.ReadLine();
                    Pancake = Check.CekItem(Pancake_s);

                    if (Pancake == -1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Jumlah pesanan tidak sesuai. Harap menuliskan angka bulat saja.\n");
                    }
                    else if (Pancake != -1)
                    { 
                        Jumlah += Pancake; 
                    }
                    Console.WriteLine("");
                } while (Pancake == -1);

                if (Jumlah < 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Jumlah pesanan tidak sesuai. Minimal memesan 1 menu.");
                    Console.WriteLine("");
                }
            } while (Jumlah < 1);

            if (TipeInput == "PAKET")
            { 
                CekPaket(Waffle, Pancake); 
            }
            else if (TipeInput == "ALACARTE")
            { 
                CekAlaCarte(Waffle, Pancake); 
            }

            Console.WriteLine("");
            Console.WriteLine("Tekan enter untuk mengakhiri pesanan");
            Console.ReadLine();

            void CekPaket(int JumlahWaffle, int JumlahPancake)
            {
                Paket paketOrder = new Paket();

                string Nama_p;
                string Ongkir;
                string Member;
                double Ongkir1;
                bool NamaCustomer_p;

                do
                {
                    Console.WriteLine("Masukkan nama pemesan :");
                    Nama_p = Console.ReadLine().ToUpper();
                    NamaCustomer_p = Check.CekCustomerCode(Nama_p);

                    if (NamaCustomer_p == false) 
                    {
                        Console.WriteLine("Nama customer tidak sesuai. Maksimal terdiri dari 10 huruf.");
                    }

                    paketOrder.Nama_p = Nama_p;
                    Console.WriteLine("");
                } while (NamaCustomer_p == false);

                do
                {
                    Console.WriteLine("Masukkan harga pesan antar:");
                    Ongkir = Console.ReadLine();
                    Ongkir1 = Check.CekOngkir(Ongkir);

                    if (Ongkir1 == -1) 
                    { 
                        Console.WriteLine("Harga pesan antar tidak sesuai. Harap menuliskan bilangan positif saja."); 
                    }

                    paketOrder.Ongkir = Ongkir1;
                    Console.WriteLine("");
                } while (Ongkir1 == -1);

                Console.WriteLine("Apakah mempunyai member? (Ketik 'Y atau y' untuk iya dan enter untuk tidak) :");
                Member = Console.ReadLine();

                if (Member == "Y" || Member == "y") 
                { 
                    paketOrder.Anggota = true; 
                }
                else 
                { 
                    paketOrder.Anggota = false; 
                }
                Console.WriteLine("");

                Console.WriteLine("*-------STRUK PEMESANAN-------*");
                paketOrder.TipeOrder = TipeOrder.PAKET;
                paketOrder.TotalWaffle = JumlahWaffle;
                paketOrder.TotalPancake = JumlahPancake;
                paketOrder.JumlahTotal = JumlahWaffle + JumlahPancake;
                paketOrder.WaffleSubtotal = JumlahWaffle * HargaWaffle;
                paketOrder.PancakeSubtotal = JumlahPancake * HargaPancake;
                paketOrder.Subtotal = paketOrder.WaffleSubtotal + paketOrder.PancakeSubtotal;

                paketOrder.CalcTotals();
                Console.WriteLine(paketOrder.ToString());
            }

            void CekAlaCarte(int JumlahWaffle, int JumlahPancake)
            {
                AlaCarte alacarteOrder = new AlaCarte();

                string Nama;

                Console.WriteLine("Masukkan nama pemesan:");
                Nama = Console.ReadLine().ToUpper();
                Console.WriteLine("");

                Console.WriteLine("*-------STRUK PEMESANAN-------*");
                alacarteOrder.TipeOrder = TipeOrder.ALACARTE;
                alacarteOrder.NamaCustomer = Nama;
                alacarteOrder.TotalWaffle = JumlahWaffle;
                alacarteOrder.TotalPancake = JumlahPancake;
                alacarteOrder.JumlahTotal = JumlahWaffle + JumlahPancake;
                alacarteOrder.WaffleSubtotal = JumlahWaffle * HargaWaffle;
                alacarteOrder.PancakeSubtotal = JumlahPancake * HargaPancake;
                alacarteOrder.Subtotal = alacarteOrder.WaffleSubtotal + alacarteOrder.PancakeSubtotal;

                alacarteOrder.CalcTotals();
                Console.WriteLine(alacarteOrder.ToString());
            }
        }
    }
}