using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternBuilderStarter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int sizeStitches = Int32.Parse(sizeStitchesInput.Text);
            
            int goalStitches = 0; //use this to hold formula result

            int widthStitches = Int32.Parse(widthStitchesInput.Text);

            int goalWidth = Int32.Parse(goalWidthInput.Text);

            goalStitches = (widthStitches * goalWidth)/ sizeStitches;

            

           

            //get the othe rinputs and do a similar parse

            //calculate the goal number of stitches (use formula)

            //output the goal stitches in the output label

            outputLabel.Text = goalStitches.ToString();
        }
    }
}
