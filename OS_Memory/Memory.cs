using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Memory
{
    class Memory
    {
        public List<MemoryBlock> memory;
        public long memory_capacity;
        public long memory_size;
        public Memory(long size)
        {
            memory = new List<MemoryBlock>();
            memory_capacity = size;
            memory_size = 0;
        }

        public void AddBlock(MemoryBlock block)
        {
            if (block.limit + memory_size > memory_capacity) throw new OutOfMemoryException();
            memory.Add(block);
            //if(memory[count-2])
            memory_size += block.limit;
        }

        public void Allocate(int index, Process process)
        {
            if (index >= memory.Count || index < 0) throw new IndexOutOfRangeException();
            var block = memory[index];
            if (block.process != null) throw new InvalidOperationException("Can't allocate an already allocated memory block");
            if (block.limit < process.size) throw new InvalidOperationException("Process size is bigger than the memory block");
            block.process = process;
            var remaining = block.limit - process.size;
            block.Resize(process.size);
            if (remaining > 0)
            {
                var block_new = new MemoryBlock(block.base_address + block.limit, remaining);
                memory.Insert(index + 1, block_new);
            }
            memory[index] = block;
        }

        public void Deallocate(int index)
        {
            if (index >= memory.Count || index < 0) throw new IndexOutOfRangeException();
            var block = memory[index];
            if (block.process == null) throw new InvalidOperationException("Can't deallocate a non-allocated memory block");
            block.process = null;
            if (index + 1 < memory.Count && memory[index + 1].process == null)
                MergeNext(index);
            if (index - 1 >= 0 && memory[index - 1].process == null)
                MergeNext(index - 1);
            memory[index] = block;
        }

        public void MergeNext(int index)
        {
            var index2 = index + 1;
            if (index >= memory.Count || index < 0) throw new IndexOutOfRangeException();
            if (index2 >= memory.Count || index2 < 0) throw new IndexOutOfRangeException();
            if (memory[index].process != null || memory[index2].process != null) throw new InvalidOperationException("Cannot Merge Allocated Memory Block");

            memory[index].Resize(memory[index].limit + memory[index2].limit);
            memory.RemoveAt(index2);
        }
    }
}
