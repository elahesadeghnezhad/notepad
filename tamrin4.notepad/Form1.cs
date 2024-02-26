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
    public partial class form1 : Form
    {
        string fn; //name and file path
        Boolean saveflag; //saved check
        public form1()
        {
            InitializeComponent();
        }

        private void SetBk(object sender, EventArgs e)
        {
            txtnotepad.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
                foreach (ToolStripMenuItem x in backColorToolStripMenuItem.DropDownItems)
            {
                if (x.Text == ((ToolStripMenuItem)sender).Text)
                    x.Checked = true;
                else
                    x.Checked = false;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            txtnotepad.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtnotepad.Font;
            fontDialog1.ShowDialog();
            txtnotepad.Font = fontDialog1.Font;
        }

        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText(@"E:\layout.txt", txtnotepad.BackColor.Name);
            newToolStripMenuItem_Click(null, null);
        }

        private void form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"E:\layout.txt"))
                {
                string s;
                s = System.IO.File.ReadAllText(@"E:\layout.txt");
                ToolStripMenuItem temp = new ToolStripMenuItem() ;
                temp.Text = s;
                SetBk(temp,null);
                }
            saveflag = false;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (fn == null)
            {
                DialogResult x;
                saveFileDialog1.DefaultExt = "txt";
                x=saveFileDialog1.ShowDialog();
                if (x == DialogResult.Cancel)
                    return;
                fn = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fn, txtnotepad.Text);
            saveflag = true;
            this.Text = fn;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveflag != true)
            {
                DialogResult r;
                r = MessageBox.Show("do you want to save?", "save...", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                txtnotepad.Text = "";
                this.Text = "my notepad";
                saveflag = true;
                fn = null;
            }
        }

        private void txtnotepad_TextChanged(object sender, EventArgs e)
        {
            saveflag = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
            openFileDialog1.Filter = "text File|*.txt|Document File|*.Doc|All File|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fn = openFileDialog1.FileName;
            txtnotepad.Text = System.IO.File.ReadAllText(fn);
            saveflag = true;
            this.Text = fn;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn = null;
            saveToolStripMenuItem_Click(null, null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtnotepad.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectedText = Clipboard.GetText();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectedText = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
            deleteToolStripMenuItem_Click(null, null);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFind fr = new FrmFind(this);
            fr.Show(this);
        }
        public Boolean findfunc(string s)
        {
            int i;
            i = txtnotepad.Text.IndexOf(s);
            if (i == -1)
            {
                MessageBox.Show("not found");
                return false;
            }
            else
            {
                txtnotepad.SelectionStart = i;
                txtnotepad.SelectionLength = s.Length;
                txtnotepad.Focus();
                return true;
            }
        }
        public Boolean findnextfunc(string s)
        {
            int i;
            i = txtnotepad.Text.IndexOf(s,txtnotepad.SelectionStart+1);
            if (i == -1)
            {
                MessageBox.Show("not found");
                return false;
            }
            else
            {
                txtnotepad.SelectionStart = i;
                txtnotepad.SelectionLength = s.Length;
                txtnotepad.Focus();
                return true;
            }
        }
    }
}