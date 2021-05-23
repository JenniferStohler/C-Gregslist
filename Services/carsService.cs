
using System.Collections.Generic;
using carsDB;
using carsModels;


namespace carsService
{
  public class CarsService
  {
    internal IEnumerable<Car> GetAll()
    {
      //TEMPORARY
      return FakeDB.Cars;
    }
    internal Car GetById(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      return found;
    }
    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }
    internal Car Edit(Car editCar)
    {
      Car newCar = GetById(editCar.Id);
      newCar.Make = editCar.Make;
      newCar.Year = editCar.Year;
      return newCar;
    }
    internal void DeleteCar(string id)
    {
      Car found = GetById(id);
      FakeDB.Cars.Remove(found);
    }
  }
}