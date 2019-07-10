using System;
using System.Collections.Generic;
using System.Text;

namespace Sopa_de_Letrinhas.Tipos_de_dados
{
    class TiposBasicos
    {
        /*   
         *  Alguns tipos basicos do CSharp e do DotNet 
         *
         */

        public void TiposCSharp()
        {
            sbyte numero = 10;
            float numero2 = 10.2f;
            bool numero3 = true;
            long numero4 = 232323;
            char genero = 'M';
        }

        public void TiposDotNet()
        {
            SByte numero = 10;
            Single numero2 = 10.2f;
            Boolean numero3 = false;
            Int64 numero4 = 10;
            Char genero = 'M';
        }

        public void Overflow()
        {
            /* Se estourar o limite que o tipo suporta
             * entao é  atribuido o valor oposto do limite
             * link:https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/built-in-types-table
             */
            sbyte representacaoCSharp = 127;
            representacaoCSharp++;

            Console.WriteLine(representacaoCSharp);// Exibe -128
        }

        public void Curiosidades()
        {
            char letra = '\u00C8';// É possivel representar um caractere unicode
            Console.WriteLine(letra);

            char letra2 = '\u00AE';
            Console.WriteLine(letra2);
            //Link : https://www.rapidtables.com/code/text/unicode-characters.html
        }

        //Retorna o tamanho maximo e minimo que o tipo suporta
        public void TamanhoValor()
        {
            sbyte n1 = sbyte.MinValue;
            Console.WriteLine(n1);

            n1 = sbyte.MaxValue;
            Console.WriteLine(n1);
        }

        public void TipoObject()
        {
            object numero = 10;
            numero = "Dez";

            /*
                Variavel do tipo de valor convertida para um objeto é chamado de boxed.
                Variavel do objeto do tipo é convetida para valor é chamado de unboxed.
             */

            int x = 10;
            object x2 = x; //Boxing

            object y = 10; // Unboxing
            int y2 = (int)y;
        }

        public void Conversoes() {
            float x = 4.5f;
            double y = x;//Conversao Implicita

            double a = 5.1;
            float b;

            b = (float)a; //Casting -- Porém, você pode ter perdas de dados(Truncamento).

            int c = 5;
            int d = 7;
            double resultado = (double) 5 / 7;//Garante que nao vai ter perda de dados.






        }
    }
}