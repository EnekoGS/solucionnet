using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class Customer
{

    public string Dni;
    public string Email;
    public ISaludo Saludo;
    public Address Address;
    public RoadVehicle WorkVehicle; // Polimorfismo
    public List<RoadVehicle> PersonalVehicles = new List<RoadVehicle>(); // Polimorfismo
    public Customer()
    {
    }

    public void Saludar()
    {
        Saludo.Saludar();
    }
}