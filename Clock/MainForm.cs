using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using MediaPlayer;

namespace Clock
{
    public partial class MainForm : Form
    {

        ColorDialog backgroundColorDialog;
        ColorDialog foregroundColorDialog;
        ChooseFonts chooseFontDialog;
        AlarmList alarmList;
        Alarm alarm;

        string FontFile { get; set; }

        public MainForm()
        {
            InitializeComponent();
            AllocConsole();
            SetFontDirectory();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();
            // SetFontDirectory();

            chooseFontDialog = new ChooseFonts();
            LoadSettings();
            alarmList = new AlarmList();
            //labelTime.ForeColor = foregroundColorDialog.Color;
            //labelTime.BackColor = backgroundColorDialog.Color;
            SetVisibility(false);
            this.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
            this.Text += $"location: {this.Location.X}x{this.Location.Y}";
           
            alarm = new Alarm();
            GetNextAlarm();

            this.axWindowsMediaPlayer1.Visible = false;
        }

        void SetFontDirectory()
        {
            string location = Assembly.GetEntryAssembly().Location;       //получаем полный адрес исполняемого файла
            string path = Path.GetDirectoryName(location);      //из адреса извлекаем путь к файлу
            Directory.SetCurrentDirectory($"{path}\\..\\..\\Fonts");
        }
        void LoadSettings()
        {
            StreamReader sr = new StreamReader("settings.txt");
            List<string> settings = new List<string>();
            while (!sr.EndOfStream)
            {
                settings.Add(sr.ReadLine());
            }
            sr.Close();

            backgroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settings.ToArray()[0]));
            foregroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settings.ToArray()[1]));

            FontFile = settings.ToArray()[2];
            topmostToolStripMenuItem.Checked = bool.Parse(settings.ToArray()[3]);
            showDateToolStripMenuItem.Checked = bool.Parse(settings.ToArray()[4]);

            labelTime.Font = chooseFontDialog.SetFontFile(FontFile);
            labelTime.ForeColor = foregroundColorDialog.Color;
            labelTime.BackColor = backgroundColorDialog.Color;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            object run = rk.GetValue("Time");
            if (run != null) loadOnWindowsStartupToolStripMenuItem.Checked = true;
            rk.Dispose();
        }

        void SaveSettings()
        {
            StreamWriter sw = new StreamWriter("settings.txt");
            sw.WriteLine(backgroundColorDialog.Color.ToArgb()); //ToArgb() возвращает числовой код цвета
            sw.WriteLine(foregroundColorDialog.Color.ToArgb());
            sw.WriteLine(chooseFontDialog.FontFile.Split('\\').Last());
            sw.WriteLine(topmostToolStripMenuItem.Checked);
            sw.WriteLine(showDateToolStripMenuItem.Checked);
            sw.Close();
            Process.Start("notepad", "settings");
        }

        void GetNextAlarm()
        {
            List<Alarm> alarms = new List<Alarm>();
            foreach (Alarm item in alarmList.ListBoxAlarm.Items)
            {
                if (item.Time > DateTime.Now) alarms.Add(item);
            }
            if (alarms.Min() != null) alarm = alarms.Min();
            //if(alarms.Min() != null)
            //{
            //    alarm = alarms.Min();
            //}
            //List<TimeSpan> intervals = new List<TimeSpan>();
            //foreach(Alarm item in alarmList.ListBoxAlarm.Items)
            //{
            //    TimeSpan min = new TimeSpan(24,0,0);
            //    if(DateTime.Now - item.Time < min)
            //    {
            //        alarm = item;
            //    }
            //}
            Console.WriteLine(alarm);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (checkBoxShowDate.Checked) labelTime.Text += $"\n{DateTime.Today.ToString("dd.MM.yyyy")}";
            if (showWeekdayToolStripMenuItem.Checked)
            {
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            }
            int weekday = (int)DateTime.Now.DayOfWeek;
            weekday = weekday == 0 ? 6 : weekday - 1;
            if (
                alarm != null&&
                alarm.WeekDays[((int)DateTime.Now.DayOfWeek == 0 ? 6 : (int)DateTime.Now.DayOfWeek - 1)] == true &&
                DateTime.Now.Hour == alarm.Time.Hour &&
                DateTime.Now.Minute == alarm.Time.Minute &&
                DateTime.Now.Second == alarm.Time.Second
                )
            {
                //MessageBox.Show(alarm.Filename, "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Alarm:-----", alarm.ToString());
                PlayAlarm();
                GetNextAlarm();

            }
            if (DateTime.Now.Second == 0)
            {
                GetNextAlarm();
                Console.WriteLine("Minute");
            }

        }
        void PlayAlarm()
        {
            axWindowsMediaPlayer1.URL = alarm.Filename;
            axWindowsMediaPlayer1.settings.volume = 100;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Visible = true;
        }
        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None;
            this.ShowInTaskbar = visible;
            checkBoxShowDate.Visible = visible;
            btnHideControls.Visible = visible;
            axWindowsMediaPlayer1.Visible = false;
            //labelTime.BackColor = visible ? Color.Empty : Color.Black;
            //labelTime.ForeColor = visible ? Color.Empty : Color.DarkRed;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(false);
            notifyIconSystemTray.ShowBalloonTip(3, "Важная информация!", "Для того, чтобы вернуть как было, нужно кликнуть два раза по часам", ToolTipIcon.Info);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {

            SetVisibility(true);
        }

        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Текущее время:\n" + labelTime.Text;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topmostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostToolStripMenuItem.Checked;
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e)
        {
            showDateToolStripMenuItem.Checked = ((CheckBox)sender).Checked;
        }

        private void showControlsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(((ToolStripMenuItem)sender).Checked);
        }


        private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.ForeColor = foregroundColorDialog.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.BackColor = backgroundColorDialog.Color;
            }
        }

        private void fonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chooseFontDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.Font = chooseFontDialog.ChosenFont;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            alarmList.SaveAlarmsToFile("alarms.csv");
        }

        private void showDateToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxShowDate.Checked = ((ToolStripMenuItem)sender).Checked;
        }

        private void loadOnWindowsStartupToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            const string name = "Time";
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (loadOnWindowsStartupToolStripMenuItem.Checked)
            {
                reg.SetValue(name, Application.ExecutablePath);
            }
            else
            {
                reg.DeleteValue(name, false);
            }
            reg.Dispose();      //освободить ресурсы, занятые объектом 
            //reg.Flush();
            //reg.Close();
        }

        private void labelTime_MouseDown(object sender, MouseEventArgs e)
        {

            labelTime.Capture = false;
            Message mes = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref mes);
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            SetVisibility(true);
        }

        private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmList.ShowDialog(this);
            GetNextAlarm();

        }
        void SetPlayerInvisible(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }
        void SetPlayerInvisible(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            axWindowsMediaPlayer1.Visible = false;
        }
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
    }
}
