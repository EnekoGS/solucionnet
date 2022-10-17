using POO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public interface IComputerRepository
{

    // recuperar todos los computer
    List<Computer> FindAll();

    // recuperar un computer por su Id
    Computer FindById(int id);

    // comprobar si existe por id
    bool ExistsById(int id);

    // TODO recuperar varios por ids 

    // recuperar por rango (min, max) de memoria Ram
    // 8 y 64 RAM
    List<Computer> FindAllByRam(int min, int max);

    // buscar por su Model
    List<Computer> FindAllByModel(string model);

    // guardar un ordenador
    bool Save(Computer computer);

    // recuperar el número de ordenadores, para saber cuántos ordenadores hay
    int Count();

    // guardar varios
    int SaveAll(List<Computer> computersToAdd);

    // imprimir por consola todos los ordenadores de la lista que ya tenemos dentro
    void PrintAll();

    // modificar un computer que ya está en la lista
    bool Update(Computer computer);

    // borrar por id
    bool DeleteById(int id);

    // borrar por ids
    int DeleteAllByIds(List<int> ids);

    // borrar todos
    bool DeleteAll();

    // calcular la RAM media de todos los ordenadores
    double CalculateAvgRam();

    // sacar la RAM máxima de todos los ordenador, es decir, comprobar el que tiene más ram y devolver ese número
    int FindMaxRam();

    // TODO sacar la RAM mínima de todos los ordenador, es decir, comprobar el que tiene menos ram y devolver ese número

}