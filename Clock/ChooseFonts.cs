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
using System.Drawing.Text;

namespace Clock
{
    public partial class ChooseFonts : Form
    {
        public Font ChosenFont { get; private set; }
        public string FontFile { get; private set; }
        public ChooseFonts()
        {
            InitializeComponent();
            LoadFonts();
        }
        public ChooseFonts(string fontFile):this()
        {
            SetFontFile(fontFile);
        }
        void LoadFonts()
        {
            string[] fonts = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.ttf").ToArray();
            for(int i =0;i<fonts.Length;i++)
            {
                fonts[i] = fonts[i].Split('\\').Last();
            }
            comboBoxFonts.Items.AddRange(fonts);
            comboBoxFonts.SelectedIndex = 0;
        }
        public Font SetFontFile(string fontFile)
        {
            FontFile = fontFile;
            comboBoxFonts.SelectedIndex = comboBoxFonts.Items.IndexOf(FontFile);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFile);
            return new Font(pfc.Families[0], 36);
        }

        private void comboBoxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            FontFile = $"{Directory.GetCurrentDirectory()}\\{comboBoxFonts.SelectedItem.ToString()}";
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFile);
            Font font = new Font(pfc.Families[0], 36);
            labelExample.Font = font;
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChosenFont = new Font(labelExample.Font.FontFamily, labelExample.Font.Size);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
