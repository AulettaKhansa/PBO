using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace PBO
{
    public static class Check
    {
        public static bool CekCustomerCode(string input)
        {
            var regexItem = new Regex(@"^[a-zA-Z]+$");

            int Panjang = input.Length;

            if (regexItem.IsMatch(input))
            {
                if (Panjang >= 1 && Panjang <= 10) 
                { 
                    return true; 
                }
                return false;
            }
            return false;
        }

        public static bool CekTipeOrder(String Input)
        {
            Input = Input.ToUpper();
            return Enum.IsDefined(typeof(TipeOrder), Input);
        }

        public static double CekOngkir(String Input)
        {  
            double hasil;
            try 
            { 
                hasil = Convert.ToDouble(Input); 
            }
            catch 
            {
                 return -1; 
            }
            if (hasil < 0)
            { 
                return -1; 
            }
            return hasil;
        }

        public static int CekItem(String Input)
        {
            int hasil;
            try 
            { 
                hasil = Convert.ToInt32(Input); 
            }
            catch 
            { 
                return -1; 
            }
            
            if (hasil < 0) 
            { 
                return -1; 
            }
            return hasil;
        }
    }
}