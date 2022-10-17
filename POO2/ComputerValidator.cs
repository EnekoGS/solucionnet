using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;


// TODO: crear una clase ComputerValidator con un método Validate que reciba un Computer
// devuelva true o false si cumple una serie de condiciones:
// Id que no sea nulo y que si sea mayor que 0
// RAM mayor que 2 y menor que 256
// Model no puede ser nulo ni estar vacío y tiene que tener una longitud superior a 3 letras
// Utilizar este validador antes de guardar un ordenador
// Opcional: comprobar el atributo Model utilizando una expresión regular
public class ComputerValidator
{


    // Símil: cuando se rellena mal un formulario y se pulsa en enviar no te deja
    // primero se valida y si no está bien no se envía
    public bool Validate(Computer computer)
    {

        // Comprobar Id
        if (computer == null || computer.Id == 0)
            return false; // El computer es incorrecto

        // Comprobar RAM
        if (computer.Ram <= 2 || computer.Ram >= 256)
            return false; // El computer es incorrecto

        // Comprobar Model
        if (computer.Model == null || computer.Model.Length <= 3)
            return false; // El computer es incorrecto


        return true; // El computer es correcto
    }
}