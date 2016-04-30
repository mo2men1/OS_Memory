namespace OS_Memory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_holes = new System.Windows.Forms.GroupBox();
            this.list_holes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hole = new System.Windows.Forms.Button();
            this.tboxLimit = new System.Windows.Forms.TextBox();
            this.tboxBase = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_processes = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_process = new System.Windows.Forms.Button();
            this.tboxSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_method = new System.Windows.Forms.ComboBox();
            this.list_state = new System.Windows.Forms.ListView();
            this.Base = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Allocated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_swap = new System.Windows.Forms.Button();
            this.combo_swap = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.gb_holes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_holes
            // 
            this.gb_holes.Controls.Add(this.list_holes);
            this.gb_holes.Controls.Add(this.label2);
            this.gb_holes.Controls.Add(this.label1);
            this.gb_holes.Controls.Add(this.btn_hole);
            this.gb_holes.Controls.Add(this.tboxLimit);
            this.gb_holes.Controls.Add(this.tboxBase);
            this.gb_holes.Location = new System.Drawing.Point(12, 12);
            this.gb_holes.Name = "gb_holes";
            this.gb_holes.Size = new System.Drawing.Size(245, 265);
            this.gb_holes.TabIndex = 0;
            this.gb_holes.TabStop = false;
            this.gb_holes.Text = "Holes";
            // 
            // list_holes
            // 
            this.list_holes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.list_holes.Location = new System.Drawing.Point(9, 121);
            this.list_holes.Name = "list_holes";
            this.list_holes.Size = new System.Drawing.Size(223, 134);
            this.list_holes.TabIndex = 5;
            this.list_holes.UseCompatibleStateImageBehavior = false;
            this.list_holes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "n";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Base";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Limit";
            this.columnHeader3.Width = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base";
            // 
            // btn_hole
            // 
            this.btn_hole.Location = new System.Drawing.Point(9, 79);
            this.btn_hole.Name = "btn_hole";
            this.btn_hole.Size = new System.Drawing.Size(223, 23);
            this.btn_hole.TabIndex = 2;
            this.btn_hole.Text = "Add Hole";
            this.btn_hole.UseVisualStyleBackColor = true;
            this.btn_hole.Click += new System.EventHandler(this.btn_hole_Click);
            // 
            // tboxLimit
            // 
            this.tboxLimit.Location = new System.Drawing.Point(132, 48);
            this.tboxLimit.Name = "tboxLimit";
            this.tboxLimit.Size = new System.Drawing.Size(100, 20);
            this.tboxLimit.TabIndex = 1;
            // 
            // tboxBase
            // 
            this.tboxBase.Location = new System.Drawing.Point(9, 48);
            this.tboxBase.Name = "tboxBase";
            this.tboxBase.Size = new System.Drawing.Size(100, 20);
            this.tboxBase.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_processes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_process);
            this.groupBox2.Controls.Add(this.tboxSize);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // list_processes
            // 
            this.list_processes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.list_processes.Location = new System.Drawing.Point(11, 121);
            this.list_processes.Name = "list_processes";
            this.list_processes.Size = new System.Drawing.Size(115, 134);
            this.list_processes.TabIndex = 5;
            this.list_processes.UseCompatibleStateImageBehavior = false;
            this.list_processes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PID";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Process Size";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(9, 79);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(117, 23);
            this.btn_process.TabIndex = 2;
            this.btn_process.Text = "Add Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // tboxSize
            // 
            this.tboxSize.Location = new System.Drawing.Point(9, 48);
            this.tboxSize.Name = "tboxSize";
            this.tboxSize.Size = new System.Drawing.Size(117, 20);
            this.tboxSize.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combo_method);
            this.groupBox1.Location = new System.Drawing.Point(413, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allocation";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(6, 77);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(132, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Methodolgy";
            // 
            // combo_method
            // 
            this.combo_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_method.FormattingEnabled = true;
            this.combo_method.Items.AddRange(new object[] {
            "First Fit",
            "Best Fit",
            "Worst Fit"});
            this.combo_method.Location = new System.Drawing.Point(6, 46);
            this.combo_method.Name = "combo_method";
            this.combo_method.Size = new System.Drawing.Size(132, 21);
            this.combo_method.TabIndex = 0;
            // 
            // list_state
            // 
            this.list_state.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Base,
            this.Size,
            this.Allocated});
            this.list_state.Location = new System.Drawing.Point(12, 300);
            this.list_state.MultiSelect = false;
            this.list_state.Name = "list_state";
            this.list_state.Size = new System.Drawing.Size(545, 166);
            this.list_state.TabIndex = 3;
            this.list_state.UseCompatibleStateImageBehavior = false;
            this.list_state.View = System.Windows.Forms.View.Details;
            // 
            // Base
            // 
            this.Base.Text = "Base";
            this.Base.Width = 175;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 157;
            // 
            // Allocated
            // 
            this.Allocated.Text = "Allocated";
            this.Allocated.Width = 103;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_swap);
            this.groupBox3.Controls.Add(this.combo_swap);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(413, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 148);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UnAllocated Processes";
            // 
            // btn_swap
            // 
            this.btn_swap.Enabled = false;
            this.btn_swap.Location = new System.Drawing.Point(6, 120);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(75, 23);
            this.btn_swap.TabIndex = 3;
            this.btn_swap.Text = "Swap With";
            this.btn_swap.UseVisualStyleBackColor = true;
            // 
            // combo_swap
            // 
            this.combo_swap.FormattingEnabled = true;
            this.combo_swap.Location = new System.Drawing.Point(93, 122);
            this.combo_swap.Name = "combo_swap";
            this.combo_swap.Size = new System.Drawing.Size(45, 21);
            this.combo_swap.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(6, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(132, 85);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "PID";
            this.columnHeader6.Width = 38;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Size";
            this.columnHeader7.Width = 88;
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(286, 472);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(45, 33);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Enabled = false;
            this.btn_prev.Location = new System.Drawing.Point(211, 472);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_prev.Size = new System.Drawing.Size(46, 33);
            this.btn_prev.TabIndex = 8;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 514);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.list_state);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_holes);
            this.Name = "Form1";
            this.Text = "Memory Allocation";
            this.gb_holes.ResumeLayout(false);
            this.gb_holes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_holes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hole;
        private System.Windows.Forms.TextBox tboxLimit;
        private System.Windows.Forms.TextBox tboxBase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.TextBox tboxSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_method;
        private System.Windows.Forms.ListView list_state;
        private System.Windows.Forms.ColumnHeader Base;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Allocated;
        private System.Windows.Forms.ListView list_holes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView list_processes;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_swap;
        private System.Windows.Forms.ComboBox combo_swap;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;

    }
}

