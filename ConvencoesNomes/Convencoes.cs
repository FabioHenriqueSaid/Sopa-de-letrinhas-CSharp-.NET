using System;
using System.Collections.Generic;
using System.Text;

namespace Sopa_de_Letrinhas.ConvencoesNomes//Pascal Case
{
    class Convencoes//Pascal Case
    {

        /*
           Camel Case: lastName (parametros de metodos,variaveis  dentro de metodos)
           Pascal Case : LastName (namespaces,classe,properties e métodos)
           Padrão _lastName (atributos "internos" da classe)
         */

        public string Titular { get; set; }//properties

        private double _saldo;//atributo interno

        public void Valor(double valor) {
            //parametro - CamelCase
            //metodo - Pascal Case
            _saldo += valor;
        }
    }
}
