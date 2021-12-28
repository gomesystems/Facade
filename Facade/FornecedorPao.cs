using Facade.Interface;
using System;

namespace Facade
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaodeAlho()
        {
            Console.WriteLine("Obtendo pão de alho. ");
        }

        public void BuscarPaodeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo pão de alho com queijo.");
        }

        private void ObterQueijo()
        {
            Console.WriteLine("Obtendo queijo. ");
        }
    }
}
    