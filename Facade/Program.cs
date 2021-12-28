using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new RestauranteFacade();
                
            Console.WriteLine("------------------Pedidos de pizza do cliente-------------------\n");

            facade.BuscarPizzanormal();
            facade.BuscarPizzaVegana();


            Console.WriteLine("------------------Pedidos de Pão do cliente-------------------\n");

            facade.BuscarPaodeAlho();
            facade.BuscarPaodeAlhoComQueijo();
        }
    }
}
