using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class GreenState : ITrafficLightState
    {
        public void NextState(LightTraffic lightTraffic)
        {
            lightTraffic.TrafficLightState = new YellowState();
            lightTraffic.Panel.BackColor = System.Drawing.Color.Green;
        }
    }
}
