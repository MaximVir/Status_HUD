namespace Rhaegal
{
    partial class Status_HUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status_HUD));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workstreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.infraBox = new System.Windows.Forms.RichTextBox();
            this.networkingBox = new System.Windows.Forms.RichTextBox();
            this.cxpBox = new System.Windows.Forms.RichTextBox();
            this.liveSiteBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatorToolStripMenuItem1,
            this.shiftToolStripMenuItem1});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.testToolStripMenuItem.Text = "Create";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // operatorToolStripMenuItem1
            // 
            this.operatorToolStripMenuItem1.Name = "operatorToolStripMenuItem1";
            this.operatorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.operatorToolStripMenuItem1.Text = "Operator";
            this.operatorToolStripMenuItem1.Click += new System.EventHandler(this.OperatorToolStripMenuItem1_Click);
            // 
            // shiftToolStripMenuItem1
            // 
            this.shiftToolStripMenuItem1.Name = "shiftToolStripMenuItem1";
            this.shiftToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.shiftToolStripMenuItem1.Text = "Shift";
            this.shiftToolStripMenuItem1.Click += new System.EventHandler(this.ShiftToolStripMenuItem1_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.workstreamToolStripMenuItem,
            this.shiftToolStripMenuItem,
            this.aliasToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.LocationToolStripMenuItem_Click);
            // 
            // workstreamToolStripMenuItem
            // 
            this.workstreamToolStripMenuItem.Name = "workstreamToolStripMenuItem";
            this.workstreamToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.workstreamToolStripMenuItem.Text = "Workstream";
            this.workstreamToolStripMenuItem.Click += new System.EventHandler(this.WorkstreamToolStripMenuItem_Click);
            // 
            // shiftToolStripMenuItem
            // 
            this.shiftToolStripMenuItem.Name = "shiftToolStripMenuItem";
            this.shiftToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.shiftToolStripMenuItem.Text = "Shift";
            this.shiftToolStripMenuItem.Click += new System.EventHandler(this.ShiftToolStripMenuItem_Click);
            // 
            // aliasToolStripMenuItem
            // 
            this.aliasToolStripMenuItem.Name = "aliasToolStripMenuItem";
            this.aliasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aliasToolStripMenuItem.Text = "Alias";
            this.aliasToolStripMenuItem.Click += new System.EventHandler(this.AliasToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatorToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.operatorToolStripMenuItem.Text = "Operator";
            this.operatorToolStripMenuItem.Click += new System.EventHandler(this.OperatorToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // infraBox
            // 
            this.infraBox.BackColor = System.Drawing.Color.Black;
            this.infraBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infraBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infraBox.ForeColor = System.Drawing.Color.Cyan;
            this.infraBox.Location = new System.Drawing.Point(1041, 214);
            this.infraBox.MaximumSize = new System.Drawing.Size(300, 500);
            this.infraBox.Name = "infraBox";
            this.infraBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.infraBox.Size = new System.Drawing.Size(300, 500);
            this.infraBox.TabIndex = 7;
            this.infraBox.Text = "";
            // 
            // networkingBox
            // 
            this.networkingBox.BackColor = System.Drawing.Color.Black;
            this.networkingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.networkingBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkingBox.ForeColor = System.Drawing.Color.SpringGreen;
            this.networkingBox.Location = new System.Drawing.Point(583, 214);
            this.networkingBox.MaximumSize = new System.Drawing.Size(300, 500);
            this.networkingBox.Name = "networkingBox";
            this.networkingBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.networkingBox.Size = new System.Drawing.Size(300, 500);
            this.networkingBox.TabIndex = 6;
            this.networkingBox.Text = "";
            // 
            // cxpBox
            // 
            this.cxpBox.BackColor = System.Drawing.Color.Black;
            this.cxpBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxpBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxpBox.ForeColor = System.Drawing.Color.Yellow;
            this.cxpBox.Location = new System.Drawing.Point(1500, 214);
            this.cxpBox.MaximumSize = new System.Drawing.Size(300, 500);
            this.cxpBox.Name = "cxpBox";
            this.cxpBox.ReadOnly = true;
            this.cxpBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.cxpBox.Size = new System.Drawing.Size(300, 500);
            this.cxpBox.TabIndex = 8;
            this.cxpBox.Text = "";
            this.cxpBox.UseWaitCursor = true;
            // 
            // liveSiteBox
            // 
            this.liveSiteBox.BackColor = System.Drawing.Color.Black;
            this.liveSiteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liveSiteBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveSiteBox.ForeColor = System.Drawing.Color.LightPink;
            this.liveSiteBox.Location = new System.Drawing.Point(125, 214);
            this.liveSiteBox.MaximumSize = new System.Drawing.Size(300, 500);
            this.liveSiteBox.Name = "liveSiteBox";
            this.liveSiteBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.liveSiteBox.Size = new System.Drawing.Size(300, 500);
            this.liveSiteBox.TabIndex = 5;
            this.liveSiteBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1494, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "text";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1494, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "text";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(526, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(890, 182);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Status_HUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 792);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liveSiteBox);
            this.Controls.Add(this.networkingBox);
            this.Controls.Add(this.cxpBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.infraBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Status_HUD";
            this.Text = "Balerion v1.0";
            this.Load += new System.EventHandler(this.Status_HUD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workstreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shiftToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aliasToolStripMenuItem;
        public System.Windows.Forms.RichTextBox infraBox;
        public System.Windows.Forms.RichTextBox networkingBox;
        public System.Windows.Forms.RichTextBox cxpBox;
        public System.Windows.Forms.RichTextBox liveSiteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}