using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderMonitors
{
    public class GamingMonitorBuilder : MonitorBuilder
    {
        public override void BuildPanel()
        {
            monitor.DiagonalInches = 27.0;
            monitor.Panel = new ScreenPanel("Fast IPS", "2560x1440", 165);
        }

        public override void BuildStand()
        {
            monitor.Stand = new StandSpec(
                heightAdjustable: true,
                tiltAdjustable: true,
                swivelAdjustable: true,
                pivotSupport: true);
        }

        public override void BuildPorts()
        {
            monitor.Ports.AddPort(new Port("DisplayPort", 1));
            monitor.Ports.AddPort(new Port("HDMI", 2));
            monitor.Ports.AddPort(new Port("USB-A Hub", 4));
        }

        public override void BuildSound()
        {
            monitor.Sound = new SoundSystem(hasSpeakers: false, powerWatts: 0, hasHeadphoneJack: true);
        }

        public override void BuildBacklight()
        {
            monitor.Backlight = new Backlight("DirectLED", hasHDR: true, brightnessNits: 400);
        }
    }
}
