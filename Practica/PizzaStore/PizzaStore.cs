using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public abstract class PizzaStore
    {
        //Metodo Ordenar pizza crea la pizza y luego ejecuta los pasos predeterminados para crear el producto
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        //Metodo abstracto de create pizza para que lo implementen las clases concretas
        public abstract Pizza CreatePizza(PizzaType type);
    }
}
