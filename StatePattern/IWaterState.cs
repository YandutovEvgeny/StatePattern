using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface IWaterState
    {
        void Frost(Water water);
        void Heat(Water water);
    }
}
