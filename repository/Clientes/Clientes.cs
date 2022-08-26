using Microsoft.EntityFrameworkCore;
using TodoApi.model.Clientes;

namespace TodoApi.repository
{
    public class ClienteRepository : IClientes
    {
        public readonly ClientesContext _context;
        public ClienteRepository(ClientesContext context)
        {
            _context = context;
        }

        public async Task<ClientesModel> Add(ClientesModel item)
        {
            _context.ClientesModels.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public ClientesModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClientesModel>> GetAll()
        {
            return await _context.ClientesModels.ToListAsync();
        }

        public async Task<ClientesModel> Remove(int id)
        {
            ClientesModel cliente = await _context.ClientesModels.FindAsync(id);
            if (cliente != null)
            {
                _context.ClientesModels.Remove(cliente);
                _context.SaveChanges();
            }
            return await Task.FromResult(result: cliente);
        }

        public async Task<ClientesModel> Update(ClientesModel item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
