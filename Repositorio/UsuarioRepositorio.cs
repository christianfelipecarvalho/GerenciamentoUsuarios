using PaginaLogin.Data;
using PaginaLogin.Models;

namespace PaginaLogin.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly BancoContent _context;
       
        public UsuarioRepositorio(BancoContent bancoContent)
        {
            this._context = bancoContent;
        }
        public UsuarioModel ListarPorId(int id)
        {

            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
           // Gravar no banco de dados 
           _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;

        }

        public List<UsuarioModel> BuscarTodos()
        {
          
            return _context.Usuarios.ToList();
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na atualização");

            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Cpf = usuario.Cpf;
            usuarioDB.Celular = usuario.Celular;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Endereco = usuario.Endereco;

            _context.Usuarios.Update(usuarioDB);
            _context.SaveChanges();

            return usuarioDB;
        }

        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB = ListarPorId(id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro ao apagar o contato");

            _context.Usuarios.Remove(usuarioDB);
            _context.SaveChanges();

            return true;

        }
    }
}
