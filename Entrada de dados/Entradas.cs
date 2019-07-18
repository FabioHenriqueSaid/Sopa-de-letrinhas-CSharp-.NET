using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sopa_de_Letrinhas.Entrada_de_dados
{
    class Entradas
    {
        public void Demonstracao() {            
            int n1 = int.Parse(Console.ReadLine());//Console.ReadLine lê os dados em forma de String, por consequencia disso é necessario fazer uma conversao entre tipos.
            Console.WriteLine(n1);

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));

            
            Split();//Usando Split
        }
        public void Split() {        
            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine(" Nome: {0}\n Sexo: {1}\n Idade: {2}\n Altura: {3}\n "
                ,nome , sexo , idade , altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}