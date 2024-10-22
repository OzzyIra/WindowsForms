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

namespace Clock
{
    public partial class MainForm : Form
    {
        ColorDialog backgroundColorDialog;
        ColorDialog foregroundColorDialog;
        ChooseFonts chooseFontDialog;

        public MainForm()
        {
            InitializeComponent();
            SetFontDirectory();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();
            chooseFontDialog = new ChooseFonts();
            SetVisibility(false);
            this.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
            this.Text += $"location: {this.Location.X}x{this.Location.Y}";
        }

        void SetFontDirectory()
        {
            string location = Assembly.GetEntryAssembly().Location;       //получаем полный адрес исполняемого файла
            string path = Path.GetDirectoryName(location);      //из адреса извлекаем путь к файлу
            Directory.SetCurrentDirectory($"{path}\\..\\..\\Fonts");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (checkBoxShowDate.Checked) labelTime.Text += $"\n{DateTime.Today.ToString("dd.MM.yyyy")}";
        }
        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None;
            this.ShowInTaskbar = visible;
            checkBoxShowDate.Visible = visible;
            btnHideControls.Visible = visible;
            labelTime.BackColor = visible ? Color.Empty : Color.Black;
            labelTime.ForeColor = visible ? Color.Empty : Color.DarkRed;
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

        private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxShowDate.Checked = ((ToolStripMenuItem)sender).Checked;
        }

        private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e)
        {
            showDateToolStripMenuItem.Checked = ((CheckBox)sender).Checked;
        }

        private void showControlsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(((ToolStripMenuItem)sender).Checked);
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            if(!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.ForeColor = foregroundColorDialog.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(backgroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.BackColor = backgroundColorDialog.Color;
            }
        }

        private void fonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(chooseFontDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.Font = chooseFontDialog.ChosenFont;
            }
        }
        
    }
}
