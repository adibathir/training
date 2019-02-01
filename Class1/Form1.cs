using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1
{
    public partial class Form_Training : Form
    {
        public Form_Training()
        {
            InitializeComponent();
        }

        private void Form_Training_Load(object sender, EventArgs e)
        {
           
        }

        private void button_Press_Click(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt16(textBox1.Text);
                int B = Convert.ToInt16(textBox2.Text);
                textBox3.Text = ((A / Ba) + (A % B) / 2.0).ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());

            }
        }
    }
}
