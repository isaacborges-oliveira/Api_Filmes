using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja vamos implementar os métodos, toda a lógica dos métodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        private readonly Filmes_Context _context;

        /// <summary>
        /// Contrutor do repositorio 
        /// Aqui toda vez que o contrutor for chamado ,
        /// os dados do contexto estarão disponiveis
        /// </summary>
        /// <param name="contexto"></param>
        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }


        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                _context.Genero.Add(novoGenero);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


        }
        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGenero = _context.Genero.ToList();
                return listaGenero;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
