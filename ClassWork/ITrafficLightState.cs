using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    interface ITrafficLightState
    {
        void NextState(LightTraffic lightTraffic);
    }
}
