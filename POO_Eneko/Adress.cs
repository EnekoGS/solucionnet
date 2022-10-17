using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Eneko;

public class Adress
{
  public string Street;
  public string PostalCode;
  public string City;
  public Country Country; // ASOCIACION: Separar a una clase asociada
  
  public Adress () { }
}

public class Country
{
    public string NameISO;
    public int Population;
    public double PIB;
    public string Capital;
    public string Language;
    public bool IsMemberEU;
    // ASOCIACIÓN con una nueva clase Language (1:N) Tiene múltiples idiomas
    public Country() { }
}

