using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Memory
{
    public partial class Form1 : Form
    {
        private List<List<MemoryBlock>> memStates = new List<List<MemoryBlock>>();
        private int processes_counter = 0;
        private int holes_counter = 0;
        private int state = 0;

        public Form1()
        {
            InitializeComponent();
            combo_method.SelectedIndex = combo_method.FindStringExact("First Fit");
        }

        private void AddRow(string b, string s, string p)
        {
            list_state.Items.Add(new ListViewItem(new[] { b, s, p }));
        }

        private void LogState(List<MemoryBlock> mem)
        {
            //AddRow("---", "---", "---");
            while (list_state.Items.Count > 0)
            {
                //leave the header
                list_state.Items.RemoveAt(0);
            }
            for (int i = 0; i < mem.Count; i++)
            {
                var block = mem[i];
                AddRow(block.base_address.ToString(), block.limit.ToString(), block.process != null ? block.process.id : "---");
            }
        }

        private void btn_hole_Click(object sender, EventArgs e)
        {
            long _base = long.Parse(tboxBase.Text), _limit = long.Parse(tboxLimit.Text);
            tboxBase.Clear();
            tboxLimit.Clear();
            list_holes.Items.Add(new ListViewItem(new[] { holes_counter++.ToString(),_base.ToString(), _limit.ToString()}));
            tboxBase.Focus();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            long _size = long.Parse(tboxSize.Text);
            string name = "P" + processes_counter.ToString();
            tboxSize.Clear();
            list_processes.Items.Add(new ListViewItem(new[] { name, _size.ToString()}));
            processes_counter++;
            tboxSize.Focus();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            List<MemoryBlock> holes = getHoles();
            Queue<Process> processes = getProcesses();
            MemOrganizer mo = new MemOrganizer(processes, holes);
            string method = combo_method.Text;
            switch (method)
            {
                case "First Fit" :
                    memStates = mo.FirstFit();
                    break;
                case "Best Fit" :
                    memStates = mo.BestFit();
                    break;
                case "Worst Fit" :
                    memStates = mo.WorstFit();
                    break;
            }
            state = 0;
            LogState(memStates[state]);
            btn_next.Enabled = true;
            btn_prev.Enabled = false;
        }

        private List<MemoryBlock> getHoles()
        {
            List<MemoryBlock> list = new List<MemoryBlock>();
            for (int i = 0; i < list_holes.Items.Count; i++)
            {
                long _base = long.Parse(list_holes.Items[i].SubItems[1].Text);
                long _limit = long.Parse(list_holes.Items[i].SubItems[2].Text);
                MemoryBlock block = new MemoryBlock(_base, _limit);
                list.Add(block);
            }
            return list;
        }

        private Queue<Process> getProcesses()
        {
            Queue<Process> queue = new Queue<Process>();
            for (int i = 0; i < list_processes.Items.Count; i++)
            {
                string pid = list_processes.Items[i].SubItems[0].Text;
                long size = long.Parse(list_processes.Items[i].SubItems[1].Text);
                queue.Enqueue(new Process(pid, size));
            }
            return queue;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            LogState(memStates[++state]);

            if (state == memStates.Count - 1)
                btn_next.Enabled = false;
            else
                btn_next.Enabled = true;

            if (state == 0)
                btn_prev.Enabled = false;
            else
                btn_prev.Enabled = true;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            LogState(memStates[--state]);

            if (state == memStates.Count - 1)
                btn_next.Enabled = false;
            else
                btn_next.Enabled = true;

            if (state == 0)
                btn_prev.Enabled = false;
            else
                btn_prev.Enabled = true;
        }

        private void tboxBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tboxLimit.Focus();
            }
        }

        private void tboxLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_hole.PerformClick();
            }
        }

        private void tboxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_process.PerformClick();
            }
        }

    }
}
