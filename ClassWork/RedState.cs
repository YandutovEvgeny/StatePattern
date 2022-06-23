using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class RedState : ITrafficLightState
    {
        public void NextState(LightTraffic lightTraffic)
        {
            lightTraffic.TrafficLightState = new GreenState();
            lightTraffic.Panel.BackColor = System.Drawing.Color.Red;
        }
    }
}
