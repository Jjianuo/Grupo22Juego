using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class controlador
    {
        string texto;

        public controlador(string linea)
        {
            this.texto = linea;
        }

        public void imprimir()
        {
            Console.WriteLine(texto);
        }
    }
}
