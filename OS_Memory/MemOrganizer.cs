using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Memory
{
    class MemOrganizer
    {
        private List<Process> backing_store = new List<Process>();
        private Queue<Process> processes;
        private List<Process> unAllocatedProcesses = new List<Process>();
        private List<MemoryBlock> AllocatedProcesses = new List<MemoryBlock>();
        public Memory memory;
        
        public MemOrganizer(Queue<Process> _processes, List<MemoryBlock> _holes)
        {
            memory = new Memory(1024 * 1024 * 4);
            processes = _processes;

            var sorted = _holes.OrderBy(o => o.base_address).ToList();
            long last = 0;
            for (int i = 0; i < sorted.Count; i++)
            {
                var size = sorted[i].base_address - last;
                if (size > 0)
                {
                    var p = new Process("xxx", size);
                    var block = new MemoryBlock(last, size);
                    block.process = p;
                    memory.AddBlock(block);
                }
                memory.AddBlock(sorted[i]);
                last = sorted[i].base_address + sorted[i].limit;
            }

            if (memory.memory_size < memory.memory_capacity)
            {
                var b = new MemoryBlock(memory.memory_size, memory.memory_capacity - memory.memory_size);
                b.process = new Process("xxx", memory.memory_capacity - memory.memory_size);
                memory.AddBlock(b);
            }
        }

        public List<List<MemoryBlock>> FirstFit()
        {
            List<List<MemoryBlock>> memStates = new List<List<MemoryBlock>>();
            List<MemoryBlock> list = cloneMemList(memory.memory);
            memStates.Add(list);
            int count = processes.Count;
            while (processes.Count > 0)
            {
                count--;
                var p = processes.Dequeue();
                bool Allocated = false;
                for (int i = 0; i < memory.memory.Count; i++)
                {
                    if (memory.memory[i].process == null && memory.memory[i].limit >= p.size)
                    {
                        memory.Allocate(i, p);
                        AllocatedProcesses.Add(memory.memory[i]);
                        Allocated = true;
                        List<MemoryBlock> _list = cloneMemList(memory.memory);
                        memStates.Add(_list);
                        break;
                    }
                }
                if (!Allocated)
                    unAllocatedProcesses.Add(p);
                if (count == 0) break;
            }
            return memStates;
        }

        public List<List<MemoryBlock>> BestFit()
        {
            List<List<MemoryBlock>> memStates = new List<List<MemoryBlock>>();
            List<MemoryBlock> list = cloneMemList(memory.memory);
            memStates.Add(list);
            int count = processes.Count;
            while (count-- > 0)
            {
                var p = processes.Dequeue();
                bool Allocated = false;
                int min = -1;
                for (int i = 0; i < memory.memory.Count; i++)
                {
                    if (memory.memory[i].process == null && memory.memory[i].limit >= p.size)
                    {
                        if (min == -1)
                            min = i;
                        else if (memory.memory[i].limit < memory.memory[min].limit)
                            min = i;
                    }
                }
                if (min >= 0)
                {
                    memory.Allocate(min, p);
                    AllocatedProcesses.Add(memory.memory[min]);
                    Allocated = true;
                    List<MemoryBlock> _list = cloneMemList(memory.memory);
                    memStates.Add(_list);
                }
                if (!Allocated)
                    unAllocatedProcesses.Add(p);
            }
            return memStates;
        }

        public List<List<MemoryBlock>> WorstFit()
        {
            List<List<MemoryBlock>> memStates = new List<List<MemoryBlock>>();
            List<MemoryBlock> list = cloneMemList(memory.memory);
            memStates.Add(list);
            int count = processes.Count;
            while (count-- > 0)
            {
                var p = processes.Dequeue();
                bool Allocated = false;
                int max = -1;
                for (int i = 0; i < memory.memory.Count; i++)
                {
                    if (memory.memory[i].process == null && memory.memory[i].limit >= p.size)
                    {
                        if (max == -1)
                            max = i;
                        else if (memory.memory[i].limit > memory.memory[max].limit)
                            max = i;
                    }
                }
                if (max >= 0)
                {
                    memory.Allocate(max, p);
                    AllocatedProcesses.Add(memory.memory[max]);
                    Allocated = true;
                    List<MemoryBlock> _list = cloneMemList(memory.memory);
                    memStates.Add(_list);
                }
                if (!Allocated)
                    unAllocatedProcesses.Add(p);
            }
            return memStates;
        }

        public List<MemoryBlock> swap(int p_index, int index)
        {
            var existing = memory.memory[index];
            var p = unAllocatedProcesses[p_index];

            if (memory.memory[index].process == null) throw new InvalidOperationException("Cannot swap a process with a hole.");
            if (memory.memory[index].limit < p.size && (index == memory.memory.Count - 1 || memory.memory[index+1].process != null))
                throw new InvalidOperationException("Cannot swap with a process of smaller size");

            unAllocatedProcesses.Add(existing.process);
            memory.Deallocate(index);
            memory.Allocate(index, p);
            unAllocatedProcesses.RemoveAt(p_index);
            return cloneMemList(memory.memory);
        }


        private List<MemoryBlock> cloneMemList(List<MemoryBlock> _list)
        {
            List<MemoryBlock> newList = new List<MemoryBlock>();
            foreach(MemoryBlock item in _list){
                long _base = item.base_address;
                long _limit = item.limit;
                Process p = item.process;
                MemoryBlock block = new MemoryBlock(_base,_limit);
                block.process = p;
                newList.Add(block);
            }
            return newList;
        }

        public List<Process> getUnAllocated()
        {
            return unAllocatedProcesses;
        }

        public List<MemoryBlock> getAllocated()
        {
            return AllocatedProcesses;
        }

    }
}
