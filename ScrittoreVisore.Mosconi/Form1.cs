using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrittoreVisore.Mosconi
{
    public partial class Form1 : Form
    {
        private Visualizzatore vis;
        private Scrittore scr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scr = new Scrittore(vis);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                scr.Nome = textBox1.Text;

                scr.Testo = textBox2.Text;

                FontStyle f;
                Font font = richTextBox2.SelectionFont;
                if (font != null)
                {
                    f = font.Style;
                    if (comboBox1.Text == "Grassetto")
                        f ^= FontStyle.Bold;
                    else if (comboBox1.Text == "Corsivo")
                        f ^= FontStyle.Italic;
                    else if (comboBox1.Text == "Sottolineato")
                        f ^= FontStyle.Underline;

                    richTextBox2.SelectionFont = new Font(font, f);

                    if (comboBox2.Text == "Nero")
                        richTextBox2.SelectionColor = Color.Black;
                    else if (comboBox2.Text == "Rosso")
                        richTextBox2.SelectionColor = Color.Red;
                    else if (comboBox2.Text == "Arancione")
                        richTextBox2.SelectionColor = Color.Orange;
                    else if (comboBox2.Text == "Giallo")
                        richTextBox2.SelectionColor = Color.Yellow;
                    else if (comboBox2.Text == "Verde")
                        richTextBox2.SelectionColor = Color.Green;
                    else if (comboBox2.Text == "Azzurro")
                        richTextBox2.SelectionColor = Color.Cyan;
                    else if (comboBox2.Text == "Blu")
                        richTextBox2.SelectionColor = Color.Blue;
                    else if (comboBox2.Text == "Viola")
                        richTextBox2.SelectionColor = Color.Purple;
                    else if (comboBox2.Text == "Rosa")
                        richTextBox2.SelectionColor = Color.Pink;

                    richTextBox2.AppendText(scr.Nome + ": " + scr.Testo + "\n");
                }

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
                MessageBox.Show("Inserire tutti i Valori");
        }
    }
}
