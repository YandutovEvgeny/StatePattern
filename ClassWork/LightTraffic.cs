using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    class LightTraffic
    {
        public Panel Panel { get; set; }
        public ITrafficLightState TrafficLightState { get; set; }

        public LightTraffic(Panel panel)
        {
            Panel = panel;
            TrafficLightState = new RedState();
        }

        public void NextState()
        {
            TrafficLightState.NextState(this);
        }
    }
}
