using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;

// Clase base
// Tipo abstracto: no se puede instanciar, no se pueden crear objetos de esta clase
public abstract class RoadVehicle
{
    public string Manufacturer;
    public int NumRuedas;
    public bool Status;
    public void Start()
    {
        Status = true;
    }
    public virtual void Stop()
    {
        Status = false;
    }
}

// Clase Car es clase hija/derivada de RoadVehicle
// Extiende a RoadVehicle
public class Car : RoadVehicle
{
    public int NumPuertas;
    public bool RuedaRepuesto;
    public int NumPassengers;
    public int NumPersons;
    public Car() { }
    public override void Stop()
    {
        base.Stop(); // llama a Stop de RoadVehicle
        NumPersons = 0;
    }
}
public class MotorCycle : RoadVehicle
{
    public bool Copilot;
    public bool Naked;
}
public class Truck : RoadVehicle
{
    public bool Trailer;
    public int TrailerCapacity;
}


public class ElectricCar : Car
{
    public int BatteryCapacity;
}
public class CombustionCar : Car
{
    public int TankCapacity;
    public double Emission;
}
public class CombustionElectricCar : Car
{
    public int BatteryCapacity;
    public int TankCapacity;
    public double Emission;
}