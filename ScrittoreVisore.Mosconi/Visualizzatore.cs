using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ScrittoreVisore.Mosconi
{
    public class Visualizzatore
    {
        //attributi
        private bool grassetto;
        private bool corsivo;
        private bool sottolineato;
        private Color colore;
        private RichTextBox richtextbox;

        //costruttori
        public Visualizzatore(RichTextBox Richtextbox0)
        {
            Richtextbox = Richtextbox0;
        }

        //metodi
        public bool Grassetto
        {
            set
            {
                grassetto = value;
            }

            get
            {
                return grassetto;
            }
        }
        public bool Corsivo
        {
            set
            {
                corsivo = value;
            }

            get
            {
                return corsivo;
            }
        }
        public bool Sottolineato
        {
            set
            {
                sottolineato = value;
            }

            get
            {
                return sottolineato;
            }
        }
        public Color Colore
        {
            set
            {
                colore = value;
            }

            get
            {
                return colore;
            }
        }
        public RichTextBox Richtextbox
        {
            set
            {
                richtextbox = value;
            }

            get
            {
                return richtextbox;
            }
        }

        public void visualizza(string testo, string utente)
        {
            FontStyle f;
            Font font = richtextbox.SelectionFont;
            if (font != null)
            {
                f = font.Style;
                if (Grassetto)
                    f ^= FontStyle.Bold;
                else if (Corsivo)
                    f ^= FontStyle.Italic;
                else if (sottolineato)
                    f ^= FontStyle.Underline;

                richtextbox.SelectionFont = new Font(font, f);

                richtextbox.SelectionColor = colore;

                richtextbox.AppendText(utente + ": " + testo + "\n");
            }
        }
        
    }
}
