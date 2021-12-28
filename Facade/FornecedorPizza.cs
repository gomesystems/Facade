using Facade.Interface;
using System;

namespace Facade
{
    public class FornecedorPizza : IPizza
    {
        public void BuscarPizzanormal()
        {
            ObterCoberturaÑaoVegana();
            Console.WriteLine("Buscando pizza normal. ");
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscado a pizza vegana.");
        }

        private void ObterCoberturaÑaoVegana()
        {
            Console.WriteLine("Obtendo a cobertura de pizza não vegetais. ");
        }

    }
}
