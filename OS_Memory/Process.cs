using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Memory
{
    class Process
    {
        public string id { get; set; }
        public long size { get; set; }

        public Process(string id, long size)
        {
            this.id = id;
            this.size = size;
        }
    }
}
