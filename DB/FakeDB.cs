using System.Collections.Generic;
using carsModels;

namespace carsDB
{
  public static class FakeDB
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
        new Car("Mazda 3", 2012)
    };
  }
}