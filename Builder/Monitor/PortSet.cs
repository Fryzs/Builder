using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PortSet
    {
        private readonly List<Port> ports = new List<Port>();

        public void AddPort(Port port)
        {
            ports.Add(port);
        }

        public string GetDescription()
        {
            if (ports.Count == 0)
                return "немає портів";

            var list = new List<string>();
            foreach (var port in ports)
            {
                list.Add(port.GetDescription());
            }

            return string.Join(", ", list);
        }
        public PortSet Clone()
        {
            var copy = new PortSet();
            foreach (var port in ports)
            {
                copy.AddPort(port.Clone());
            }
            return copy;
        }
    }
}
