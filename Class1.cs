using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Negozio
    {
        private string nome;
        private string indirizzo;
        private string citta;
        private int civico;


    public Negozio(string nome, string indirizzo, string citta, int civico) { 

            this.nome = nome;
            this.indirizzo = indirizzo;
            this.citta = citta;
            this.civico = civico;
        }

        public void setNomeNegozio(string nome)
        {
            this.nome = nome;
        }


        public string getNome()
        {
            return nome;
        }

        public void setIndirizzoNegozio(string indirizzo)
        {
            this.indirizzo = indirizzo;
        }

        public string getIndirizzo(){
            return indirizzo;
        }

        public void setCittaNegozio(string citta)
        {
            this.citta = citta;
        }


        public string getCitta()
        {
            return citta;
        }

        public void setCivico(int civico)
        {
            this.civico = civico;

        }
      
        public int getCivico()
        {
            return civico;
        }


    }
}
