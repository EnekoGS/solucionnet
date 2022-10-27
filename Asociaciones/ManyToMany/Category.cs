using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.ManyToMany;

// Many Categories to Many Films (ManyToMany)
public class Category
{

    // atributos
    public long Id;
    public string Name;
    public string Color;

    // asociaciones
    public List<Film> Films = new List<Film>();

    public Category() { }

    public override string ToString()
    {
        return $"Category: {Id}, Name: {Name}, Color: {Color}, Films: {Films.Count}";
    }
}