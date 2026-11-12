using Microsoft.AspNetCore.Mvc;
using CoffeeOrderingApp.API.Models;
using CoffeeOrderingApp.API.Services;

namespace CoffeeOrderingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeesController : ControllerBase
    {
        private readonly CoffeeService _coffeeService;

        public CoffeesController(CoffeeService coffeeService)
        {
            _coffeeService = coffeeService;
        }

        [HttpGet]
        public List<Coffee> Get()

        {
            return _coffeeService.GetAllCoffees();
        }

        [HttpGet("{id}")]
        public ActionResult<Coffee> GetById(int id)
        {

            Coffee? coffee = _coffeeService.GetCoffeeById(id);

            if (coffee == null)
            {
                return NotFound();
            }

            return Ok(coffee);
        }

        [HttpPost]
        public ActionResult<Coffee> Create(Coffee coffee)
        {
            Coffee createdCoffee = _coffeeService.AddCoffee(coffee);

            return CreatedAtAction(
                nameof(GetById),
                new { id = createdCoffee.Id },
                createdCoffee
                );
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            bool isDeleted = _coffeeService.DeleteCoffee(id);

            if (!isDeleted)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Coffee updatedCoffee)
        {
            bool isUpdated = _coffeeService.UpdatedCoffee(id, updatedCoffee);

            if (!isUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }
    }

}
