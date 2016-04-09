using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAge
{
    public partial class Form1 : Form
    {
        private int age = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            age = int.Parse(age_txt.Text);
            try
            {
                if (age <= 0)
                {
                    throw new AgeException();
                }
                MessageBox.Show("Your age is " + age.ToString());

            }
            catch (AgeException nje)
            {
                MessageBox.Show(nje.Message);

            }
        }
    }
    public class AgeException : Exception
    {
        public AgeException()
            :base(" Ooop !! Age must be greater than 0! Please re-enter !"){
        }
    }
}       
        
