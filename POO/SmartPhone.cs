using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class SmartPhone
{

    public string Manufacturer;
    public int Ram;
    public int Cores;

    public SmartPhone() { }

    public SmartPhone(string manufacturer, int ram, int cores)
    {
        Manufacturer = manufacturer;
        Ram = ram;
        Cores = cores;
    }

    public override string ToString()
    {
        return $"Manufacturer: {Manufacturer}, Ram:{Ram}, Cores:{Cores}";
    }

}