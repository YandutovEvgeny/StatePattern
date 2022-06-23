using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    class SteamWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            MessageBox.Show("Вода стала жидкой");
            water.State = new LiquidWaterState();
        }

        public void Heat(Water water)
        {
            MessageBox.Show("Вода осталась паром");
        }
    }
}
