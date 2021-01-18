using System;
using System.Collections.Generic;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore Tienda = new NyStylePizzaStore();
            List<string> MenuD = new List<string>();
            foreach (StoreType Store in (StoreType[])Enum.GetValues(typeof(StoreType)))
            {
                MenuD.Add(Store.ToString());
            }
            //Agregando la opcion Salir
            MenuD.Add("Salir");

            while (true)
            {
                //cargar el menu de pizza store
                string Store = Menu.MultipleChoice(true, MenuD,"Selecciona una Pizza Store");
                //guardar la variable de tipo StoreType
                StoreType resultado = StoreType.ChicagoStylePizzaStore;//valor por defecto
                if(Store == "Salir")//Salida del programa
                {
                    break;
                }

                //Compararla con el texto retornado para obtener otravez el objeto
                foreach (StoreType Store2 in (StoreType[])Enum.GetValues(typeof(StoreType)))
                {
                    if (Store == Store2.ToString())
                    {
                        resultado = Store2;
                    }
                }
                //instanciando la pizza store seleccionada
                switch (resultado)
                {
                    case StoreType.ChicagoStylePizzaStore:
                        Tienda = new ChicagoStylePizzaStore();
                        break;
                    case StoreType.NewYorkStylePizzaStore:
                        Tienda = new NyStylePizzaStore();
                        break;
                }
                while(true)
                {
                    List<string> MenuP = new List<string>();
                    foreach (PizzaType Store3 in (PizzaType[])Enum.GetValues(typeof(PizzaType)))
                    {
                        MenuP.Add(Store3.ToString());
                    }
                    MenuP.Add("Salir");

                    string Seleccion = Menu.MultipleChoice(true, MenuP, "Selecciona un tipo de pizza");

                    PizzaType Seleccionp = PizzaType.Cheese;

                    if(Seleccion == "Salir")//Salida de la tienda
                    { 
                        break; 
                    }

                    foreach (PizzaType Store2 in (PizzaType[])Enum.GetValues(typeof(PizzaType)))
                    {
                        if (Seleccion == Store2.ToString())
                        {
                            Seleccionp = Store2;
                        }
                    }

                    Pizza pizza = Tienda.CreatePizza(Seleccionp);
                    Console.WriteLine($"Se a Ordenado una {pizza.Name}\n");
                    pizza.Prepare();
                    Console.ReadKey();



                }


            }
        }
    }
}
