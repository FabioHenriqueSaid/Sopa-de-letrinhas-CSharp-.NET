using Sopa_de_Letrinhas.Saida_de_dados;
using Sopa_de_Letrinhas.Tipos_de_dados;
using System;

namespace Sopa_de_Letrinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Saidas s = new Saidas();
            s.Demonstracao();
            s.Placeholders();
            s.Interpolacao();
            s.Concatenacao();
        }
    }
}
