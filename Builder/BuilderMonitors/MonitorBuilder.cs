using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderMonitors
{
    public abstract class MonitorBuilder
    {
        protected Monitor monitor;

        public void CreateNewMonitor(string model)
        {
            monitor = new Monitor
            {
                Model = model,
                Ports = new PortSet()
            };
        }

        public Monitor GetResult()
        {
            return monitor;
        }

        public abstract void BuildPanel();
        public abstract void BuildStand();
        public abstract void BuildPorts();
        public abstract void BuildSound();
        public abstract void BuildBacklight();
    }
}
