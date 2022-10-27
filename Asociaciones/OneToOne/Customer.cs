using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.OneToOne;
public class Customer
{

    // atributos
    public long Id;
    public string Name;
    public int Age;

    // asociaciones
    public Address Address; // dos clientes no pueden tener el mismo address idénticas

    // constructores
    public Customer() { }

    // métodos

    // ToString
    public override string ToString()
    {
        return $"Customer: {Id}, Name:{Name}, Age:{Age}";
    }
}