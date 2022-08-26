using Microsoft.AspNetCore.Mvc;
using TodoApi.model.Clientes;
using TodoApi.repository;

namespace Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientes _clientes;
        public ClientesController(IClientes clientes)
        {
            _clientes = clientes;
        }

        [HttpGet]
        [Route("api/v1/clientes")]
        public async Task<IEnumerable<ClientesModel>> Get()
        {
            return await _clientes.GetAll();
        }

        [HttpPost]
        [Route("api/v1/clientes")]
        public async Task<ClientesModel> Post([FromBody]ClientesModel item)
        {
            return await _clientes.Add(item);
        }

        [HttpPut]
        [Route("api/v1/clientes")]
        public async Task<ClientesModel> Put([FromBody]ClientesModel item)
        {
            return await _clientes.Update(item);
        }

        [HttpDelete]
        [Route("api/v1/clientes/{id}")]
        public async Task<ClientesModel> Delete(int id)
        {
            return await _clientes.Remove(id);
        }

    }
}
