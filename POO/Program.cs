using POO;
using System.Xml.Linq;

// crear una variable
string nombre = "alan";

// Crear objeto a partir de una clase
Employee empleado1 = new Employee("77766611T", "Empleado1", 30, 3000.0, false);
Employee empleado2 = new Employee("44433322F", "Empleado2", 28, 2900.0, true);
empleado1.Salary = 4000.0;

Console.WriteLine(empleado1.Name);
Console.WriteLine(empleado2.Name);

// Operaciones aritmética
Console.WriteLine(empleado1.Salary + empleado2.Salary);
var media = (empleado1.Salary + empleado2.Salary) / 2;
Console.WriteLine(media);

Employee empleado3 = new Employee("11122233G", "Empleado3");
Employee empleado4 = new Employee("11122234G", "Empleado4");
Console.WriteLine(empleado3.Salary);

Employee empleado5 = new Employee("11122235G", "Empleado5", 3000.0);
Console.WriteLine(empleado5.Dni);

// Constructor vacío
Employee empleado6 = new Employee();
empleado6.Name = "Empleado6";
empleado6.Age = 30;
Console.WriteLine(empleado6.Name);
Console.WriteLine(empleado6.Dni);

// Constructor dinámico (Requiere un constructor vacío)
// Se pueden pasar los parámetros que se quiera y en el orden que se quiera
Employee empleado7 = new Employee { Age = 30, Dni = "77766655G" };
Employee empleado8 = new Employee { Age = 30, Dni = "77766655G", Married = false };

// Ejemplo con Vehicle
Vehicle coche1 = new Vehicle();
coche1.Manufacturer = "Seat";
coche1.Model = "Ibiza";

Vehicle coche2 = new Vehicle { Manufacturer = "Seat", Model = "Ibiza" };
Vehicle coche3 = new Vehicle { Manufacturer = "Ford" };
Vehicle coche4 = new Vehicle { Model = "Mondeo" };
Vehicle coche5 = new Vehicle { Model = "Mondeo", CubicCentimeters = 1.2 };

// Comprobar el estado del vehículo
Console.WriteLine(coche1.Status); // False

// Arrancar vehículo
coche1.Start();// invoca un método que realiza una acción

// Comprobar el estado del vehículo
Console.WriteLine(coche1.Status); // True

// Parar el vehículo
coche1.Stop();

// Comprobar el estado del vehículo
Console.WriteLine(coche1.Status); // False

// acelerar por primera vez
Console.WriteLine(coche1.Velocidad); // 0
coche1.Acelerar(50);
Console.WriteLine(coche1.Velocidad); // 50

// acelerar por segunda vez
Console.WriteLine("Introduce la cantidad a acelerar:");
/*int cantidad = Convert.ToInt32(Console.ReadLine());
coche1.Acelerar(cantidad);
Console.WriteLine(coche1.Velocidad);*/

// frenar por primera vez
coche1.Frenar(20);
Console.WriteLine(coche1.Velocidad);

// frenar por segunda vez
/*Console.WriteLine("Introduce la cantidad a frenar:");
cantidad = Convert.ToInt32(Console.ReadLine());
coche1.Frenar(cantidad);
Console.WriteLine(coche1.Velocidad);*/


// Acelerar con sobrecarga
Vehicle ferrari = new Vehicle();
ferrari.Start();
ferrari.Acelerar(130); // 120


ferrari.Stop();
ferrari.Start();
ferrari.Acelerar(130, 200); // 130


Person persona1 = new Person();
persona1.Saludar();
persona1.Saludar("Alan");


// Método ToString

SmartPhone movil1 = new SmartPhone { Manufacturer = "Samsung", Cores = 4, Ram = 8 };
Console.WriteLine(movil1);

SmartPhone movil2 = new SmartPhone { Manufacturer = "One Plus", Cores = 8, Ram = 16 };
Console.WriteLine(movil2);

// Encapsulación (getter setter)
// get sirve para obtener/leer un atributo
// set sirve para modificar el valor de un atributo

Guest invitado = new Guest();
invitado.Age = -20;
Console.WriteLine(invitado.Age);
Console.WriteLine(invitado.Dni);
// invitado.Dni = "77788899Y";
// invitado.Salary = 10.0;
Console.WriteLine(invitado.Salary);
invitado.Promote(200.0);
Console.WriteLine(invitado.Salary);
// invitado.Salary = 200.0;

// Promote sobrecargado y private
invitado.Promote();
Console.WriteLine(invitado.Salary);
// invitado.CalcSalaryPromotion();

// Asociación entre clases

Address address1 = new Address
{
    Street = "Calle falsa 123",
    PostalCode = "44099",
    City = "Madrid",
};


Customer customer1 = new Customer
{
    Dni = "77711122E",
    Email = "cust1@company.com",
    Address = address1
};

// calle del cliente:
Console.WriteLine(customer1.Address.Street);

// Herencia:

Car car = new Car();
car.Manufacturer = "Ford"; // heredada
car.NumRuedas = 4; // heredada

car.NumPuertas = 3; // específica de Car
car.RuedaRepuesto = false; // específica de Car
car.NumPassengers = 3; // específica de Car
car.Start(); // heredado

MotorCycle moto = new MotorCycle();
moto.Manufacturer = "Kawasaki"; // heredada
moto.NumRuedas = 2; // heredada
moto.Copilot = true; // específica de MotorCycle
moto.Naked = false; // específica de MotorCycle

