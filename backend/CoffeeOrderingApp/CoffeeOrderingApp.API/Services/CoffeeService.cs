using CoffeeOrderingApp.API.Models;

namespace CoffeeOrderingApp.API.Services
{
    public class CoffeeService
    {

        private readonly List<Coffee> _coffees = new()
        {
            new Coffee { Id = 1, Name = "Latte", Price = 35 },
            new Coffee { Id = 2, Name = "Espresso", Price = 25 },
            new Coffee { Id = 3, Name = "Cappuccino", Price = 40 }
        };

        public List<Coffee> GetAllCoffees()
        {
            return _coffees;
        }

        public Coffee? GetCoffeeById(int id)
        {
            return _coffees.FirstOrDefault(c => c.Id == id);
        }

        public Coffee AddCoffee(Coffee coffee)
        {
            _coffees.Add(coffee);
            return coffee;
        }

        public bool DeleteCoffee(int id)
        {
            Coffee? coffee = _coffees.FirstOrDefault(c => c.Id == id);

            if (coffee == null)
            {
                return false;
            }

            _coffees.Remove(coffee);

            return true;
        }

        public bool UpdatedCoffee(int id, Coffee updatedCoffee)
        {
            Coffee? existingCoffee = _coffees.FirstOrDefault(c => c.Id == id);

            if(existingCoffee == null)
            {
                return false;
            }

            existingCoffee.Name = updatedCoffee.Name;
            existingCoffee.Price = updatedCoffee.Price;

            return true;
        }
    }
}
