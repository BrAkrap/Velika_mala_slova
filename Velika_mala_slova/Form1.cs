using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velika_mala_slova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string SvaVelika()
        {
            return richTextBox1.SelectedText.ToUpper();
        }

        /*
        public string PremaPravopisu()
        {
            richTextBox1.SelectedText.ToLowerInvariant();
            if (richTextBox1.SelectedText.Contains("."))
            {
                string[] podjela = richTextBox1.SelectedText.Split('.');
                for (int i = 0; i < podjela.Length; ++i)
                {
                    richTextBox1.SelectedText.Substring(i, podjela[i].Length).ToLowerInvariant();
                }
                
            }
            return "";
        }
        */

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
