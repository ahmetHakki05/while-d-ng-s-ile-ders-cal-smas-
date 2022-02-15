using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı, kacTane;
            sayı = 0;
            kacTane = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            while (sayı < kacTane) 
            {            
                sayı++;
                listBox1.Items.Add("ahmet hakkı");
            }
        }
    }
}
