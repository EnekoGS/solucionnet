using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class SaludoInformal : ISaludo
{

    public void Saludar()
    {
        Console.WriteLine("whats up guys!!!");
        Console.WriteLine("whats up guys!!!");
    }

    public void Saludar(string nombre)
    {

        Console.WriteLine("whats up " + nombre + "!!!");

    }
}