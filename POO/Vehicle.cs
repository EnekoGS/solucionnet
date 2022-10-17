using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class Vehicle
{

    // Atributos (estado)
    public string Manufacturer;
    public string Model;
    public double CubicCentimeters;
    public bool Status; // encendido (true) o apagado (false)
    // atributo velocidad:
    public int Velocidad;


    // Constructor vacío (permite crear nuevos objetos)
    public Vehicle() { }

    // Métodos (comportamiento)
    public void Start()
    {
        Status = true;
    }
    public void Stop()
    {
        Velocidad = 0;
        Status = false;

    }
    // 1. método para acelerar la velocidad en una cantidad determinada pasada por parámetro
    // 1.a. si la velocidad más la cantidad supera 120km/h entonces no la sumamos:
    public void Acelerar(int cantidad)
    {
        if (cantidad > 0 && Velocidad + cantidad <= 120)
            Velocidad += cantidad;
        else if (Velocidad + cantidad > 120)
            Velocidad = 120; // límite superior

    }
    // Método sobrecargado: Acelerar que reciba una cantidad y un límite
    public void Acelerar(int cantidad, int limit)
    {
        if (cantidad > 0 && Velocidad + cantidad <= limit)
            Velocidad += cantidad;
        else if (Velocidad + cantidad > limit)
            Velocidad = limit; // límite superior
    }


    // 2. método para reducir la velocidad en una cantidad determinada pasada por parámetro
    // 2.a. si la velocidad menos la cantidad es menor que 0 entonces no la restamos:
    public void Frenar(int cantidad)
    {
        if (cantidad > 0 && Velocidad - cantidad >= 0)
            Velocidad -= cantidad;
        else if (Velocidad - cantidad < 0)
            Velocidad = 0; // límite inferior

    }




}