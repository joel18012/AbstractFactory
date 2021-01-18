using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public interface PizzaIngredientFactory
    {
        //declara las funciones que se deben implemntar
        Cheese CreateCheese();
        Clams CreateClams();
        Dough CreateDough();
        Pepperoni CreatePepperoni();
        Sauce CreateSauce();
        
        List<Veggie> CreateVeggies();
    }
}
