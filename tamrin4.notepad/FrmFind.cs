using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin4.notepad
{
    public partial class FrmFind : Form
    {
        form1 frmmain;
        public FrmFind(form1 frm)
        {
             frmmain= frm;
            InitializeComponent();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            frmmain.findfunc(txtfind.Text);
        }

        private void btnfindnext_Click(object sender, EventArgs e)
        {
            frmmain.findnextfunc(txtfind.Text);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
