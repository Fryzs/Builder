using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ScreenPanel
    {
        public string Type { get; }
        public string Resolution { get; }
        public int RefreshRateHz { get; }

        public ScreenPanel(string type, string resolution, int refreshRateHz)
        {
            Type = type;
            Resolution = resolution;
            RefreshRateHz = refreshRateHz;
        }

        public string GetDescription()
        {
            return $"{Type}, {Resolution}, {RefreshRateHz} Гц";
        }
        public ScreenPanel Clone()
        {
            return new ScreenPanel(Type, Resolution, RefreshRateHz);
        }
    }
}
