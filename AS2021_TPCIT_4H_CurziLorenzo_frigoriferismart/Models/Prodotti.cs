using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_TPCIT_4H_CurziLorenzo_frigoriferismart.Models
{
    class Prodotti
    {
        string _codice; //codice identificativo
        string _descrizione; //descrizione breve
        int _dataScadenza; //data di scadenza
        double _calorie; //calorie del prodotto
        double _quantita; //quantità del prodotto presente nel frigorifero
        static int nProdotti = 0; //variabile statica che conta quanti prodotti vengono creati

        public string Codice { get => _codice; set => _codice = value; }

        public string Descrizione { get => _descrizione; set => _descrizione = value; }

        public int DataScadenza { get => _dataScadenza; set => _dataScadenza = value; }

        public double Calorie { get => _calorie; set => _calorie = value; }

        public double Quantita { get => _quantita; set => _quantita = value; }


        //costruttore default
        //ogni volta che richiamo un costruttore richiamo il metodo COntaProdotti in modo da poter contare gli oggetti creati
        public Prodotti () 
        {
            ContaProdotti();
        }

        public Prodotti (string codice, string descrizione, int dataScadenza, double calorie, double quantita)
        {
            ContaProdotti();

            Codice = codice;
            Descrizione = descrizione;
            DataScadenza = dataScadenza;
            Calorie = calorie;
            Quantita = quantita;
        }

        //metodo che conta gli oggetti Prodotti creati
        private void ContaProdotti ()
        {
            //aggiorno la variabile statica
            nProdotti++;
        }

        //Metodo che visualizza tutti i prodotti presenti all'interno del frigorifero
        public string VisualizzaProdotti()
        {
            return $"La quantità del prodotto {Descrizione} con codice {Codice}, data di scadenza {DataScadenza} e calorie {Calorie} è: {Quantita}"; 
        }

        public string VisualizzaProdottiScaduti()
        {
            string retVal = "";
            if (this.DataScadenza < 2020)
                retVal = $"Il prodotto {Descrizione} con codice {Codice} è scaduto";
            else
                retVal = $"Il prodotto {Descrizione} con codice {Codice} non è scaduto";
            return retVal;
        }

        public bool Calcoloprodotti(string codice)
        {
            bool retVal = false;
            
            if(this.Codice == codice)
                retVal = true;

            return retVal;
        }

        public override string ToString()
        {
            return $"Prodotto {Descrizione} con codice {Codice}, data di scadenza {DataScadenza}, Calorie {Calorie} e quantità {Quantita}";
        }
    }
}
