using System;

namespace PBO
{
    public abstract class Order
    {
        public const double HargaWaffle = 15.500;
        public const double HargaPancake = 16.250;
        public const double TaxRate = 0.1;

        public TipeOrder TipeOrder { get; set; }
        public int TotalWaffle { get; set; }
        public int TotalPancake { get; set; }
        public double WaffleSubtotal { get; set; }
        public double PancakeSubtotal { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public int JumlahTotal { get; set; }

        public Order() {}

        public Order (TipeOrder tipeorderInput)
        {
            TipeOrder tipe_order = tipeorderInput;
        }

        public abstract void CalcTotals();
    }
}