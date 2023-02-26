using System;
using System.Collections;
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

    public partial class ViewDialogBox : Form
    {
        string[] Mkan2o3ad = { "diab", "brazlian coffie m7tt lrml", "mac stanly /mac lshtby ", "mashro3 yassmin", "gleem bay", "the walk", "elmshrbya", "mr monkey", "carfor", "carfour", "n3n3", "murano" };
        ArrayList Mkan2o3add = new ArrayList();
        ArrayList mkanakll = new ArrayList();
        string[] Mkanakl = { "pizza nour", "3lso5n", "abo noaser", "abo rabe3", "gad lrml", "country hills", "gemy", "mshawyy", "3rbyt kbda", "gad stanly" };
        public ViewDialogBox()
        {
            InitializeComponent();
            for (int i = 0; i < Mkan2o3ad.Length; i++)
            {
                Mkan2o3add.Add( Mkan2o3ad[i]);
            }
            for (int i = 0; i < Mkanakl.Length; i++)
            {
                mkanakll.Add(Mkanakl[i]);
            }

            for (int i = 0; i < Mkan2o3ad.Length; i++)
            {
                akll.Items.Add(Mkan2o3add[i]);
            }
            for (int i = 0; i < Mkanakl.Length; i++)
            {
                cafe.Items.Add(mkanakll[i]);
            }
        }
       
        private void ok_Click(object sender, EventArgs e)
        {
           this.DialogResult= DialogResult.OK;
            this.Close();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddDilogBox dBox = new AddDilogBox();
            DialogResult dresut = dBox.ShowDialog();
            if (dresut == DialogResult.OK)
            {
                if (dBox.getRadio==2)
                {
                   cafe.Items.Add(dBox.textB);
                    Mkan2o3add.Add(dBox.textB);
                }





                else if (dBox.getRadio == 1)
                {

                    akll.Items.Add(dBox.textB);
                    mkanakll.Add(dBox.textB);

                }
            }
        }
    }
}
