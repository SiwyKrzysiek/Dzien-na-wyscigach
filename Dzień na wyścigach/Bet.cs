using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet(int amount, int dog, Guy bettor)
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }

        public String GetDescripion()
        {
            if (Amount > 0)
                return Bettor.Name + " postawił " + Amount.ToString("C0") + " na psa numer " + (Dog + 1);
            else
                return Bettor.Name + " nie zawarł zakładu";
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
