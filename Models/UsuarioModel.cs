namespace PaginaLogin.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String? Celular { get; set;}
        public String? Email { get; set; }
        public String? Endereco { get; set; }
    }
}
