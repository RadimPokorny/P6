using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int let = Convert.ToInt32(textBox1.Text);


            DateTime When = dateTimePicker1.Value;


            DateTime Now = DateTime.Now;


            

            

            


            int doty_driv = When.DayOfYear;
            int doty_ted = Now.DayOfYear;


            

            



        }
    }
}
