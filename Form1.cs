using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace khrogaapp
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string[] Mkan2o3ad = {"diab", "brazlian coffie m7tt lrml", "mac stanly /mac lshtby ", "mashro3 yassmin", "gleem bay", "the walk", "elmshrbya", "mr monkey", "carfor", "carfour", "n3n3", "murano"};
        ArrayList Mkan2o3add = new ArrayList();
        ArrayList mkanakll = new ArrayList();
        string[] Mkanakl =  { "pizza nour", "3lso5n", "abo noaser", "abo rabe3", "gad lrml", "country hills", "gemy", "mshawyy", "3rbyt kbda", "gad stanly" };



        public Form1()
        {
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {


            int mkan2o3ad = rnd.Next(Mkan2o3ad.Length);
            label2.Text = Mkan2o3ad[mkan2o3ad];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mkanakl = rnd.Next(Mkanakl.Length);
            label1.Text = Mkanakl[mkanakl];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDilogBox dBox = new AddDilogBox();
            DialogResult dresut = dBox.ShowDialog();
            if (dresut == DialogResult.OK)
            {
                if (dBox.getRadio == 1)
                {

                    Mkan2o3ad.Append(dBox.textB);

                }
                else if (dBox.getRadio == 2)
                {

                    Mkanakl.Append(dBox.textB);

                }
            }
        }
        public string[] m7lAkl
        {
            get
            {
                return Mkanakl;
            }
        }
        public string[] cafe
        {
            get
            {
                return Mkan2o3ad;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewDialogBox ListBox= new ViewDialogBox();
            DialogResult dialogResult= ListBox.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }
        }
    }
}