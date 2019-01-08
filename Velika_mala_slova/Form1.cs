using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Velika_mala_slova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void svaVelikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void premaPravopisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int duljina = richTextBox1.SelectionLength;
            int pocetak = richTextBox1.SelectionStart;
            bool pocetakRecenice = false;
            StringBuilder rezultantniTekst = new StringBuilder();

            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();

            richTextBox1.Select(pocetak, duljina);
            string pom = richTextBox1.SelectedText;
            
            
            if (pocetak == 0)
            {
                pocetakRecenice = true;
            }

            for (int i = 0; i < duljina; i++)
            {
                char slovo = pom[i];
                
                if (Char.IsLetterOrDigit(slovo) && pocetakRecenice == true)
                {
                    rezultantniTekst.Append(Char.ToUpper(slovo));
                    pocetakRecenice = false;
                }
                else if (slovo == ' ')
                {
                    rezultantniTekst.Append(" ");
                }
                else
                {
                    rezultantniTekst.Append(slovo);
                    if (slovo == '.' || slovo == '!' || slovo == '?')
                    {
                        pocetakRecenice = true;
                    }
                }
            }

            richTextBox1.Select(pocetak, duljina);
            richTextBox1.SelectedText = rezultantniTekst.ToString();
            
        }

        
        private void button1_Click(object sender, EventArgs e) // IMPORT
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e) // EXPORT
        {
            SaveFileDialog save = new SaveFileDialog();

            save.DefaultExt = "*.txt";
            save.Filter = "TXT Files|*.txt";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                File.WriteAllText(save.FileName, richTextBox1.Text);
            }
        }
    }
}
