
namespace Clock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadOnWindowsStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHideControls = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTime.Size = new System.Drawing.Size(130, 55);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmostToolStripMenuItem,
            this.showControlsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showDateToolStripMenuItem,
            this.toolStripSeparator2,
            this.colorsToolStripMenuItem,
            this.fonsToolStripMenuItem,
            this.toolStripSeparator3,
            this.loadOnWindowsStartupToolStripMenuItem,
            this.toolStripSeparator4,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(208, 182);
            // 
            // topmostToolStripMenuItem
            // 
            this.topmostToolStripMenuItem.CheckOnClick = true;
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.topmostToolStripMenuItem.Text = "Topmost";
            this.topmostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topmostToolStripMenuItem_CheckedChanged);
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.CheckOnClick = true;
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            this.showControlsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showControlsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.CheckOnClick = true;
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.showDateToolStripMenuItem.Text = "Show date";
            this.showDateToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showDateToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.colorsToolStripMenuItem.Text = "Colors ";
            // 
            // foregroundColorToolStripMenuItem
            // 
            this.foregroundColorToolStripMenuItem.Name = "foregroundColorToolStripMenuItem";
            this.foregroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.foregroundColorToolStripMenuItem.Text = "Foreground color";
            this.foregroundColorToolStripMenuItem.Click += new System.EventHandler(this.foregroundColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // fonsToolStripMenuItem
            // 
            this.fonsToolStripMenuItem.Name = "fonsToolStripMenuItem";
            this.fonsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.fonsToolStripMenuItem.Text = "Fonts";
            this.fonsToolStripMenuItem.Click += new System.EventHandler(this.fonsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // loadOnWindowsStartupToolStripMenuItem
            // 
            this.loadOnWindowsStartupToolStripMenuItem.CheckOnClick = true;
            this.loadOnWindowsStartupToolStripMenuItem.Name = "loadOnWindowsStartupToolStripMenuItem";
            this.loadOnWindowsStartupToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.loadOnWindowsStartupToolStripMenuItem.Text = "Load on windows startup";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // checkBoxShowDate
            // 
            this.checkBoxShowDate.AutoSize = true;
            this.checkBoxShowDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowDate.Location = new System.Drawing.Point(12, 127);
            this.checkBoxShowDate.Name = "checkBoxShowDate";
            this.checkBoxShowDate.Size = new System.Drawing.Size(230, 37);
            this.checkBoxShowDate.TabIndex = 2;
            this.checkBoxShowDate.Text = "Показать дату";
            this.checkBoxShowDate.UseVisualStyleBackColor = true;
            this.checkBoxShowDate.CheckedChanged += new System.EventHandler(this.checkBoxShowDate_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIcon1";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.DoubleClick += new System.EventHandler(this.notifyIconSystemTray_DoubleClick);
            this.notifyIconSystemTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(12, 170);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(230, 81);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Скрыть элементы";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(272, 276);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.checkBoxShowDate);
            this.Controls.Add(this.labelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clock";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxShowDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadOnWindowsStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

