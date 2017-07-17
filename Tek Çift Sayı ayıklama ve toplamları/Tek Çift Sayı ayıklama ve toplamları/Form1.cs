using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplamtek = 0;
        int toplamçift = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            
            sayı = Convert.ToInt32(textBox1.Text);            
            for (int i = 2; i <= sayı;i = i + 2 )
            {
                toplamçift = toplamçift + i;
                label7.Text = toplamçift.ToString();
                listBox1.Items.Add(i);
            }
            for (int i = 1; i <= sayı; i+=2) 
            {
                toplamtek = toplamtek + i;
                label4.Text = toplamtek.ToString();
                listBox2.Items.Add(i);

            }
                   
            
        }
    }
}
