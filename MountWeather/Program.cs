// See https://aka.ms/new-console-template for more information
using MountWeather.Models;

Random randomNumber = new Random();

List<WheatherDay> weatherDaysData = new List<WheatherDay>();

WheatherDay[] dayTypes = 
{
  new("Sunny"),
  new("Cloudy"),
  new("Rainy")
};

// Make 30 ramdom days
for (int i = 0; i < 30; i++)
{
  WheatherDay randomDay = dayTypes[randomNumber.Next(0, dayTypes.Length)];
  weatherDaysData.Add(randomDay);
}

// Print weather days
for (int i= 0; i < weatherDaysData.Count; i +=3)
{
  // Make an alias
  WheatherDay[] w = weatherDaysData.ToArray();

  // Print days by 3 elements
  Console.WriteLine($"{w[i].Type} {w[i + 1].Type} {w[i + 2].Type}");
}

//----- Calculatios -----//

// Day type - Counter 
IDictionary<string, int> WeatherCounter = new Dictionary<string, int>();

foreach(WheatherDay dayType in dayTypes)
{
  /*
  Make something like this

    dayType.type = "Sunny"
    findType ("Sunny") = 20 // return 

    WeatherCounter["Sunny", 22]  

  */
  WeatherCounter.Add(dayType.Type, findType(dayType.Type, weatherDaysData));
}

// Prints calculatios
Console.WriteLine("\nWeather day types count");

foreach(KeyValuePair<string, int> DayCounter in WeatherCounter)
{
  Console.WriteLine($"{DayCounter.Key} day: {DayCounter.Value}");
}



//----- Funtionalities -----//
int findType(string type, List<WheatherDay> data)
{
  int counter = 0;

  foreach(WheatherDay weather in data)
  {
    if(weather.Type == type)
      counter += 1;
  }
  return counter;
}