using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;

/*
 * Las interfaces son tipos abstractos, es decir, no implementan los métodos, solo los declaran
 * 
 */
public interface ISaludo
{

    void Saludar(); // declara, dice qué se hace
    void Saludar(string nombre);
}