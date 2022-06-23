using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    class LiquidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            water.State = new IceWaterState();
            MessageBox.Show("Сейчас вода это лёд");
        }

        public void Heat(Water water)
        {
            water.State = new SteamWaterState();
            MessageBox.Show("Вода превратилась в пар!");
        }
    }
}
