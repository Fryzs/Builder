using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderMonitors
{
    public class OfficeMonitorBuilder : MonitorBuilder
    {
        public override void BuildPanel()
        {
            monitor.DiagonalInches = 24.0;
            monitor.Panel = new ScreenPanel("IPS", "1920x1080", 60);
        }

        public override void BuildStand()
        {
            monitor.Stand = new StandSpec(
                heightAdjustable: false,
                tiltAdjustable: true,
                swivelAdjustable: false,
                pivotSupport: false);
        }

        public override void BuildPorts()
        {
            monitor.Ports.AddPort(new Port("HDMI", 1));
            monitor.Ports.AddPort(new Port("VGA", 1));
        }

        public override void BuildSound()
        {
            monitor.Sound = new SoundSystem(hasSpeakers: true, powerWatts: 4, hasHeadphoneJack: true);
        }

        public override void BuildBacklight()
        {
            monitor.Backlight = new Backlight("EdgeLED", hasHDR: false, brightnessNits: 250);
        }
    }
}
