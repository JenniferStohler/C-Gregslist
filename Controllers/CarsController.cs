using System;
using System.Collections.Generic;
using carsModels;
using carsDB;
using carsService;
using Microsoft.AspNetCore.Mvc;

namespace CarsController
{
  [ApiController]

  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _service;
    public CarsController(CarsService service)
    {
      _service = service;
    }
    //GET
    [HttpGet]

    public ActionResult<IEnumerable<Car>> GetAll()
    {
      try
      {
        return Ok(FakeDB.Cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //GET BY ID
    [HttpGet("{id}")] //same as :id
    public ActionResult<Car> GetById(string id)
    {
      try
      {
        Car found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //POST
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _service.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //EDIT
    [HttpPut]
    public ActionResult<Car> Edit([FromBody] Car editCar)
    {
      try
      {
        Car car = _service.Edit(editCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //DELETE
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteCar(string id)
    {
      try
      {
        _service.DeleteCar(id);
        return Ok("Deleted!");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}










//GETBYID


//POST


//PUT


//DELETE