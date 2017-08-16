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

        public Guy(string name, int chash, RadioButton button, Label label)
        {
            this.Name = name;
            this.Chash = chash;
            MyBet = new Bet(0, 0, this);
            MyRadioButton = button;
            MyLabel = label;

            UpdateLables();
        }

        public void UpdateLables()
        {
            MyLabel.Text = MyBet.GetDescripion();
            MyRadioButton.Text = Name + " ma " + Chash.ToString("C0");
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int amount, int dogToWin)
        {
            if (amount <= Chash)
            {
                MyBet = new Bet(amount, dogToWin, this);
                UpdateLables();
                return true;
            }
            else
                return false;
        }

        public void Collect(int winner)
        {
            Chash += MyBet.PayOut(winner);
            UpdateLables();
            
        }
    }
}
