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
        string input1 = "A1237B1227C";
        public Form_Training()
        {
            InitializeComponent();
        }

        private void Form_Training_Load(object sender, EventArgs e)
        {

        }

        private void button_Press_Click(object sender, EventArgs e)
        {
            int count = 1;
            string ans1 = string.Empty;
            string ans2 = string.Empty;
            if (input1[0] == 'A')
            {
                while (input1[count] != 'B')
                {
                    ans1 += input1[count];
                    count++;
                }
                count++;
                while (input1[count] != 'C')
                {
                    ans2 += input1[count];
                    count++;
                }
            }
            MessageBox.Show((Convert.ToInt64(ans1) + Convert.ToInt64(ans2)).ToString());
        }
    }
}
