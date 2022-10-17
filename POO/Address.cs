using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class Address
{

    public string Street;
    public string PostalCode;
    public string City;
    public Country Country; // ASOCIACIÓN entre clases: separar a una nueva clase asociada
    public Address() { }
}

public class Country
{
    // atributos
    public string NameISO;
    public int Population;
    public double PIB;
    public string Capital;
    public bool IsMemberEU;
    // ASOCIACIÓN con una nueva clase Language (1:N) Tiene múltiples idiomas
    // public Language language; // Language (1:1)
    public List<Language> Languages = new List<Language>(); // Language (1:N)


}

// Crear clase Language

public class Language
{
    public string Name;
    public string ISO;
    public int Year;
    public bool Latin;
}