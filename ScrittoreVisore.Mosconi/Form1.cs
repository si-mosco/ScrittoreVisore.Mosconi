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
    }
}
