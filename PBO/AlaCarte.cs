using System;

namespace PBO
{
    public class AlaCarte : Order
    {
        public string NamaCustomer { get; set; }
        public double Tax { get; set; }

        public override void CalcTotals()
        {
            Tax = TaxRate * Subtotal;
            Total = Subtotal + Tax;
        }

        public override string ToString()
        {
            return "Tipe Order: " + TipeOrder + "\n" + "Nama Pelanggan: " + NamaCustomer + "\n"
                + "Jumlah Total: " + JumlahTotal.ToString() + "\nSubtotal Waffle: " + WaffleSubtotal.ToString("c3") + "\nSubtotal Pancake: " + PancakeSubtotal.ToString("c3")
                + "\nSubtotal: " + Subtotal.ToString("c3") + "\nTax: " + Tax.ToString("c3") + "\nTotal: " + Total.ToString("c3");
        }
    }
}
