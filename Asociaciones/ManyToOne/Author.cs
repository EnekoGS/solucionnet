using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.ManyToOne;


// One Author To Many Books (OneToMany)
public class Author
{

    // atributos
    public long Id;
    public string Name;

    // asociaciones (OneToMany)
    public List<Book> Books = new List<Book>(); // importante inicializar la lista para poder agregar books después

    public Author() { }

    public override string ToString()
    {
        return $"Author: {Id}, Name:{Name}, Books:{Books.Count}";
    }
}