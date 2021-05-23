using System;
using System.ComponentModel.DataAnnotations;

namespace carsModels
{
  public class Car
  {
    public string Id { get; set; }

    [Required]
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, int year)
    {
      this.Make = Make;
      this.Year = year;
    }
  }


}
