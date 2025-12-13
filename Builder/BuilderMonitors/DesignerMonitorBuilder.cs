using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderMonitors
{
 public class DesignerMonitorBuilder : MonitorBuilder
    {
        public override void BuildPanel()
        {
            monitor.DiagonalInches = 32.0;
            monitor.Panel = new ScreenPanel("IPS (Wide Gamut)", "3840x2160", 60);
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
            monitor.Ports.AddPort(new Port("USB-C (DP Alt Mode)", 1));
            monitor.Ports.AddPort(new Port("DisplayPort", 1));
            monitor.Ports.AddPort(new Port("HDMI", 2));
        }

        public override void BuildSound()
        {
            monitor.Sound = new SoundSystem(hasSpeakers: true, powerWatts: 6, hasHeadphoneJack: true);
        }

        public override void BuildBacklight()
        {
            monitor.Backlight = new Backlight("EdgeLED (Uniformity)", hasHDR: false, brightnessNits: 350);
        }
    }
}
