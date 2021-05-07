using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * This application takes your weight on earth and converts it to what your weight would be on mars. 
 * Only numbers are allowed for the input. Exception handling is in place to insure that the correct 
 * input it received
*/

namespace E3_WeightOnMars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //exception handling to prevent error by incorrect user input
            try
            {
                double MWeight;

                //variable set to the parsed double from string
                double EWeight = double.Parse(tb_EWeight.Text); 

                if (EWeight <= 0)
                {
                    MessageBox.Show("Please input a weight greater than 0");
                    tb_EWeight.Text = "";
                   
                    
                }
                else
                {
                    //conversion from earth weight to mars weight
                    MWeight = EWeight * .38;

                    //sets the text of the textbox to the mars weight
                    tb_MWeight.Text = MWeight.ToString("n3");
                }
                
            }
            catch
            {
                //exception for user entering something other than numbers
                MessageBox.Show("Your weight is not an algebraic expression. Enter numbers only");
            }


        }

        //In the event of wanting to convert multiple weights, this will clear the form
        private void tb_EWeight_TextChanged(object sender, EventArgs e)
        {
            tb_MWeight.Text = "";
        }
    }
}
