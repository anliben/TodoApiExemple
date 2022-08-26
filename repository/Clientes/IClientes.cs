
using TodoApi.model.Clientes;

namespace TodoApi.repository
{
    public interface IClientes
    {
        Task<IEnumerable<ClientesModel>> GetAll();
        ClientesModel Get(int id);
        Task<ClientesModel> Add(ClientesModel item);
        Task<ClientesModel> Remove(int id);
        Task<ClientesModel> Update(ClientesModel item);
    }
}
