using System;
using System.Collections.Generic;

class Cola<T>
{
    private Queue<T> elementos;

    public Cola()
    {
        elementos = new Queue<T>();
    }

    public bool EsVacia()
    {
        return elementos.Count == 0;
    }

    public void Encolar(T dato)
    {
        elementos.Enqueue(dato);
    }

    public T Desencolar()
    {
        if (EsVacia())
        {
            throw new InvalidOperationException("La cola está vacía");
        }
        return elementos.Dequeue();
    }

    public T Pistear()
    {
        if (EsVacia())
        {
            throw new InvalidOperationException("La cola está vacía");
        }
        return elementos.Peek();
    }

    public bool Contiene(T elemento)
    {
        return elementos.Contains(elemento);
    }

    public List<T> Desencolar(int n)
    {
        if (n == -1)
        {
            var desencolados = new List<T>();
            while (!EsVacia())
            {
                desencolados.Add(Desencolar());
            }
            return desencolados;
        }
        else
        {
            var desencolados = new List<T>();
            for (int i = 0; i < n && !EsVacia(); i++)
            {
                desencolados.Add(Desencolar());
            }
            return desencolados;
        }
    }
}
