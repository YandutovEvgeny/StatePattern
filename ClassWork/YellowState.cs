using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class YellowState : ITrafficLightState
    {
        public void NextState(LightTraffic lightTraffic)
        {
            lightTraffic.TrafficLightState = new RedState();
            lightTraffic.Panel.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
