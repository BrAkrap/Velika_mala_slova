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
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
            
            // provjera za točku
            if (richTextBox1.SelectedText.Contains("."))
            {
                string[] podjela = richTextBox1.SelectedText.Split('.');
                int pom = 0;
                for (int i = 0; i < podjela.Length; ++i)
                {
                    // provjera da li riječ počinje sa "nj", "dž" ili "lj"
                    if (podjela[i].Substring(0,2).Equals("dž") || podjela[i].Substring(0, 2).Equals("nj") 
                        || podjela[i].Substring(0, 2).Equals("lj"))
                    {
                        
                        richTextBox1.SelectedText.Substring(0, 2).Replace(richTextBox1.SelectedText.Substring(0, 2), richTextBox1.SelectedText.Substring(pom, 2).ToUpper());
                        //richTextBox1.SelectedText.Substring(i * podjela[i - 1].Length, 2).ToUpper();
                    }
                    else
                    {
                        richTextBox1.SelectedText.Substring(0, 2).Replace(richTextBox1.SelectedText.Substring(0, 2), richTextBox1.SelectedText.Substring(pom, 1).ToUpper());
                        //richTextBox1.SelectedText.Substring(i * podjela[i - 1].Length, 1).ToUpper();
                    }
                    pom += podjela[i].Length;
                }   
            }
            // provjera za uskličnik
            if (richTextBox1.SelectedText.Contains("!"))
            {
                string[] podjela = richTextBox1.SelectedText.Split('!');
                int pom = 0;
                for (int i = 0; i < podjela.Length; ++i)
                {
                    // provjera da li riječ počinje sa "nj", "dž" ili "lj"
                    if (podjela[i].Substring(0, 2).Equals("dž") || podjela[i].Substring(0, 2).Equals("nj")
                        || podjela[i].Substring(0, 2).Equals("lj"))
                    {

                        richTextBox1.SelectedText.Substring(0, 2).Replace(richTextBox1.SelectedText.Substring(0, 2), richTextBox1.SelectedText.Substring(pom, 2).ToUpper());
                        //richTextBox1.SelectedText.Substring(i * podjela[i - 1].Length, 2).ToUpper();
                    }
                    else
                    {
                        richTextBox1.SelectedText.Substring(0, 2).Replace(richTextBox1.SelectedText.Substring(0, 2), richTextBox1.SelectedText.Substring(pom, 1).ToUpper());
                        //richTextBox1.SelectedText.Substring(i * podjela[i - 1].Length, 1).ToUpper();
                    }
                    pom += podjela[i].Length;
                }
            }
            // provjera za upitnik
            if (richTextBox1.SelectedText.Contains("?"))
            {
                string[] podjela = richTextBox1.SelectedText.Split('?');
                int pom = 0;
                for (int i = 0; i < podjela.Length; ++i)
                {
                    // provjera da li riječ počinje sa "nj", "dž" ili "lj"
                    if (podjela[i].Substring(0, 2).Equals("dž") || podjela[i].Substring(0, 2).Equals("nj")
                        || podjela[i].Substring(0, 2).Equals("lj"))
                    {

                        richTextBox1.SelectedText.Substring(0, 2).Replace(richTextBox1.SelectedText.Substring(0, 2), richTextBox1.SelectedText.Substring(pom, 2).ToUpper());
                        //richTextBox1.SelectedText.Substring(i * podjela[i - 1].Length, 2).ToUpper();
                    }
                    else
                    {
                        richTextBox1.SelectedText.Substring(0, 2).Replace(richTextBox1.SelectedText.Substring(0, 2), richTextBox1.SelectedText.Substring(pom, 1).ToUpper());
                        //richTextBox1.SelectedText.Substring(i * podjela[i - 1].Length, 1).ToUpper();
                    }
                    pom += podjela[i].Length;
                }
            }
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
                richTextBox1.SaveFile(save.FileName);
            }
        }
    }
}
