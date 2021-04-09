using System;

namespace PBO
{
    public class Paket : Order
    {
        public string Nama_p { get; set; }
        public double Ongkir { get; set; }
        public bool Anggota { get; set; }

        public override void CalcTotals()
        {
            if (Anggota) 
            { 
                Ongkir = 0; 
            }
            Total = Subtotal + Ongkir;
        }

        public override string ToString()
        {
            return "Tipe Order: " + TipeOrder + "\n" + "Nama Pelanggan: " + Nama_p + "\n"
                + "Jumlah Total: " + JumlahTotal.ToString() + "\nSubtotal Waffle: " + WaffleSubtotal.ToString("c3") + "\nSubtotal Pancake: " + PancakeSubtotal.ToString("c3")
                + "\nSubtotal: " + Subtotal.ToString("c3") + "\nOngkos Antar: " + Ongkir.ToString("c3") + "\nGrand Total: " + Total.ToString("c3");
        }
    }
}