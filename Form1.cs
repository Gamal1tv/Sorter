using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["formNum"];
            if (form == null)
            {
                formNum instanceN = new formNum();
                instanceN.Show();
            }
        }

        private void btnLetters_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["formLetters"];
            if (form == null)
            {
                formLetters instanceL = new formLetters();
                instanceL.Show();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["formColors"];
            if (form == null)
            {
                formColors instanceC = new formColors();
                instanceC.colorSelection = cboxColor.Text;
                instanceC.Show();
            }
        }
    }
}
