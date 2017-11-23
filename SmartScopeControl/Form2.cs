using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartScopeControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = this.textBox1.Text;
            Properties.Settings.Default.ConnectOnStartup = this.checkBox1.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = Properties.Settings.Default.IP;
            this.checkBox1.Checked = Properties.Settings.Default.ConnectOnStartup;
        }
    }
}
