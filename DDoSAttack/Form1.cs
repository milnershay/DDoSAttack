using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DDoSAttack
{
    public partial class Form1 : Form
    {
        static decimal opend = 0;
        int[] procs;
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // do nothing
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opend = numericUpDown1.Value;
            procs = new int[(int)opend];
            for (int i = 0; i < opend; i++)
            {
                Process.Start("msedge.exe", textBox1.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] tabs = Process.GetProcessesByName("msedge");
            foreach (Process proc in tabs)
            {
                try
                {
                    proc.Kill();
                    proc.WaitForExit(100);
                }
                catch (Exception) { }
            }
        }
    }
}
