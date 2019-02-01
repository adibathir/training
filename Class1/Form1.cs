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
            string inputA = string.Empty;
            string inputB = string.Empty;
            int ans=0;
            int ans2=0;
            string ans3 = string.Empty;
            if (input1[0] == 'A')
                while (input1[count] != 'B')
                {
                    inputA += input1[count];
                    ans = Convert.ToInt16(inputA);
                    count++;
                }

            count++;

                while (input1[count] != 'C')
                {
                inputB += input1[count];
                ans2 = Convert.ToInt16(inputB);
                count++;
                }

            ans3 = (ans + ans2).ToString();
            MessageBox.Show(ans3);
        }
    }
}
