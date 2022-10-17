using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;

// implementa la interfaz ISaludo, por tanto está obligada a implementar el método saludar()
public class SaludoFormal : ISaludo
{

    public void Saludar()
    { // define el cómo se hace
        Console.WriteLine("Hello ladies and gentlemen!");
    }

    public void Saludar(string nombre)
    {
        Console.WriteLine("Dear Mrs/Sr" + nombre + ".");
    }
}