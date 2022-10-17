using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class Person
{

    public void Saludar()
    {
        Console.WriteLine("Hola");
    }
    public void Saludar(string nombre)
    {
        Console.WriteLine("Hola " + nombre);
    }

    public void Saludar(string palabra, string nombre)
    {
        Console.WriteLine(palabra + " Hola " + nombre);
    }

    public void Saludar(double edad)
    {
        Console.WriteLine("Hola mi edad es" + edad);
    }

    public void Despedida()
    {

    }
}