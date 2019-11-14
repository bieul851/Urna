using System;

namespace UrnaEletronica
{
    public class Candidato
    {

        public int Numero { get; set; }
        public String Nome { get; set; }


        public Candidato(){ }
        public Candidato(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public override string ToString()
        {
            return "Numero: "+Numero +", Nome: "+ Nome;
        }
    }
}
