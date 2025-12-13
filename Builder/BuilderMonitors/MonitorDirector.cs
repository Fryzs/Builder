using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderMonitors
{
    public class MonitorDirector
    {
        private MonitorBuilder builder;

        public void SetBuilder(MonitorBuilder builder)
        {
            this.builder = builder;
        }

        public Monitor BuildMonitor(string model)
        {
            builder.CreateNewMonitor(model);
            builder.BuildPanel();
            builder.BuildStand();
            builder.BuildPorts();
            builder.BuildSound();
            builder.BuildBacklight();
            return builder.GetResult();
        }
    }
}
