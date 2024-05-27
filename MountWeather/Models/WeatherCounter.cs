namespace MountWeather.Models
{
  class WheatherCounter: WheatherDay
  {
    public int Counter = 0;
    public WheatherCounter(string type): base(type)
    { }
  }
}