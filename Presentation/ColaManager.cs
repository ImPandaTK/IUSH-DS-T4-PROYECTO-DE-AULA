using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public static class ColaManager
    {
        public static Queue<(string, string, int)> transferencias = new Queue<(string, string, int)>();

        public static void Encolar((string , string , int) elemento)
        {
            transferencias.Enqueue(elemento);
        }
        public static (string,string, int) Desencolar()
        {
            if (transferencias.Count > 0)
            {
                return transferencias.Dequeue();
            }
            else
            {
                return (null,null,0); 
            }
        }
    }
}
