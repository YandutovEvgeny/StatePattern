using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    class IceWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            MessageBox.Show("Лёд остался льдом");
        }

        public void Heat(Water water)
        {
            water.State = new LiquidWaterState();
            MessageBox.Show("Лёд расплавился и стал жидким");
        }
    }
}
