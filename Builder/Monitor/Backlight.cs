using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Backlight
    {
        public string Type { get; }
        public bool HasHDR { get; }
        public int BrightnessNits { get; }

        public Backlight(string type, bool hasHDR, int brightnessNits)
        {
            Type = type;
            HasHDR = hasHDR;
            BrightnessNits = brightnessNits;
        }

        public string GetDescription()
        {
            var hdr = HasHDR ? "з HDR" : "без HDR";
            return $"{Type}, {BrightnessNits} ніт, {hdr}";
        }
        public Backlight Clone()
        {
            return new Backlight(Type, HasHDR, BrightnessNits);
        }
    }
}
