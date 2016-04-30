using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Memory
{
    class MemoryBlock
    {
        public long base_address { get; set; }
        public long limit { get; set; }
        public Process process { get; set; }

        public MemoryBlock(long _base, long _limit)
        {
            base_address = _base;
            limit = _limit;
        }

        public void Resize(long size)
        {
            limit = size; 
        }
    }
}