Truck truck = new Truck();
truck.Manufacturer = "Volvo"; // heredada
truck.NumRuedas = 12; // heredada
truck.Trailer = true;
truck.TrailerCapacity = 5;


// Clase abstracta
// Se aplica normalmente a la clase base de una herencia
// con el objetivo de que no sea instancie
// y obligar a que se instancie una de las clases hijas

/* RoadVehicle veh1 = new RoadVehicle();
truck.Manufacturer = "Honda"; 
truck.NumRuedas = 4; */


ElectricCar electric1 = new ElectricCar();
electric1.Manufacturer = "Alfa"; // heredada de RoadVehicle
electric1.NumRuedas = 4; // heredada de RoadVehicle
electric1.NumPuertas = 5; // heredada de Car
electric1.RuedaRepuesto = true; // heredada de Car
electric1.NumPassengers = 5; // heredada de Car
electric1.BatteryCapacity = 50000; // específica

CombustionCar combustion1 = new CombustionCar();
combustion1.Manufacturer = "Alfa"; // heredada de RoadVehicle
combustion1.NumRuedas = 4; // heredada de RoadVehicle

combustion1.NumPuertas = 5; // heredada de Car
combustion1.RuedaRepuesto = true; // heredada de Car
combustion1.NumPassengers = 5; // heredada de Car

combustion1.TankCapacity = 120; // específica
combustion1.Emission = 30.5; // específica

// Override en herencia

Car alfaRomeo = new Car();
alfaRomeo.NumPersons = 3;
alfaRomeo.Start();
Console.WriteLine(alfaRomeo.Status + " " + alfaRomeo.NumPersons);

alfaRomeo.Stop();
Console.WriteLine(alfaRomeo.Status + " " + alfaRomeo.NumPersons);

Car another = new Car { NumPersons = 1 };


// Polimorfismo

Customer client = new Customer
{
    Dni = "55544433T",
    WorkVehicle = truck // Polimorfismo
};
client.WorkVehicle.Start();



DoSomething(truck);
DoSomething(moto);

void DoSomething(RoadVehicle vehicle)
{ // Polimorfismo
    vehicle.Start();
    // acelerar....
    vehicle.Stop();
}

var vehicles = new List<RoadVehicle> {
    new MotorCycle{ Copilot = true },
    new ElectricCar{ BatteryCapacity = 30000},
    new Truck{ TrailerCapacity = 4000}
};

Customer client2 = new Customer
{
    Dni = "34344535",
    PersonalVehicles = vehicles // Polimorfismo
};

// print vehicles
Console.WriteLine("Num vehiculos de client2: " + client2.PersonalVehicles.Count());


// Address - Country - Language

// 1. Crear varios objetos Language
Language lang1 = new Language { Name = "Castellano", ISO = "ES", Year = 1990, Latin = true };
Language lang2 = new Language { Name = "Vasco", ISO = "ES", Year = 1970, Latin = true };
Language lang3 = new Language { Name = "Gallego", ISO = "ES", Year = 1950, Latin = true };


// 2. Crear un objeto Country con varios Language
// opción 1
var languages = new List<Language> { lang1, lang2, lang3 };
/*var languages = new List<Language>();
languages.Add(lang1);
languages.Add(lang2);
languages.Add(lang3);*/

Country country1 = new Country
{
    NameISO = "ES",
    Population = 3000,
    PIB = 1.2,
    Capital = "Madrid",
    IsMemberEU = true,
    Languages = languages
};

// opción 2
Country country2 = new Country
{
    NameISO = "ES",
    Population = 3000,
    PIB = 1.2,
    Capital = "Madrid",
    IsMemberEU = true,
};
// country2.Languages.AddRange(languages);
country2.Languages.Add(lang1);
country2.Languages.Add(lang2);
country2.Languages.Add(lang3);


// 3. Crear objeto Address con un Country
Address addressMadrid = new Address
{
    Street = "calle",
    PostalCode = "333333",
    City = "Madrid",
    Country = country1
};


// 4. Crear un objeto Customer con un Address
Customer cliente1 = new Customer
{
    Dni = "343434",
    Email = "cust1@sdsd.com",
    Address = addressMadrid
};


// 5. A partir del objeto Customer imprimir qué lenguajes habla con un bucle for
if (cliente1.Address.Country.Languages == null)
{
    Console.WriteLine("Lista de idiomas sin inicializar");
}
if (cliente1.PersonalVehicles == null)
{
    Console.WriteLine("Lista de personal vehicles sin inicializar");
}

Console.WriteLine("El cliente habla los siguientes idiomas:");
foreach (Language idioma in cliente1.Address.Country.Languages)
    Console.WriteLine(idioma.Name);


// Interfaces



ISaludo saludo1 = new SaludoFormal(); // Polimorfismo en interfaz
Customer rodolfo = new Customer { Saludo = saludo1 };
rodolfo.Saludo.Saludar();
rodolfo.Saludo.Saludar("Alan");
rodolfo.Saludar();

ISaludo saludo2 = new SaludoInformal(); // Polimorfismo en interfaz
rodolfo.Saludo = saludo2;
rodolfo.Saludo.Saludar();
rodolfo.Saludo.Saludar("Alan");
rodolfo.Saludar();

Customer mike = new Customer { Saludo = saludo2 };


SaludoFormal s1 = new SaludoFormal(); // NO polimorfismo
SaludoInformal s2 = new SaludoInformal(); // NO polimorfismo
// SaludoFormal s3 = new SaludoInformal(); // NO polimorfismo


