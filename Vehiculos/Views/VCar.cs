using cSharpUniversity.Helpers;

namespace cSharpUniversity.Views
{
  public class VCar
  {
    private List<Car> carList = new List<Car>();
    public void Init ()
    {
      AddCar();
      PrintCars();
    }

    private void AddCar ()
    {
      Console.Write("Ingrese la cantidad de vehiculos: ");
      int cantidadVehiculos = int.Parse(Console.ReadLine());

      for (int i = 0; i < cantidadVehiculos; i++)
      {
        int numero = i + 1;
        Console.Write($"Ingrese la velocidad del vehiculo {numero}: ");
        float velocidad = float.Parse(Console.ReadLine());

        Console.Write($"Ingrese la distancia del vehiculo {numero}: ");
        float distancia = float.Parse(Console.ReadLine());

        Car myCar = new Car(velocidad, distancia);
        carList.Add(myCar);
        Console.Clear();
      }
    }

    private void PrintCars ()
    {
      int carListSize = carList.Count;
      for (int i = 0; i < carListSize; i++)
      {
        Console.WriteLine($"La velocidad del vehiculo {i + 1} es: {carList[i].CalcularVelocidad()}");
      }
    }
  }
}