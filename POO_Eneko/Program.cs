using POO;
using POO_Eneko;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Xml.Linq;



// 1. Crear varios objetos Language
Language lang1 = new Language { Name = "Castellano", ISO = "ES", Year = 1990, Latin = true};
Language lang2 = new Language { Name = "Vasco", ISO = "ES", Year = 1970, Latin = true };
Language lang3 = new Language { Name = "Gallego", ISO = "ES", Year = 1950, Latin = true };

// 2. Crear un objeto Country con varios Language
// opción 1
// var languages = new List<Language> { lang1, lang2, lang3 };
var languages = new List<Language>();
/*
  var languages = new List<Language>();
      languages.Add(lang1);
      languages.Add(lang1);
      languages.Add(lang1);
*/

Country country1 = new Country
{
    NameISO = "ES", Population = 3000, PIB = 1.2,
    Capital = "Madrid", IsMemberEU=true,
    Language = languages
};

// Opción 2

Country country2 = new Country
{
    NameISO = "ES",
    Population = 3000,
    PIB = 1.2,
    Capital = "Madrid",
    IsMemberEU = true,
};

// Country2.Languages.AddRange(Language);
country2.Language.Add(lang1);
country2.Language.Add(lang2);
country2.Language.Add(lang3);

// 3. Crear objeto Address con un Country

Address addressMadrid = new Address
{
    Street = "calle",
    PostalCode = "333333",
    City = "Madrid",
    Country = country1
};

// 4. Crear un objeto Customer con un Address

Customer user1 = new Customer
{
    Dni = "343434",
    Email = "cust1@sdsd.com",
    Address = addressMadrid
};

// 5. A partir del objeto Customer imprimir qué lenguajes habla con un bucle for
if (Cliente1.Address.Country.Languages == null)
{
    Console.WriteLine("Lista de idiomas sin inicializar");
}
if (cliente1.PersonalVehicles == null)
{
    Console.WriteLine("Lista de personal vehicles sin inicializar");
}

Console.WriteLine("El cliente habla los siguientes idiomas");
foreach (Language idioma in cliente1.Address.Country.Languages)
    Console.WriteLine(idioma.Name);

/*
foreach (idioma in cliente1)
{

}
*/