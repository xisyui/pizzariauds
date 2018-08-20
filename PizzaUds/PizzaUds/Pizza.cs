using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaUds
{
    public class Pizza
    {
        private string tamanho, sabor, personalizacao;
        private int tempo;
        private double valor;
        public double getValor()
        {
            return valor;
        }
        public int getTempo()
        {
            return tempo;
        }
        public string getTamanho()
        {
            return tamanho;
        }
        public string getSabor()
        {
            return sabor;
        }
        public string getPersonalizacao()
        {
            return personalizacao;
        }
        public void setTempo(int tempo)
        {
            this.tempo = tempo;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public void setTamanho(String tamanho)
        {
            this.tamanho = tamanho;
        }
        public void setSabor(String sabor)
        {
            this.sabor = sabor;
        }
        public void setPersonalizacao(String personalizacao)
        {
            this.personalizacao = personalizacao;
        }
    }
}
