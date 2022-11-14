using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ScrittoreVisore.Mosconi
{
    public class Scrittore
    {
        //attributi
        private string utente;
        private Visualizzatore visualizzatore;

        //costruttori
        public Scrittore(Visualizzatore visualizzatore0)
        {
            visualizzatore = visualizzatore0;
        }

        //metodi
        public string Utente
        {
            set 
            {
                utente = value;
            }

            get
            {
                return utente;
            }
        }

        public Visualizzatore visualizzatore0
        {
            set
            {
                visualizzatore0 = value;
            }

            get
            {
                return visualizzatore0;
            }
        }

        public void aggiungiTesto(string testo)
        {
            visualizzatore.visualizza(testo, Utente);
        }

        public void setGrassetto(bool turn)
        {
            visualizzatore.Grassetto=turn;
        }

        public void setCorsivo(bool turn)
        {
            visualizzatore.Corsivo = turn;
        }
        public void setSottolineato(bool turn)
        {
            visualizzatore.Sottolineato = turn;
        }
        public void setColore(Color turn)
        {
            visualizzatore.Colore = turn;
        }
    }
}
