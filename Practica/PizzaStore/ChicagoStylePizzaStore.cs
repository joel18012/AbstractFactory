using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        //variable global para guardar la fabrica de ingredientes
        ChicagoPizzaIngredientFactory ingredientFactory;
        //constructor que establece la fabrica al ser creado
        public ChicagoStylePizzaStore()
        {
            ingredientFactory = new ChicagoPizzaIngredientFactory();
        }

        //el metodo de crear pizza con el tipo de pizza que reciba
        public override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza;

            switch (type)
            {
                //se utiliza la "clase" de constantes para evitar introducir valores erroneos al compararlos, mejor se usa la constante referenciandola donde se utilice
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.SetName("Chicago Style Pepperoni Pizza");
                    break;
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("Chicago Style Cheese Pizza");
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("Chicago Style Clam Pizza");
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.SetName("Chicago Style Veggie Pizza");
                    break;
                default:
                    return null;
            }

            return pizza;
        }
    }
}
