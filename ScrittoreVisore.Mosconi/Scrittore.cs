using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
