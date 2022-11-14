﻿using System;
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
        public Visualizzatore vis;
        public Scrittore scr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.ReadOnly = true;
            comboBox1.DropDownStyle = comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            vis = new Visualizzatore(richTextBox2);
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
                scr.Utente = textBox1.Text;

                //stile
                if (comboBox1.Text == "Grassetto")
                    vis.Grassetto=true;
                else if (comboBox1.Text == "Corsivo")
                    vis.Corsivo = true;
                else if (comboBox1.Text == "Sottolineato")
                    vis.Sottolineato = true;

                //colori
                if (comboBox2.Text == "Nero")
                    vis.Colore = Color.Black;
                else if (comboBox2.Text == "Rosso")
                    vis.Colore = Color.Red;
                else if (comboBox2.Text == "Arancione")
                    vis.Colore = Color.Orange;
                else if (comboBox2.Text == "Giallo")
                    vis.Colore = Color.Yellow;
                else if (comboBox2.Text == "Verde")
                    vis.Colore = Color.Green;
                else if (comboBox2.Text == "Azzurro")
                    vis.Colore = Color.Cyan;
                else if (comboBox2.Text == "Blu")
                    vis.Colore = Color.Blue;
                else if (comboBox2.Text == "Viola")
                    vis.Colore = Color.Purple;
                else if (comboBox2.Text == "Rosa")
                    vis.Colore = Color.Pink;

                scr.aggiungiTesto(textBox2.Text);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
                MessageBox.Show("Inserire tutti i Valori");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
