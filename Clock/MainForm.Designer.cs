
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
            this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHideControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTime.Size = new System.Drawing.Size(130, 55);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // checkBoxShowDate
            // 
            this.checkBoxShowDate.AutoSize = true;
            this.checkBoxShowDate.Checked = true;
            this.checkBoxShowDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowDate.Location = new System.Drawing.Point(12, 127);
            this.checkBoxShowDate.Name = "checkBoxShowDate";
            this.checkBoxShowDate.Size = new System.Drawing.Size(230, 37);
            this.checkBoxShowDate.TabIndex = 2;
            this.checkBoxShowDate.Text = "Показать дату";
            this.checkBoxShowDate.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIcon1";
            this.notifyIconSystemTray.Visible = true;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxShowDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.Button btnHideControls;
    }
}

