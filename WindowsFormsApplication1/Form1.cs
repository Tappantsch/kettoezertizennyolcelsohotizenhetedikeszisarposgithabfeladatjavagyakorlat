using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           List<Hiba> hibak = new List<Hiba>();
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(richTextBox1.Text))
            {
                hibak.Add(new Hiba(textBox1.Text, textBox2.Text, richTextBox1.Text));
                textBox1.Text = null;
                textBox2.Text =null;
                richTextBox1.Text =null;
            }
            else {
                MessageBox.Show("ajjajj ures valami mezo",
"valamelyik mezovel baj van ajj ajj");
            }
            
        }

    }
}
