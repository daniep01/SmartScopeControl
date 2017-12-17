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
    public partial class Form1 : Form
    {
         
        Scopes scopesClass = new Scopes();

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Startup");
            if (Properties.Settings.Default.ConnectOnStartup == true)
            {
                scopesClass.connect(Properties.Settings.Default.IP);
            }   
        }

        private void a_picture_Click(object sender, EventArgs e)
        {
            scopesClass.syncsendreceive("MONITOR A:\n");
            scopesClass.syncsendreceive("ScopeMode: Picture\n");
        }

        private void b_picture_Click(object sender, EventArgs e)
        {
            scopesClass.syncsendreceive("MONITOR B:\nScopeMode: Picture\n");
        }

        private void b_audio_Click(object sender, EventArgs e)
        {
            scopesClass.syncsendreceive("MONITOR B:\nScopeMode: AudioDbfs\n");
            //scopesClass.syncsendreceive("VIDEO OUTPUT:\nVideo mode: 720p50\n\n");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            scopesClass.disconnect();
        }

        private void a_wfm_Click(object sender, EventArgs e)
        {
            scopesClass.syncsendreceive("MONITOR A:\nScopeMode: ParadeRGB\n");
        }

        private void a_audio_Click(object sender, EventArgs e)
        {
            scopesClass.syncsendreceive("MONITOR A:\nScopeMode: AudioDbfs\n");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            scopesClass.syncsendreceive(textBox_msg.Text);
        }

        private void b_wfm_Click(object sender, EventArgs e)
        {
            scopesClass.syncsendreceive("MONITOR B:\nScopeMode: ParadeRGB\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("closing form 1");
            scopesClass.disconnect();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smart Scope Controller\nv1.0 20/11/2017\nPeter Daniel","Smart Scope", MessageBoxButtons.OK,MessageBoxIcon.Information );
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scopesClass.connected == false)
            {
                scopesClass.connect(Properties.Settings.Default.IP);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scopesClass.disconnect();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debugToolStripMenuItem.Checked = !debugToolStripMenuItem.Checked;
            this.textBox_msg.Visible = !textBox_msg.Visible;
            this.button_send.Visible = !button_send.Visible;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
