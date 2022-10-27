using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asociaciones.ManyToOne;

// Many Books to One Author (ManyToOne)
public class Book
{

    // atributos
    public long Id;
    public string Title;

    // asociaciones
    public Author Author; // ManyToOne // Sí puede haber 2 o más books con el mismo Author idéntico

    public Book() { }

    public override string ToString()
    {
        return $"Book: {Id}, Title:{Title}, Author:{Author.Name}";
    }
}
