using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class ComputerListRepository : IComputerRepository
{

    // Atributos
    private List<Computer> computers;
    private ComputerValidator Validator;

    // Contructor
    public ComputerListRepository(ComputerValidator validator)
    {
        // Simulamos que la lista computers es una base de datos
        computers = new List<Computer> {
            new Computer{ Id = 1, Model = "MacBook Pro", Ram = 16 },
            new Computer{ Id = 2, Model = "MSI Modern", Ram = 32 },
            new Computer{ Id = 3, Model = "Asus A55A", Ram = 8 },
        };
        Validator = validator;
    }

    // Implementar métodos de interfaz
    public List<Computer> FindAll()
    {
        return computers;
    }

    public Computer FindById(int id)
    { // 99

        foreach (Computer computer in computers)
        {
            if (computer.Id == id)
                return computer;
        }

        return null;
    }

    public bool ExistsById(int id)
    {

        /*foreach (Computer computer in computers) {
            if (computer.Id == id)
                return true;
        }
        
        return false;*/

        return FindById(id) != null; // true o false
    }

    public List<Computer> FindAllByRam(int min, int max)
    {

        List<Computer> computersByRam = new List<Computer>();

        foreach (Computer computer in computers)
        {
            if (computer.Ram >= min && computer.Ram <= max)
            {
                // añado el ordenador que cumple los filtros de RAM a la nueva lista
                computersByRam.Add(computer);
            }
        }
        return computersByRam;


    }


    public List<Computer> FindAllByModel(string model)
    {
        List<Computer> computersByModel = new List<Computer>();

        foreach (Computer computer in computers)
            if (computer.Model.ToLower().Equals(model.ToLower()))
                computersByModel.Add(computer);

        return computersByModel;
    }

    public bool Save(Computer computer)
    {
        Console.WriteLine(computer);

        // comprobar si existe
        bool exist = ExistsById(computer.Id);

        // si existe no lo añado y devuelvo false
        if (exist) return false;

        // si no existe entonces lo añado a la lista y devuelvo true

        if (!Validator.Validate(computer))
            return false;

        computers.Add(computer);

        return true;


    }

    // Count
    public int Count()
    {
        // return computers.Count;

        int contador = 0;
        foreach (Computer computer in computers)
            contador++;

        //for (int i = 0; i < computers.Count; i++)
        //   contador++;

        return contador;

    }

    // Tiene que devolver el número de ordenadores nuevos que hayan sido guardados
    public int SaveAll(List<Computer> computersToAdd)
    {

        // computersToAdd es la nueva lista de ordenadores a agregar
        // computers es la lista de ordenadores que ya tenemos
        // computers.AddRange(computersToAdd);
        int contador = 0;
        foreach (Computer computer in computersToAdd)
        {
            bool saved = Save(computer);
            if (saved) contador++;
        }
        return contador;
    }


    public void PrintAll()
    {

        // computers

        // opcion 1
        foreach (Computer computer in computers)
            Console.WriteLine(computer); // debe estar el método ToString en la clase Computer

        // opcion 2
        //Console.WriteLine(string.Join(",", computers));

        // opcion 3
        /* StringBuilder sb = new StringBuilder();
        foreach (Computer computer in computers)
            sb.Append(computer).Append(",");
        Console.WriteLine(sb);*/
    }

    public bool Update(Computer computer)
    {

        // comprobar si existe 
        if (!ExistsById(computer.Id))
            return false; // si no existe no lo podemos modificar


        for (int i = 0; i < computers.Count; i++)
        {

            if (computers[i].Id == computer.Id)
            {

                // actualizar atributos del computer de la lista con los
                // del computer que llega como parámetro
                computers[i].Model = computer.Model;
                computers[i].Ram = computer.Ram;

                return true; // una vez modificado salimos del método
            }
        }

        return false;

    }

    public bool DeleteById(int id)
    {

        // comprobar si existe 
        if (!ExistsById(id))
            return false; // si no existe no lo podemos borrar

        for (int i = 0; i < computers.Count; i++)
        {

            if (computers[i].Id == id)
            {
                computers.RemoveAt(i);
                // computers.Remove(FindById(id));
                return true;
            }
        }
        return false;
    }

    public int DeleteAllByIds(List<int> ids)
    {

        int contador = 0;
        foreach (int id in ids)
        {
            bool deleted = DeleteById(id);
            if (deleted) contador++;
        }
        return contador;
    }


    public bool DeleteAll()
    {

        //if (computers.Count == 0)
        //    return false;

        if (!computers.Any())
            return false;


        computers.Clear();
        return true;
    }

    public double CalculateAvgRam()
    {

        int sum = 0;

        foreach (Computer comp in computers)
            sum += comp.Ram;

        return (double)sum / Count();
    }

    public int FindMaxRam()
    {

        int maxRam = 0;

        foreach (Computer computer in computers)
            // if (computer.Ram > maxRam)
            //    maxRam = computer.Ram;

            if (maxRam < computer.Ram)
                maxRam = computer.Ram;

        return maxRam;

        // maxRam = 0 y ram = 8
        // maxRam = 8

        // maxRam = 8 y ram = 4
        // maxRam = 8

        // maxRam = 8 y ram = 16
        // maxRam = 16
    }


}