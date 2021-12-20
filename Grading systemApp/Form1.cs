using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_systemApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);

                if(x<=49){
                    label4.Text = ("F");                  
}
                else if (x <= 59)
                {
                    label4.Text = ("D");
                }

                else if (x <= 69)
                {
                    label4.Text = ("C");
                }


                else if (x <= 79)
                {
                    label4.Text = ("B");
                }


                else if (x >= 89 || x == 100)
                {
                    label4.Text = ("A");
                }

               if(x >100)
               {
                   label4.Text = "Invaild number";
               
               };

                
            }


            
}



        }
    

