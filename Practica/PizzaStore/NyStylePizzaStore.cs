using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class NyStylePizzaStore : PizzaStore
    {
        //variable global para guardar la fabrica de ingredientes
        NYPizzaIngredientFactory ingredientFactory;
        //constructor que establece la fabrica al ser creado
        public NyStylePizzaStore()
        {
            ingredientFactory = new NYPizzaIngredientFactory();
        }
        //el metodo de crear pizza con el tipo de pizza que reciba
        public override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza;

            switch (type)
            {
                //se utiliza la "clase" de constantes para evitar introducir valores erroneos al compararlos, mejor se usa la constante referenciandola donde se utilice
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("New York Style Cheese Pizza");
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.SetName("New York Style Pepperoni Pizza");
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("New York Style Clam Pizza");
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.SetName("New York Style Veggie Pizza");
                    break;
                default:
                    return null;
            }

            return pizza;
        }

    }
}
