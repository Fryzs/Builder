using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class StandSpec
    {
        public bool HeightAdjustable { get; }
        public bool TiltAdjustable { get; }
        public bool SwivelAdjustable { get; }
        public bool PivotSupport { get; }

        public StandSpec(bool heightAdjustable,
                         bool tiltAdjustable,
                         bool swivelAdjustable,
                         bool pivotSupport)
        {
            HeightAdjustable = heightAdjustable;
            TiltAdjustable = tiltAdjustable;
            SwivelAdjustable = swivelAdjustable;
            PivotSupport = pivotSupport;
        }

        public string GetDescription()
        {
            var options = new List<string>();
            if (HeightAdjustable) options.Add("регулювання висоти");
            if (TiltAdjustable) options.Add("нахил");
            if (SwivelAdjustable) options.Add("поворот");
            if (PivotSupport) options.Add("pivot");

            if (options.Count == 0)
                return "проста, без регулювань";

            return "ергономічна: " + string.Join(", ", options);
        }
    }
}
