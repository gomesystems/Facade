using Facade.Interface;

namespace Facade
{
    public class RestauranteFacade
    {
        private IPizza _FornecedorPizza;
        private IPao _FornecedorPao;

        public RestauranteFacade()
        {
            _FornecedorPizza = new FornecedorPizza();
            _FornecedorPao = new FornecedorPao();
        }

        public void BuscarPizzanormal()
        {
            _FornecedorPizza.BuscarPizzanormal();
        }

        public void BuscarPizzaVegana()
        {
            _FornecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaodeAlho()
        {
            _FornecedorPao.BuscarPaodeAlho();
        }

        public void BuscarPaodeAlhoComQueijo()
        {
            _FornecedorPao.BuscarPaodeAlhoComQueijo();
        }
                
    }

}
