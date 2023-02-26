using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khrogaapp
{
    public partial class AddDilogBox : Form
    {
        int radioBtnState = 1;
        public AddDilogBox()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public string textB
        {
            get { return textBox1.Text; }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioBtnState = 2;
                Console.WriteLine(radioBtnState);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioBtnState = 1;
                Console.WriteLine(radioBtnState);

            }
        }
        public int getRadio
        {
            get { return radioBtnState; }
        }
    }
}

