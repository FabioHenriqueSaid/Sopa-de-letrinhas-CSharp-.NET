/*
 * Representacao de algunas Operadores aritmeticos e de atribuicao
 * Se quiser ver a representacao completa,
 * Link : https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Sopa_de_Letrinhas.Operadores
{
    class Representacao
    {
        /* Como funciona a forma de Baskara ? 
        *  Link : https://brasilescola.uol.com.br/matematica/formula-bhaskara.htm
        *
        */
        public void Baskara()
        {
            //Representacao apenas do x´1 
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(x1);
        }

        public void OperadoresAtribuicao() {
            /* Os operadores de atribuicao são uteis para várias tarefas */
            ConcatenacaoString();
            Contadores();
            Acumuladores();
            OperadorTernario();
        }

        public void ConcatenacaoString() {
            string palavra = "Fábio";
            palavra += "Henrique";
            Console.Write(palavra);//Exibe Fábio Henrique
        }

        public void Contadores() {
            int total = 0;
            for (int contador = 1; contador <= 10; contador++) {
                total++;
            }
            Console.WriteLine(total);
        }

        public void Acumuladores() {
            double[] notas = {10.3,3.4,5.3,6.4,3.7,9.8};
            double total = 0;
            for (int contador = 0; contador < notas.Length; contador++)
            {
                total += notas[contador];
            }
            Console.WriteLine(total);//Exibe o total de notas;         
        }

        public void OperadorTernario() {
            string aprovado = "aprovado";
            string reprovado = "reprovado";
            double nota = 4;
            Console.WriteLine(nota >=7 ? aprovado : reprovado);
        }
        public void OperadoresRelacionais() {
            int numero1 = 5;
            bool maior = numero1 > 5;
            Console.WriteLine(maior);
        }

        public void OperadoresLogico() {
            int numero1 = 20;
            bool E = numero1 < 7 && numero1 == 6;
            Console.WriteLine(E);

            bool Ou = numero1 < 30 || numero1 == 31;
            Console.WriteLine(Ou);

            bool Nao = !(2 > 3);
            Console.WriteLine(Nao);
        }
    }
}
