using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.ManyToMany;

// Many Films to Many Categories (ManyToMany)
public class Film
{

    // atributos
    public long Id;
    public string Title;
    public int Duration;

    // asociaciones
    public List<Category> Categories = new List<Category>(); // ManyToMany

    public Film() { }

    public override string ToString()
    {
        return $"Film: {Id}, Title: {Title}, Duration: {Duration}, Categories: {Categories.Count}";
    }

}