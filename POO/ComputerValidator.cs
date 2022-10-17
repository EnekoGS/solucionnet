using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO

// TODO: Crear una clase ComputerValidator con método Validate que reciba un computer
// Devuevla true o false si cumple una serie de condiciones.
// Id que no sea nulo y que si sea mayor que 0
// RAM mayor que 2 y menor que 256
// Model no puede ser nulo ni estar vacío y tiene que tener una longitud superior a 3 letras
// Utilizar este validador antes de guardar un ordenador
// Opcional: Comprobar el atributo Model utilizando una expresión regular
{
    public class ComputerValidator
        // Símil: Cuando se rellena mal un formulario y se pulsa en enviar no te deja
        // Primero se valida y si no está bien no se envía
        public bool Validate(ComputerValidator computer)
        {
            // 1. Id que no sea nulo y que si sea mayor que 0
            if (computer == null || computer.Id == 0)
                return false;

            // Comprobar RAM
            if (computer.Ram <= 2 || computer.Ram >= 256)
                return false;

        // Comprobar Model
        if (computer.Mudel == null || computer.Model.length <= 3)
            return false; // El computer es incorrecto
            
            
        }
    }
}
