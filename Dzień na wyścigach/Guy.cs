using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class Guy
    {
        public String Name;
        public Bet MyBet;
        public int Chash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLables()
        {
            MyLabel.Text = MyBet.GetDescripion();
            MyRadioButton.Text = Name + " ma " + Chash.ToString("C");
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int amount, int dogToWin)
        {

        }
    }
}
