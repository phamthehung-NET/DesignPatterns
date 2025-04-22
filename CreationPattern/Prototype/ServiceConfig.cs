using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.Prototype
{
    public class ServiceConfig
    {
        public string Url { get; set; }

        public int TimeOut { get; set; }

        public ServiceConfig Clone()
        {
            return (ServiceConfig)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Url: {Url}, TimeOut: {TimeOut}";
        }
    }
}
