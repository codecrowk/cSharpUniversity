namespace cSharpUniversity.Helpers
{
  public class Car
  {
    private readonly float Distancia;
    private readonly float Tiempo;

    public Car (float distancia, float tiempo)
    {
      Distancia = distancia;
      Tiempo = tiempo;
    } 

    public float CalcularVelocidad ()
    {
      float velocidad = Distancia / Tiempo;
      return velocidad;
    }
  }

}

