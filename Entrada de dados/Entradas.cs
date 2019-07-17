using System;
using System.Collections.Generic;
using System.Text;

namespace Sopa_de_Letrinhas.Entrada_de_dados
{
    class Entradas
    {
        public void Demonstracao() {
            string palavra;
            Console.Write("Digite uma palavra:");
            palavra = Console.ReadLine(); //Lê até encontrar uma quebra de linha
            Console.WriteLine(palavra);
            Split();
        }
        public void Split() {
            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            string[] vetor = Console.ReadLine().Split(' ');
            Console.WriteLine(vetor[0],vetor[1],vetor[2],vetor[3]);

        }
    }
}
