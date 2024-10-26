
namespace Clock
{
    partial class AlarmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmList));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddAlarms = new System.Windows.Forms.Button();
            this.buttonDeleteAlarms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 225);
            this.listBox1.TabIndex = 0;
            // 
            // buttonAddAlarms
            // 
            this.buttonAddAlarms.Location = new System.Drawing.Point(376, 13);
            this.buttonAddAlarms.Name = "buttonAddAlarms";
            this.buttonAddAlarms.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAlarms.TabIndex = 1;
            this.buttonAddAlarms.Text = "Добавить";
            this.buttonAddAlarms.UseVisualStyleBackColor = true;
            this.buttonAddAlarms.Click += new System.EventHandler(this.buttonAddAlarms_Click);
            // 
            // buttonDeleteAlarms
            // 
            this.buttonDeleteAlarms.Location = new System.Drawing.Point(376, 43);
            this.buttonDeleteAlarms.Name = "buttonDeleteAlarms";
            this.buttonDeleteAlarms.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAlarms.TabIndex = 2;
            this.buttonDeleteAlarms.Text = "Удалить";
            this.buttonDeleteAlarms.UseVisualStyleBackColor = true;
            // 
            // AlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 255);
            this.Controls.Add(this.buttonDeleteAlarms);
            this.Controls.Add(this.buttonAddAlarms);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmList";
            this.Text = "AlarmList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddAlarms;
        private System.Windows.Forms.Button buttonDeleteAlarms;
    }
}