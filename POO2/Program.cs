using POO;

// 1. Crear clase Computer
// 2. Crear una interface IComputerRepository con operaciones CRUD sobre una lista de Computer
// 3. Crear una implementación de la interface
// 4. Utilizar los métodos desde Program.cs
ComputerValidator validator = new ComputerValidator();
IComputerRepository computerRepo = new ComputerListRepository(validator);

// IComputerRepository computerRepo = new Computer1Repository();
// IComputerRepository computerRepo = new Computer2Repository();
// IComputerRepository computerRepo = new Computer3Repository();
// tipodedato nombreobjeto = new tipodedato();


var computers = computerRepo.FindAll();
Console.WriteLine(computers.Count);

Computer computer1 = computerRepo.FindById(1);
Console.WriteLine(computer1.Ram);

var computers2 = computerRepo.FindAllByRam(8, 64);
var computers3 = computerRepo.FindAllByRam(16, 128);

Console.WriteLine("fin");

// Comprobar que Save añade un nuevo ordenador: 


// Caso 1: Añadir un ordenador que Sí se guarde porque no existe

// Crear un nuevo computer
Computer computer4 = new Computer { Id = 4, Model = "DELL", Ram = 6 };

// llamar al método Save
int before = computerRepo.Count(); // 3
bool saved = computerRepo.Save(computer4); // la lista de ordenadores crece en 1
int after = computerRepo.Count(); // 4

// comprobar si se guardó
if (saved)
{
    Console.WriteLine("Se guardó correctamente el computer4");
}
else
{
    Console.WriteLine("No se pudo guardar el computer4");
}
// comprobar los que había antes de añadir y los que hay después de añadir y verificar que hay más
// comprobar que after es exactamente 1 mayor que before
if (after - before == 1) Console.WriteLine("Efectivamente la lista de computers se incrementó en 1.");



// ==================================================


// Caso 2: Añadir un ordenador que NO se guarde porque ya existe

// Crear un ordenador con el mismo Id que otro ordenador que ya exista en la lista 
var comp1 = new Computer { Id = 1, Model = "MacBook Pro", Ram = 16 };

// Intentar guardar el ordenador en la lista de ordenadores
before = computerRepo.Count();
saved = computerRepo.Save(comp1); // false
after = computerRepo.Count();

// Comprobar que no se ha guardado nada
if (!saved) Console.WriteLine("Efectivamente no se ha guardado el comp1");
// comprobar after y before no son diferentes
if (after == before)
{
    Console.WriteLine("No se ha guardado ningún ordenador");
}







Console.WriteLine("================= SaveAll ===================");

// Caso 1: insertar 3 ordenadores completamente nuevos, devuelve 3
Console.WriteLine("================= SaveAll Caso 1 ===================");
Computer pcA = new Computer { Id = 5, Model = "HP MX300", Ram = 8 };
Computer pcB = new Computer { Id = 6, Model = "Asus 2500", Ram = 16 };
Computer pcC = new Computer { Id = 7, Model = "Corsair", Ram = 32 };

var pcs = new List<Computer> { pcA, pcB, pcC };

int savedNum = computerRepo.SaveAll(pcs);

if (savedNum == 3) Console.WriteLine("Se han guardado los 3 ordenadores nuevos");






// Caso 2: intertar 5 ordenadores, 3 que ya existen y 2 nuevos, devuelve 2
Console.WriteLine("================= SaveAll Caso 2 ===================");
// 3 que ya existen (es decir, que el id ya esté ocupado)
var pc1 = new Computer { Id = 1, Model = "MacBook Pro", Ram = 16 };
var pc2 = new Computer { Id = 2, Model = "MSI Modern", Ram = 32 };
var pc3 = new Computer { Id = 3, Model = "Asus A55A", Ram = 8 };

// 2 nuevos
Computer pc8 = new Computer { Id = 8, Model = "Lenovo", Ram = 32 };
Computer pc9 = new Computer { Id = 9, Model = "Acer", Ram = 32 };

pcs = new List<Computer> { pc1, pc2, pc3, pc8, pc9 };

savedNum = computerRepo.SaveAll(pcs);

if (savedNum == 2) Console.WriteLine("Se han guardado los 2 ordenadores nuevos");


Console.WriteLine("================= PrintAll ===================");
// invocar el método PrintAll

computerRepo.PrintAll();





Console.WriteLine("================= Update ===================");

// 1. Tener un objeto ordenador con los atributos modificados menos el Id
var computer1Modified = new Computer { Id = 432, Model = "MacBook Pro Modificado", Ram = 32 };

// 2. Invocar el método Update
bool isModified = computerRepo.Update(computer1Modified);

// 3. Comprobar que el objeto ordenador con Id 1 ha sido modificado

if (isModified) Console.WriteLine("Se ha modificado el ordenador con Id 1");
// buscar el ordenador modificado y comprobar el nombre:

var computer1FromList = computerRepo.FindById(1);

if (computer1FromList.Model.Equals("MacBook Pro Modificado") &&
    computer1FromList.Ram == 32)
{
    Console.WriteLine("Se han modificado los atributos del ordenador con Id 1");
}



Console.WriteLine("================= DeleteById ===================");
/*
before = computerRepo.Count();
bool isDeleted = computerRepo.DeleteById(2);
after = computerRepo.Count();
if (isDeleted) Console.WriteLine("Se ha eliminado el ordenador con Id 2");
if (after == before - 1) {
    Console.WriteLine("Correcto, se ha eliminado");
}
*/

Console.WriteLine("================= DeleteAllByIds ===================");
/*
var ids = new List<int> { 1, 3, 55, 5, 6, 99 }; // El 55 y el 99 no existen
int deletedNum = computerRepo.DeleteAllByIds(ids);
if (deletedNum == 4) Console.WriteLine("Se han eliminado 4 ordenadores");
*/

Console.WriteLine("================= DeleteAll ===================");

/*
before = computerRepo.Count();
bool hasDeletedAll = computerRepo.DeleteAll(); // true
after = computerRepo.Count();
if (hasDeletedAll) Console.WriteLine("Se han eliminado todos los ordenadores");
if (after == 0) Console.WriteLine("Se han eliminado todos los ordenadores");
hasDeletedAll = computerRepo.DeleteAll(); // false
if (hasDeletedAll) Console.WriteLine("Se han eliminado todos los ordenadores otra vez");
*/


Console.WriteLine("================= CalculateAvgRam ===================");

computerRepo.PrintAll();

double avgRam = computerRepo.CalculateAvgRam();
Console.WriteLine(avgRam);
Console.WriteLine($"La media de la RAM de los ordenadores es {avgRam}");


Console.WriteLine("================= FindMaxRam ===================");

computerRepo.PrintAll();
int maxRam = computerRepo.FindMaxRam();
Console.WriteLine($"La RAM máxima de los ordenadores es {maxRam}");
