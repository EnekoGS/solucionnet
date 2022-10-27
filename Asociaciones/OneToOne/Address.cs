using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.OneToOne;
public class Address
{

    // atributos
    public long Id;
    public string Street;
    public string City;



    // asociaciones
    public Customer Customer; // bidireccional (opcional)

    public Address() { }


    // TOString
    public override string ToString()
    {
        return $"Address: {Id}, Street:{Street}, City:{City}";
    }
}