using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public abstract class Pizza
    {
        //declarar variables y objetos para la pizza
        public string Name;
        public Dough Dough;
        public Sauce Sauce;
        public List<Veggie> Veggies;
        public Cheese Cheese;
        public Pepperoni Pepperoni;
        public Clams Clams;

        //variable donde se guardara la fabrica de ingredientes que utilizara la pizza concreta
        public PizzaIngredientFactory IngredientFactory;

        protected Pizza(PizzaIngredientFactory ingrediente)// es protected porque solo sus subclases la mandaran llamar
        {
            IngredientFactory = ingrediente;
        }

        //clase abstracta prepare para que cada pizza en concreto utilice lo necesario
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Cocinando");
        }

        public void Cut()
        {
            Console.WriteLine("Cortando");
        }

        public void Box()
        {
            Console.WriteLine("Colocandola en la caja.");
        }

        public void SetName(string name)
        {
            Name = name;
        }

    }
}
