using System;
using System.Collections.Generic;

namespace Presentation
{
    public class Nodo
    {
        public string Usuario { get; set; }
        public int TransferenciasRecibidas { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(string usuario)
        {
            Usuario = usuario;
            TransferenciasRecibidas = 0;
        }
    }

    public class ArbolBinario
    {
        public Nodo Raiz { get; private set; }

        public ArbolBinario(string usuarioOrigen)
        {
            Raiz = new Nodo(usuarioOrigen);
        }

        public void InsertarTransferencia(string usuarioDestino)
        {
            Insertar(Raiz, usuarioDestino);
        }

        private void Insertar(Nodo nodo, string usuarioDestino)
        {
            if (nodo == null)
            {
                return;
            }

            if (usuarioDestino == nodo.Usuario)
            {
                nodo.TransferenciasRecibidas++;
                return;
            }

            if (nodo.Izquierdo == null)
            {
                nodo.Izquierdo = new Nodo(usuarioDestino);
                nodo.Izquierdo.TransferenciasRecibidas++;
            }
            else if (nodo.Derecho == null)
            {
                nodo.Derecho = new Nodo(usuarioDestino);
                nodo.Derecho.TransferenciasRecibidas++;
            }
            else
            {
                if (nodo.Izquierdo.TransferenciasRecibidas <= nodo.Derecho.TransferenciasRecibidas)
                {
                    Insertar(nodo.Izquierdo, usuarioDestino);
                }
                else
                {
                    Insertar(nodo.Derecho, usuarioDestino);
                }
            }
        }
    }
}
