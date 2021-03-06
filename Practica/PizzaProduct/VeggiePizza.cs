﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class VeggiePizza : Pizza
    {
        //implementa en el contructor el constructor base de pizza
        public VeggiePizza(PizzaIngredientFactory ingrediente) : base(ingrediente)
        { }

        //aqui se establecen los ingredientes de la pizza que se utilizaran en base a la fabrica de ingredientes

        public override void Prepare()
        {
            Console.WriteLine("Preparando " + Name);
            Dough = IngredientFactory.CreateDough();
            Console.WriteLine("Agregando " + Dough.Name);
            Sauce = IngredientFactory.CreateSauce();
            Console.WriteLine("Agregando " + Sauce.Name);
            Cheese = IngredientFactory.CreateCheese();
            Console.WriteLine("Agregando " + Cheese.Name);
            Veggies = IngredientFactory.CreateVeggies();
            foreach (var V in Veggies)
            {
                Console.WriteLine("Agregando " + V.Name);
            }
        }
    }
}
