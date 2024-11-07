using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AddAlarm : Form
    {
       public Alarm Alarm { get; set; }
        public AddAlarm()
        {
            InitializeComponent();
            Alarm = new Alarm();
            labelFileName.MaximumSize = new Size(this.Width - 25, 75);
            openFileDialogSound.Filter = "MP-3(*.mp3)|*.mp3|Flac(*.flac)|*flac|All Audio|*.mp3;*.flac";
            openFileDialogSound.FilterIndex = 3;

            for(int i =0;i<checkedListBoxWeek.Items.Count;i++)
            {
                checkedListBoxWeek.SetItemChecked(i,true);
            }
        }
        public AddAlarm(Alarm alarm):this()
        {
            Alarm = alarm;
            InitWindowsFromAlarm();
        }
        void InitWindowsFromAlarm()
        {
            if (Alarm.Date != DateTime.MinValue) this.dateTimePickerDate.Value = Alarm.Date;
            this.dateTimePickerTime.Value = Alarm.Time;
            this.labelFileName.Text = Alarm.Filename;
            for(int i = 0;i<Alarm.WeekDays.Length;i++)
            {
                checkedListBoxWeek.SetItemChecked(i, Alarm.WeekDays[i]);
            }
            
        }
        void InitAlarm()
        {
            Alarm.Date = dateTimePickerDate.Enabled ? dateTimePickerDate.Value : DateTime.MinValue;
            Alarm.Time = dateTimePickerTime.Value;
            Alarm.Filename = labelFileName.Text;
            for(int i = 0;i<Alarm.WeekDays.Length;i++)
            {
                Alarm.WeekDays[i] = false;
            }
            for(int i = 0; i< checkedListBoxWeek.CheckedIndices.Count;i++)     //CheckedIndices это коллекция, которая содержит индексы выбранных галочек в checkedListBoxWeek
            {

                //Alarm.WeekDays[i] = (checkedListBoxWeek.Items[i] as CheckBox).Checked;
                Alarm.WeekDays[checkedListBoxWeek.CheckedIndices[i]] = true;
                Console.Write(checkedListBoxWeek.CheckedIndices[i] + "\t");
            }
            Console.WriteLine();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            InitAlarm();
            
        }

        private void checkBoxExectDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked;
        }

        private void labelFileName_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = true;
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            if(openFileDialogSound.ShowDialog(this) == DialogResult.OK)
            {
               Alarm.Filename =  labelFileName.Text = openFileDialogSound.FileName;
            }
        }
    }
}
