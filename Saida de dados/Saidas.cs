using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sopa_de_Letrinhas.Saida_de_dados
{
    class Saidas
    {
        int _idade = 22;
        double _saldo = 20;
        string _nome = "Fábio";

        public void Demonstracao()
        {
            double saldo = 10;
            Console.WriteLine(saldo.ToString("F2"));//Exibe com duas casas decimais

            //Trata a representacao de forma universal ou seja exibe o valor com '.' e não com ','
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }

        public void Interpolacao()
        {
            Console.WriteLine($"{_nome} tem {_idade} anos e saldo de {_saldo:F2}");//Não é possivel usar CultureInfo.InvariantCulture aqui.
        }

        public void Placeholders()
        {
            Console.WriteLine("{0} tem {1} anos e saldo de {2:F2}", _nome, _idade, _saldo);//Não é possivel usar CultureInfo.InvariantCulture aqui.
        }

        public void Concatenacao() {
            Console.WriteLine(_nome + " tem "+ _idade + "anos e saldo de "+ _saldo.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

