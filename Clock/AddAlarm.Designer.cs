
namespace Clock
{
    partial class AddAlarm
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
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxExectDate = new System.Windows.Forms.CheckBox();
            this.checkedListBoxWeek = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(304, 53);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerTime.Size = new System.Drawing.Size(191, 44);
            this.dateTimePickerTime.TabIndex = 0;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileName.Location = new System.Drawing.Point(12, 151);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(78, 20);
            this.labelFileName.TabIndex = 2;
            this.labelFileName.Text = "Filename:";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseFile.Location = new System.Drawing.Point(12, 207);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(115, 49);
            this.buttonChooseFile.TabIndex = 3;
            this.buttonChooseFile.Text = "Выбрать файл";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(333, 233);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(420, 233);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 53);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(204, 44);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // checkBoxExectDate
            // 
            this.checkBoxExectDate.AutoSize = true;
            this.checkBoxExectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxExectDate.Location = new System.Drawing.Point(15, 12);
            this.checkBoxExectDate.Name = "checkBoxExectDate";
            this.checkBoxExectDate.Size = new System.Drawing.Size(209, 28);
            this.checkBoxExectDate.TabIndex = 7;
            this.checkBoxExectDate.Text = "На конкретную дату";
            this.checkBoxExectDate.UseVisualStyleBackColor = true;
            this.checkBoxExectDate.CheckedChanged += new System.EventHandler(this.checkBoxExectDate_CheckedChanged);
            // 
            // checkedListBoxWeek
            // 
            this.checkedListBoxWeek.CheckOnClick = true;
            this.checkedListBoxWeek.ColumnWidth = 65;
            this.checkedListBoxWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxWeek.FormattingEnabled = true;
            this.checkedListBoxWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
            this.checkedListBoxWeek.Location = new System.Drawing.Point(12, 103);
            this.checkedListBoxWeek.MultiColumn = true;
            this.checkedListBoxWeek.Name = "checkedListBoxWeek";
            this.checkedListBoxWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBoxWeek.Size = new System.Drawing.Size(483, 28);
            this.checkedListBoxWeek.TabIndex = 1;
            // 
            // AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 275);
            this.Controls.Add(this.checkBoxExectDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.checkedListBoxWeek);
            this.Controls.Add(this.dateTimePickerTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAlarm";
            this.Text = "AddAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckBox checkBoxExectDate;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeek;
    }
}