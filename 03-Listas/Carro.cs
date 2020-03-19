using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Listas
{
    public class Carro : IComparable<Carro>
    {
        public string Name { get; set; }
        public int Velocidade { get; set; }
        public string Cor { get; set; }

        //método que define a forma que será ordenada a lista
        public int CompareTo(Carro other)
        {
            // Método de comparação individual
            // usado pelo método Sort(Ordenar).

            //Determina a ordem relatia dos objetos s erem comparados
            //Sort(Ordenar) pela cor - alfabética e depois pela velocidade - crescente

            // Comparar as cores.
            int compare = string.Compare(this.Cor, other.Cor, true);

            // Se as cores forem iguais, coparar as valocidades.
            if (compare == 0)
            {
                compare = this.Velocidade.CompareTo(other.Velocidade);

                // Oredem Decrescente para velocidde.
                compare = -compare;
            }

            return compare;
        }
    }
}
