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
        Alarm alarm;
        public AddAlarm()
        {
            InitializeComponent();
            alarm = new Alarm();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxExectDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked;
        }
    }
}
