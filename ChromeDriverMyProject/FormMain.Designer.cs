namespace ChromeDriverMyProject
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader c_num;
            this.btn_new = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.c_thread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sorting = new System.Windows.Forms.Button();
            this.btn_closeAll = new System.Windows.Forms.Button();
            this.bnt_newplus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_newThread = new System.Windows.Forms.Button();
            c_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_num
            // 
            c_num.Text = "CNum";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(48, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New +";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            c_num,
            this.c_thread});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 314);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // c_thread
            // 
            this.c_thread.Text = "C_Thread";
            this.c_thread.Width = 284;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btn_sorting
            // 
            this.btn_sorting.Location = new System.Drawing.Point(161, 12);
            this.btn_sorting.Name = "btn_sorting";
            this.btn_sorting.Size = new System.Drawing.Size(64, 23);
            this.btn_sorting.TabIndex = 2;
            this.btn_sorting.Text = "Sorting";
            this.btn_sorting.UseVisualStyleBackColor = true;
            this.btn_sorting.Click += new System.EventHandler(this.btn_sorting_Click);
            // 
            // btn_closeAll
            // 
            this.btn_closeAll.Location = new System.Drawing.Point(231, 12);
            this.btn_closeAll.Name = "btn_closeAll";
            this.btn_closeAll.Size = new System.Drawing.Size(64, 23);
            this.btn_closeAll.TabIndex = 4;
            this.btn_closeAll.Text = "Close All";
            this.btn_closeAll.UseVisualStyleBackColor = true;
            this.btn_closeAll.Click += new System.EventHandler(this.btn_closeAll_Click);
            // 
            // bnt_newplus
            // 
            this.bnt_newplus.Location = new System.Drawing.Point(66, 12);
            this.bnt_newplus.Name = "bnt_newplus";
            this.bnt_newplus.Size = new System.Drawing.Size(60, 23);
            this.bnt_newplus.TabIndex = 5;
            this.bnt_newplus.Text = "New ++";
            this.bnt_newplus.UseVisualStyleBackColor = true;
            this.bnt_newplus.Click += new System.EventHandler(this.bnt_newplus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "12";
            // 
            // btn_newThread
            // 
            this.btn_newThread.Location = new System.Drawing.Point(527, 12);
            this.btn_newThread.Name = "btn_newThread";
            this.btn_newThread.Size = new System.Drawing.Size(76, 23);
            this.btn_newThread.TabIndex = 7;
            this.btn_newThread.Text = "New Thread";
            this.btn_newThread.UseVisualStyleBackColor = true;
            this.btn_newThread.Click += new System.EventHandler(this.btn_newThread_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 367);
            this.Controls.Add(this.btn_newThread);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bnt_newplus);
            this.Controls.Add(this.btn_closeAll);
            this.Controls.Add(this.btn_sorting);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_new);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phi vụ triệu đô";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader c_thread;
        private System.Windows.Forms.Button btn_sorting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btn_closeAll;
        private System.Windows.Forms.Button bnt_newplus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_newThread;
    }
}

