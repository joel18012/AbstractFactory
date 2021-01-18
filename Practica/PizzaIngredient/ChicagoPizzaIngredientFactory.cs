using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        //aqui solo se declaran las funciones con los ingrediente que usa esa fabrica de ingredientes

        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }
        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
        
        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>
            {
                new EggPlant(),
                new Spinach()
            };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        
    }
}
